using Builder2.Service.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2.Service.Builder
{
    public class AccessBuilder : IBuilder
    {
        private Access access = new Access();

        public AccessBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.access = new Access();
            access.Add("Provider", "Microsoft.ACE.OLEDB.12.0");
        }

        public void SetInitialDataBase(string initialDataBase)
        {
            access.Add("Data Source", initialDataBase);
        }

        public void SetPassword(string password)
        {
            access.Add("Jet OLEDB:Database Password", password);
        }

        public void SetServer(string server)
        {
            access.Add("Database Server", server);
        }

        public void SetTimeout(string timeout)
        {
            access.Add("TimeOut", timeout);
        }

        public void SetTrustedConnection(string TrustedConnection)
        {
            access.Add("Trusted Connection", TrustedConnection);
        }

        public void SetUserId(string userId)
        {
            access.Add("UserId", userId);
        }

        public Access GetResult()
        {
            Access result = this.access;

            this.Reset();

            return result;
        }
    }
}
