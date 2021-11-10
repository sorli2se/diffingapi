using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IO.Swagger.Logic
{
    interface IDiff
    {
        void Add(Dictionary<long, string> contentDict, long key, RequestBody body);
        ResponseBody Compare(Dictionary<long, string> leftPageDict, Dictionary<long, string> rightPageDict, long key);

    }
}
