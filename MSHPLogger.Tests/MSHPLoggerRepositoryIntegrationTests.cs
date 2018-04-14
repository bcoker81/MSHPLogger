using System;
using System.Linq;
using MSHPLogger.Entities;
using MSHPLogger.Repository.Interfaces;
using MSHPLogger.Repository.Repositories;
using NUnit.Framework;

namespace MSHPLogger.Tests
{
    [TestFixture]
    public class MSHPLoggerRepositoryIntegrationTests
    {
        private LoggerContext db;
        private LogRepository testObj;
        [SetUp]
        public void Setup()
        {
            testObj = new LogRepository();
            db = new LoggerContext();
        }

        [TearDown]
        public void TearDown()
        {
            db.LogEntries.RemoveRange(db.LogEntries);
            db.SaveChanges();
        }


        [Test]
        public void TestMethod1()
        {
            //arrange
            LogEntry log = new LogEntry
            {
                AppCode = "CJ97",
                ErrorClass = "CJ97Repository",
                Platform = ".Net",
                TransactionDate = DateTime.Now,
                UserName = "billy.bob@mshp.dps.mo.gov",
                ExceptionCode = "error exception goes here."
            };

            //act
            testObj.LogError(log);
            LogEntry expected = new LogEntry();
           
            expected = db.LogEntries.First(p => p.AppCode == "CJ97");

            //assert
            Assert.AreEqual(expected.AppCode, log.AppCode);
        }
    }
}
