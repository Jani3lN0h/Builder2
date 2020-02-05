using Builder2.Service.Builder.Interfaces;

namespace Builder2.Service.Builder
{
    public class MySQLBuilder : IBuilder
    {
        private MySQL mySQL = new MySQL();
        public void Reset()
        {
            this.mySQL = new MySQL();
        }

        public void SetInitialDataBase(string initialDataBase)
        {
            mySQL.Add("DataBase", initialDataBase);
        }

        public void SetPassword(string password)
        {
            mySQL.Add("Pwd", password);
        }

        public void SetServer(string server)
        {
            mySQL.Add("Server", server);
        }

        public void SetTimeout(string timeout)
        {
            mySQL.Add("TimeOut", timeout);
        }

        public void SetTrustedConnection(string TrustedConnection)
        {
            mySQL.Add("Trusted Connection", TrustedConnection);
        }

        public void SetUserId(string userId)
        {
            mySQL.Add("Uid", userId);
        }

        public MySQL GetResult()
        {
            MySQL result = this.mySQL;

            this.Reset();

            return result;
        }
    }
}
