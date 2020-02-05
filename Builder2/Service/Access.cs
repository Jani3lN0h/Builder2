using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2.Service
{
    public class Access
    {
        private readonly Dictionary<string, string> lstParts = new Dictionary<string, string>();

        public void Add(string part, string value)
        {
            this.lstParts.Add(part, value);
        }

        public string ConnectionString()
        {
            StringBuilder cMessage = new StringBuilder();
            
            foreach (KeyValuePair<string, string> registro in this.lstParts)
            {
                cMessage.Append(String.Format("{0}= {1};", registro.Key, registro.Value));
            }
            return "Access: " + cMessage + "\n";
        }
    }
}
