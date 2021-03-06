# solverdemo
demo implemented for solver 


### Background

Our product allows a customer to define a data warehouse specific to their needs via a web interface. Because of this, we can make very few assumptions about the underlying structure of the tables in their tenant database. For example, we have meta-information about the defined columns so that we can determine the customer defined name of a column for display, but the column name itself is generated by code and the type of the column is set by the user. For example, a customer could have a column named UDF1 with a label of 'Widgets in Stock' of type Integer. This doesn't really apply specifically to this challenge; it's more to illustrate how generic our code has to be.

​

### The Problem

Build an API endpoint that will allow a customer to display data dynamically from any given table in a database.

The code should be generic enough to work properly for any table or database. You should be able to return a JSON representation of the data stored in the table that a front-end could then display. An example endpoint could be http://localhost:12345/data/TableName though feel free to change as you like.

​

### Expectations

The goal is to have enough code for us to get an idea of how you structure your code, your style, how you name variables, etc., while dealing with a problem similar to our day to day challenges.

The hope isn't for you to spend a lot of time on this challenge, at most maybe an hour or two. We do hope that you are able to produce something you feel is a good representation of your code quality and skills.

Additionally, write some notes talking about ideas you had and discarded, ideas you pursued, different choices you came across and why you picked the ones you did,  trade-offs you encountered, possible future changes you might make, etc.

​

### Bonus points

If you have time to spare and feel like continuing, here's some additional challenges. If you don't pursue them, then they might come up as part of the next interview in a collaborative session so consider these a spoiler:

* Can we make the amount of JSON returned smaller in any way?

* Can we add support for paging?

* Can we add a simple front-end to show it working?

* Can we follow foreign keys to display values?


----

### Implementation

The solution is implemented as an ODATA webservice (Microsoft.AspNetCore.OData). The routes follow OData specifications.
T4 templates are used to generate data models, odata controllers, dbcontext and wireup.  I used the WideWorldImporters database for the purpose of this demo 
but any database could be used by changing a connection string and rebuilding the project. It would be possible to build multiple sites for different 
databases by building the same project with different configurations.



#### Service Metadata
https://localhost:44302/odata/$metadata

##### List available Entities 
e.g. https://localhost:44302/odata  shows a list of all available Entities (i.e. tables)

##### List Entity records (e.g. all Cities records)

e.g. https://localhost:44302/odata/Cities

This uses server side paging so to get the next page of cities use

https://localhost:44302/odata/Cities?$skip=20 (a link to the next page is included in the result as @odata.nextLink )

##### Select Entity by Primary Key
e.g. https://localhost:44302/odata/Cities(CityId=19) 
or https://localhost:44302/odata/Cities(19)

##### Select using some other filter (e.g. 
https://localhost:44302/odata/Cities?$filter=LatestRecordedPopulation%20lt%20200

#### Limit the output to selected properties
e.g. https://localhost:44302/odata/Cities?$select=CityID,CityName

#### Sort 
e.g. https://localhost:44302/odata/Cities?$orderby=LatestRecordedPopulation desc

## ToDo

include db name and schema name in route to avoid potential ambiguities

implement foreign key links (supported by odata but I didn't implement for the sake of time)

refactor configuration to support multiple databases

implement some kind of whitelist or blacklist to control which tables to expose




