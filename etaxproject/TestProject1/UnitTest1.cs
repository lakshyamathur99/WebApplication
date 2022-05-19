
using etaxproject.Controllers;
using etaxproject.Interface;
using etaxproject.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
       private Mock<Interface1> _lnterface;
        private LoginnController ln;
        [SetUp]
        public void Setup()
        {
            _lnterface= new Mock<Interface1>();
            ln = new LoginnController(_lnterface.Object);

        }
        [Test]
        public void checklogin()
        {
            
            //LoginnController ln = new LoginnController(_lnterface.Object);
           
        
        var l = new Login{UserName = "gopak", Password = "gopal" };
            _lnterface.Setup(fr => fr.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(value:null);


            object n = new { Status = "Invalid", Message = "Invalid User" };

            object con = ln.userLogin(l);
            NUnit.Framework.Assert.AreEqual(n,con);

        }
       
    }
}