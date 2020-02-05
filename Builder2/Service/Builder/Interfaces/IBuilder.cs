using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2.Service.Builder.Interfaces
{
    public interface IBuilder
    {
        void Reset();
        void SetServer(string server);
        void SetTimeout(string timeout);
        void SetUserId(string userId);
        void SetPassword(string password);
        void SetInitialDataBase(string initialDataBase);
        void SetTrustedConnection(string TrustedConnection);
    }
}
