using DatabaseSchemaReader;
using DatabaseSchemaReader.DataSchema;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace solverweb
{
    public class DbSchemaResolver
    {
        public IEdmModel GetEdmModel(string connectionString)
        {
            
            EdmModel model = new EdmModel();

            // create and add entity container
            EdmEntityContainer container = new EdmEntityContainer("NS", "DefaultContainer");
            model.AddElement(container);
            using (var cnn = new SqlConnection(connectionString))

            using (var dbReader = new DatabaseReader(cnn))
            {
                var schema = dbReader.ReadAll();

                foreach (var table in schema.Tables)
                {
                    if (table.Name.EndsWith("_Archive")) continue;

                    var tableType = new EdmEntityType("NS", table.Name);

                    foreach (var col in table.Columns)
                    {
                        var kind = GetKind(col);
                        if (!kind.HasValue) continue;


                        var prop = tableType.AddStructuralProperty(col.Name, kind.Value, col.Nullable);
                        if (col.IsPrimaryKey)
                        {
                            tableType.AddKeys(prop);
                        }

                    }
                    model.AddElement(tableType);

                    container.AddEntitySet(table.Name, tableType);

                }
            }

            return model;
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
