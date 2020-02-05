using Builder2.Service.Builder.Interfaces;

namespace Builder2.Service.Builder
{
    public class SQLBuilder : IBuilder
    {
        private SQL sql = new SQL();
        public void Reset()
        {
            this.sql = new SQL();
        }

        public void SetInitialDataBase(string initialDataBase)
        {
            sql.Add("DataBase", initialDataBase);
        }

        public void SetPassword(string password)
        {
            sql.Add("Password", password);
        }

        public void SetServer(string server)
        {
            sql.Add("Server", server);
        }

        public void SetTimeout(string timeout)
        {
            sql.Add("TimeOut", timeout);
        }

        public void SetTrustedConnection(string TrustedConnection)
        {
            sql.Add("Trusted_Connection", TrustedConnection);
        }

        public void SetUserId(string userId)
        {
            sql.Add("User Id", userId);
        }

        public SQL GetResult()
        {
            SQL result = this.sql;

            this.Reset();

            return result;
        }
    }
}
