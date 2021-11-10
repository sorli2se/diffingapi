using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            string leftContent = leftPageDict[(long)key];
            string rightContent = rightPageDict[(long)key];

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
                int offset = 0; int lenght = 0;
                for (int cn = 0; cn < leftContent.Length; cn ++)
                {
                    if (leftContent[cn] == rightContent[cn])
                    {
                        lenght = 0;
                        offset = 0;
                    }
                    else
                    {
                        if (offset == 0)
                        {
                            offset = cn;
                        } 
                        lenght++;
                        Item item = new Item();
                        item.lenght = lenght;
                        item.offset = offset;

                        d.Add(item);
                    }
                }

                return rb;
            }

        }
    }
}
