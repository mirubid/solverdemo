using NUnit.Framework;
using DatabaseSchemaReader;
using System.Data.SqlClient;
using Microsoft.OData.Edm;
using DatabaseSchemaReader.DataSchema;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;
using System.Collections.Generic;

namespace solvertest
{
    /// <summary>
    /// these aren't really unit tests, I just used the unit test framework to test out how things work
    /// </summary>
    [TestFixture]
    public class DbSchemaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        IList<DatabaseColumn> GetKeys(DatabaseTable table)
        {
            return table.Columns.Where(col => col.IsPrimaryKey).ToList();
        }
        [Test]
        public void ShouldBeAbleToLoadAllTables()
        {


             
            var cb = new ConfigurationBuilder();
            Microsoft.Extensions.Configuration.JsonConfigurationExtensions.AddJsonFile(cb, "appsettings.json");
            IConfiguration config = cb.Build();

            var connectionString = config.GetConnectionString("db");
            
            EdmModel model = new EdmModel();

            // create and add entity container
            EdmEntityContainer container = new EdmEntityContainer("NS", "DefaultContainer");
            model.AddElement(container);

            using (var cnn = new SqlConnection(connectionString))            
            using (var dbReader = new DatabaseReader(cnn))
            {
                var schema = dbReader.ReadAll();
                
                foreach(var table in schema.Tables)
                {
                    if (table.Name.EndsWith("_Archive")) continue;

                    
                    var tableType = new EdmEntityType("NS", table.Name);
                    
                    
                    TestContext.Write($"table {table.SchemaOwner} {table.Name}");
                    TestContext.Write("(");

                    foreach(var col in table.Columns)
                    {
                        var kind = GetKind(col);
                        if (!kind.HasValue) continue;



                        TestContext.Write($"{col.Name} {kind},");

                        var prop = tableType.AddStructuralProperty(col.Name, kind.Value,col.Nullable);
                        if (col.IsPrimaryKey)
                        {
                            tableType.AddKeys(prop);
                        }

                    }
                    TestContext.WriteLine(")");
                }
            }
        }
        [Test]
        public void ShouldBeAbleToListForeignKeys()
        {



            var cb = new ConfigurationBuilder();
            Microsoft.Extensions.Configuration.JsonConfigurationExtensions.AddJsonFile(cb, "appsettings.json");
            IConfiguration config = cb.Build();

            var connectionString = config.GetConnectionString("db");

            EdmModel model = new EdmModel();

            // create and add entity container
            EdmEntityContainer container = new EdmEntityContainer("NS", "DefaultContainer");
            model.AddElement(container);
            DatabaseSchema schema = null;

            using (var cnn = new SqlConnection(connectionString))
            using (var dbReader = new DatabaseReader(cnn))
            {
                 schema = dbReader.ReadAll();                
            }
            foreach (var table in schema.Tables)
            {
                if (table.Name.EndsWith("_Archive")) continue;


                var tableType = new EdmEntityType("NS", table.Name);


                TestContext.Write($"table {table.SchemaOwner} {table.Name}");
                TestContext.Write("(");
                foreach (var fk in table.ForeignKeys)
                {
                    TestContext.WriteLine($"FK {fk.Name} {fk.SchemaOwner }.{fk.TableName} ({string.Join(",", fk.Columns)}) ==> {fk.RefersToSchema}.{fk.RefersToTable} ({string.Join(",", fk.ReferencedColumns(schema))}) ");
                }

                TestContext.WriteLine(")");
            }
        }
        [Test]
        public void ShouldBeAbleToUseDbContext()
        {
            var db = new TestDbContext();

            var cities=db.Cities.Take(4).ToList();

            Assert.IsNotNull(cities);

            Assert.AreNotEqual(0, cities.Count);

            foreach(var city in cities)
            {
                TestContext.WriteLine($"{city.CityID}  {city.CityName}");
            }
        }

        [Test]
        public void ShouldBeAbleToQueryDbContext()
        {
            var db = new TestDbContext();

            var city = db.Cities.Where(c => c.CityID == 4).First();

            Assert.IsNotNull(city);

            
            TestContext.WriteLine($"{city.CityID}  {city.CityName}");
            
        }

        private static EdmPrimitiveTypeKind? GetKind(DatabaseColumn col)
        {
            var dt = col.DataType;
            if (col.DataType == null)
                return null;

            Type type = col.DataType.GetNetType();
            
            if (type == null)
                return null;

            if (type == typeof(string))
                return EdmPrimitiveTypeKind.String;

            if (type == typeof(short))
                return EdmPrimitiveTypeKind.Int16;

            if (type == typeof(int))
                return EdmPrimitiveTypeKind.Int32;

            if (type == typeof(long))
                return EdmPrimitiveTypeKind.Int64;

            if (type == typeof(bool))
                return EdmPrimitiveTypeKind.Boolean;

            if (type == typeof(Guid))
                return EdmPrimitiveTypeKind.Guid;

            if (type == typeof(DateTime))
                return EdmPrimitiveTypeKind.DateTimeOffset;

            if (type == typeof(TimeSpan))
                return EdmPrimitiveTypeKind.Duration;

            if (type == typeof(decimal))
                return EdmPrimitiveTypeKind.Decimal;

            if (type == typeof(byte) || type == typeof(sbyte))
                return EdmPrimitiveTypeKind.Byte;

            if (type == typeof(byte[]))
                return EdmPrimitiveTypeKind.Binary;

            if (type == typeof(double))
                return EdmPrimitiveTypeKind.Double;

            if (type == typeof(float))
                return EdmPrimitiveTypeKind.Single;

            return null;
        }
    }
}