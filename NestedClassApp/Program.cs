using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassApp
{
    class Configuration
    {
        private class ItemValue
        {
            private string item;
            private string value;

            public string GetItem(){ return item; }
            public string GetValue(){ return value; }

            public void SetValue(Configuration config,string item,string value)
            {
                this.item = item;
                this.value = value;
                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if(config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }

                }
                if(found == false)
                {
                    config.listConfig.Add(this);
                }
            }
        }

        List<ItemValue> listConfig = new List<ItemValue>();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
