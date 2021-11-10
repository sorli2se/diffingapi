using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestProject1.Logic;

namespace IO.Swagger.Logic
{
    public class Diff : IDiff
    {
        public void Add(Dictionary<long, string> contentDict, long key, RequestBody body)
        {
            if (contentDict.ContainsKey(key))
            {
                contentDict.Remove(key);
            }
            contentDict.Add(key, body.Data);
        }

        public ResponseBody Compare(Dictionary<long, string> leftPageDict, Dictionary<long, string> rightPageDict, long key)
        {
            byte[] leftContent = Utils.DecodeBase64(leftPageDict[(long)key]);
            byte[] rightContent = Utils.DecodeBase64(rightPageDict[(long)key]);

            if (leftContent.Equals(rightContent))
            {
                ResponseBody rb = new ResponseBody();
                rb.DiffResultType = ResponseBody.DiffResultTypeEnum.EqualsEnum;
                return rb;
            } else if (leftContent.Length != rightContent.Length)
            {
                ResponseBody rb = new ResponseBody();
                rb.DiffResultType = ResponseBody.DiffResultTypeEnum.SizeDoNotMatchEnum;
                return rb;
            } else
            {
                ResponseBody rb = new ResponseBody();
                rb.DiffResultType = ResponseBody.DiffResultTypeEnum.ContentDoNotMatchEnum;
                rb.Diffs = new DiffObject();
                DiffObject d = rb.Diffs;
                int offset = -1; int lenght = 0;
                for (int cn = 0; cn < leftContent.Length; cn ++)
                {
                    if (leftContent[cn] == rightContent[cn])
                    {
                        if (offset != -1)
                        {
                            Item item = new Item();
                            item.lenght = lenght;
                            item.offset = offset;

                            d.Add(item);
                        }
                        lenght = 0;
                        offset = -1;
                    }
                    else
                    {
                        if (offset == -1)
                        {
                            offset = cn;
                        } 
                        lenght++;

                    }
                }
                if (offset != -1)
                {
                    Item item = new Item();
                    item.lenght = lenght;
                    item.offset = offset;

                    d.Add(item);
                }
                return rb;
            }

        }
    }
}
