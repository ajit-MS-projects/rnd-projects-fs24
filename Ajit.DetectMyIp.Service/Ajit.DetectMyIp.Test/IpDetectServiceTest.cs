﻿using Ajit.DetectMyIp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ajit.DetectMyIp.Test
{
    
    
    /// <summary>
    ///This is a test class for IpDetectServiceTest and is intended
    ///to contain all IpDetectServiceTest Unit Tests
    ///</summary>
	[TestClass()]
	public class IpDetectServiceTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for GetMyIp
		///</summary>
		[TestMethod()]
		public void GetMyIpTest()
		{
			string expected = "92.42.224.42"; 
			string actual = IpDetectService.GetMyIp();
			Assert.AreEqual(expected, actual);
		}
	}
}
