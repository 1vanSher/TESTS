using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using test4;
using Moq;
using DotNet.Testcontainers.Containers;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Configurations;
using Npgsql;

namespace Test4Tests
{

    [TestClass]

    public class TriangleValidateServiceTest
    {
        private Mock<ITriangleProvider> triangleProvider;
        private ITriangleService triangleService;
        private ITriangleValidateService triangleValidateService;
        [TestInitialize]
        public void TestInitialize()
        {
            triangleProvider = new Mock<ITriangleProvider>();
            triangleService = new TriangleService();
            triangleValidateService = new TriangleValidateService(triangleProvider.Object, triangleService);
        }
        [TestMethod]
        public void TriangleValidateServiceIsValid()
        {
            triangleProvider.Setup(a => a.GetById(It.IsAny<long>())).Returns(new Triangle(3, 3, 5, "разносторонний", 4, 13));
            Assert.AreEqual(true, triangleValidateService.IsValid(1));
        }

        [TestMethod]
        public void TriangleValidateServiceIsAllValid()
        {
            triangleProvider.Setup(a => a.GetAll()).Returns(new List<Triangle> { new Triangle(3, 3, 5, "разносторонний", 4, 1), new Triangle(3, 3, 5, "разносторонний", 4, 2) });
            Assert.AreEqual(true, triangleValidateService.IsAllValid());
        }

    }
    [TestClass]

    public class TriangleValidateServiceIntegrationTests
    {
        private ITriangleProvider triangleProvider;
        private ITriangleService triangleService;
        private ITriangleValidateService triangleValidateService;
        private readonly TestcontainerDatabase testcontainers = new ContainerBuilder<PostgreSqlTestcontainer>()
       .WithDatabase(new PostgreSqlTestcontainerConfiguration
       {
           Database = "db",
           Username = "postgres",
           Password = "postgres",
       })
       .Build();

        [TestInitialize]

        public void TestInitialize()
        {
            
            testcontainers.StartAsync().Wait();
            using (var con = new NpgsqlConnection(testcontainers.ConnectionString))
            {
                con.Open();
                string sql = "CREATE TABLE Triangles( A REAL NOT NULL, B REAL NOT NULL, C REAL NOT NULL, Type TEXT NOT NULL, Square REAL NOT NULL, id INTEGER NOT NULL PRIMARY KEY)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.ExecuteNonQuery();
            }
            triangleProvider = new TriangleProvider(testcontainers.ConnectionString);
            triangleService = new TriangleService();
            triangleValidateService = new TriangleValidateService(triangleProvider, triangleService);
        }


        [TestMethod]
        public void IsValid_true()
        {
            triangleProvider.save(new Triangle(3, 3, 5, "разносторонний", 4, 1));
            Assert.AreEqual(true, triangleValidateService.IsValid(1));
        }

        [TestMethod]
        public void IsAllValid_true()
        {
            triangleProvider.save(new Triangle(3, 3, 5, "разносторонний", 4, 2));
            triangleProvider.save(new Triangle(3, 3, 5, "разносторонний", 4, 3));
            Assert.AreEqual(true, triangleValidateService.IsAllValid());
        }

    }
}
