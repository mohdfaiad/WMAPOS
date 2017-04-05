using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helper
{
    public class ResourceKeys : List<ResourceKey>
    {
        public void Add(string key, params object[] p)
        {
            Add(new ResourceKey { Key = key, Params = p });
        }
        public void Add(string key)
        {
            Add(new ResourceKey { Key = key });
        }
    }

    public class ResourceKey
    {
        public string Key { get; set; }

        public object[] Params { get; set; }
    }
}
