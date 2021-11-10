using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private LeftApi leftApiInstance;
        private RightApi rightApiInstance;
        private DiffApi diffApiInstance;
        private string basePath = "http://localhost:50352/v1/";


        /*
         * Run only first time after server starts
         */
        /*[TestMethod]
        public void TestMethod1()
        {
            Configuration c = new Configuration();
            c.BasePath = basePath;
            diffApiInstance = new DiffApi(c);

            ApiResponse<ResponseBody> apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(404, apiob.StatusCode);

            leftApiInstance = new LeftApi(c);
            rightApiInstance = new RightApi(c);

            RequestBody rb = new RequestBody();
            rb.Data = "AAAAAA==";
            ApiResponse<object> apirb = leftApiInstance.UpdateLeft(1, rb);
            Assert.AreEqual(201, apirb.StatusCode);

            apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(404, apiob.StatusCode);

            RequestBody rb2 = new RequestBody();
            rb2.Data = "AAAAAA==";
            apirb = rightApiInstance.UpdateRight(1, rb2);
            Assert.AreEqual(201, apirb.StatusCode);

            apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(200, apiob.StatusCode);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.EqualsEnum, apiob.Data.DiffResultType);

            RequestBody rb3 = new RequestBody();
            rb3.Data = "AQABAQ==";
            apirb = rightApiInstance.UpdateRight(1, rb3);
            Assert.AreEqual(201, apirb.StatusCode);

            apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(200, apiob.StatusCode);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.ContentDoNotMatchEnum, apiob.Data.DiffResultType);

            DiffObject do1 = new DiffObject();
            Item i = new Item();
            i.lenght = 1;
            i.offset = 1;
            do1.Add(i);
            i = new Item();
            i.lenght = 1;
            i.offset = 3;
            do1.Add(i);
            i = new Item();
            i.lenght = 1;
            i.offset = 5;
            do1.Add(i);
            Assert.AreEqual(do1.ToJson(), apiob.Data.Diffs.ToJson());


            RequestBody rb4 = new RequestBody();
            rb4.Data = "AAA=";
            apirb = rightApiInstance.UpdateRight(1, rb4);
            Assert.AreEqual(201, apirb.StatusCode);

            apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(200, apiob.StatusCode);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.SizeDoNotMatchEnum, apiob.Data.DiffResultType);

        }*/

        /*
         * Always pass
         */
        [TestMethod]
        public void TestMethod2()
        {
            Configuration c = new Configuration();
            c.BasePath = basePath;
            diffApiInstance = new DiffApi(c);


            leftApiInstance = new LeftApi(c);
            rightApiInstance = new RightApi(c);

            RequestBody rb = new RequestBody();
            rb.Data = "AAAAAA==";
            ApiResponse<object> apirb = leftApiInstance.UpdateLeft(1, rb);
            Assert.AreEqual(201, apirb.StatusCode);

            RequestBody rb2 = new RequestBody();
            rb2.Data = "AAAAAA==";
            ApiResponse<object> apirb2 = rightApiInstance.UpdateRight(1, rb2);
            Assert.AreEqual(201, apirb2.StatusCode);

            ApiResponse<ResponseBody> apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(200, apiob.StatusCode);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.EqualsEnum, apiob.Data.DiffResultType);

            RequestBody rb3 = new RequestBody();
            rb3.Data = "AQABAQ==";
            apirb = rightApiInstance.UpdateRight(1, rb3);
            Assert.AreEqual(201, apirb.StatusCode);

            apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(200, apiob.StatusCode);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.ContentDoNotMatchEnum, apiob.Data.DiffResultType);

            DiffObject do1 = new DiffObject();
            Item i = new Item();
            i.lenght = 1;
            i.offset = 0;
            do1.Add(i);
            i = new Item();
            i.lenght = 2;
            i.offset = 2;
            do1.Add(i);
            Assert.AreEqual(do1.ToJson(), apiob.Data.Diffs.ToJson());


            RequestBody rb4 = new RequestBody();
            rb4.Data = "AAA=";
            apirb = rightApiInstance.UpdateRight(1, rb4);
            Assert.AreEqual(201, apirb.StatusCode);

            apiob = diffApiInstance.GetDiff(1);
            Assert.AreEqual(200, apiob.StatusCode);
            Assert.AreEqual(ResponseBody.DiffResultTypeEnum.SizeDoNotMatchEnum, apiob.Data.DiffResultType);

        }
        /*
         * Request with null
         */
        [TestMethod]
        public void TestMethod6()
        {
            Configuration c = new Configuration();
            c.BasePath = basePath;
            rightApiInstance = new RightApi(c);

            RequestBody rb5 = new RequestBody();
            rb5.Data = null;
            ApiResponse<object>  apirb = rightApiInstance.UpdateRight(1, rb5);
            Assert.AreEqual(400, apirb.StatusCode);

        }
    }
}
