﻿using DapperExtensions.Sql;
using NUnit.Framework;
using System.Data.SQLite;

namespace DapperExtensions.Test.IntegrationTests.Async.Sqlite
{
    [NonParallelizable]
    public class SqliteBaseAsyncFixture : PortableDatabaseAsyncTestsFixture
    {
        [SetUp]
        public virtual void Setup()
        {
            SQLiteConnection connection = new SQLiteConnection(ProcessedConnectionString("Sqlite"));

            CommonSetup(connection, new SqliteDialect());

            ExecuteScripts(connection, true, CreateTableScripts);

            //var files = new List<string>
            //                    {
            //                        ReadFile("CreateAnimalTable"),
            //                        ReadFile("CreateFooTable"),
            //                        ReadFile("CreateMultikeyTable"),
            //                        ReadFile("CreatePersonTable"),
            //                        ReadFile("CreateCarTable")
            //                    };

            //foreach (var setupFile in files)
            //{
            //    connection.Execute(setupFile);
            //}
        }
    }
}