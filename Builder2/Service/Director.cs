using Builder2.Service.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2.Service
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void AccessConection()
        {
            this._builder.Reset();
            Console.WriteLine("Ingresa la DB:");
            string cDataBase = Console.ReadLine();
            this._builder.SetInitialDataBase(cDataBase);
            Console.WriteLine("Ingresa la constraseña:");
            string cPassword = Console.ReadLine();
            this._builder.SetPassword(cPassword);
        }

        public void MySQLConection()
        {
            this._builder.Reset();
            Console.WriteLine("Ingresa el Servidor:");
            string cServer = Console.ReadLine();
            this._builder.SetServer(cServer);
            Console.WriteLine("Ingresa la DB:");
            string cDataBase = Console.ReadLine();
            this._builder.SetInitialDataBase(cDataBase);
            Console.WriteLine("Ingresa el usuario:");
            string cUser = Console.ReadLine();
            this._builder.SetUserId(cUser);
            Console.WriteLine("Ingresa la constraseña:");
            string cPassword = Console.ReadLine();
            this._builder.SetPassword(cPassword);
        }

        public void SQLConection()
        {
            this._builder.Reset();
            Console.WriteLine("Ingresa el Servidor:");
            string cServer = Console.ReadLine();
            this._builder.SetServer(cServer);
            Console.WriteLine("Ingresa la DB:");
            string cDataBase = Console.ReadLine();
            this._builder.SetInitialDataBase(cDataBase);
            Console.WriteLine("Ingresa el usuario:");
            string cUser = Console.ReadLine();
            this._builder.SetUserId(cUser);
            Console.WriteLine("Ingresa la constraseña:");
            string cPassword = Console.ReadLine();
            this._builder.SetPassword(cPassword);
            Console.WriteLine("Conexión Segura:");
            string cTrustConection = Console.ReadLine();
            this._builder.SetTrustedConnection(cTrustConection);
        }
    }
}
