using IO.Swagger.Logic;
using IO.Swagger.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            long key = 1;
            Dictionary<long, string> contentDict = new Dictionary<long, string>();
            Diff Idiff = new Diff();
            RequestBody body = new RequestBody();
            string data = "AAAAAA==";
            body.Data = data;
            Idiff.Add(contentDict,key, body);
            Assert.AreEqual(data, contentDict[key]);

            RequestBody body2 = new RequestBody();
            string data2 = "AAAQQQ==";
            body2.Data = data2;
            Idiff.Add(contentDict, key, body2);
            Assert.AreEqual(data2, contentDict[key]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            long key = 1;
            Dictionary<long, string> contentDict = new Dictionary<long, string>();
            Diff Idiff = new Diff();
            RequestBody body = new RequestBody();
            string data = "AAAAAA==";
            body.Data = data;
            Idiff.Add(contentDict, key, body);
            Assert.AreEqual(data, contentDict[key]);

            Dictionary<long, string> contentDict2 = new Dictionary<long, string>();
            RequestBody body2 = new RequestBody();
            string data2 = "AAAAAA==";
            body2.Data = data2;
            Idiff.Add(contentDict2, key, body2);
            Assert.AreEqual(data2, contentDict2[key]);

            ResponseBody rb = Idiff.Compare(contentDict, contentDict2, key);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.EqualsEnum, rb.DiffResultType);
        }

        [TestMethod]
        public void TestMethod3()
        {
            long key = 1;
            Dictionary<long, string> contentDict = new Dictionary<long, string>();
            Diff Idiff = new Diff();
            RequestBody body = new RequestBody();
            string data = "AAAAAA==";
            body.Data = data;
            Idiff.Add(contentDict, key, body);
            Assert.AreEqual(data, contentDict[key]);

            Dictionary<long, string> contentDict2 = new Dictionary<long, string>();
            RequestBody body2 = new RequestBody();
            string data2 = "AAA==";
            body2.Data = data2;
            Idiff.Add(contentDict2, key, body2);
            Assert.AreEqual(data2, contentDict2[key]);

            ResponseBody rb = Idiff.Compare(contentDict, contentDict2, key);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.SizeDoNotMatchEnum, rb.DiffResultType);
        }

        [TestMethod]
        public void TestMethod4()
        {
            long key = 1;
            Dictionary<long, string> contentDict = new Dictionary<long, string>();
            Diff Idiff = new Diff();
            RequestBody body = new RequestBody();
            string data = "AAAAAA==";
            body.Data = data;
            Idiff.Add(contentDict, key, body);
            Assert.AreEqual(data, contentDict[key]);

            Dictionary<long, string> contentDict2 = new Dictionary<long, string>();
            RequestBody body2 = new RequestBody();
            string data2 = "AQABAQ==";
            body2.Data = data2;
            Idiff.Add(contentDict2, key, body2);
            Assert.AreEqual(data2, contentDict2[key]);

            ResponseBody rb = Idiff.Compare(contentDict, contentDict2, key);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.ContentDoNotMatchEnum, rb.DiffResultType);
        }
    }
}
