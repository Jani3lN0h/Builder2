using Builder2.Service;
using Builder2.Service.Builder;
using Builder2.Service.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elige la cadena que desea generar: ");
            Console.WriteLine("1 - Access");
            Console.WriteLine("2 - MySQL");
            Console.WriteLine("3 - SQL");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ResetColor();
            int iTipoCadena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Crear Conexión:");
            switch (iTipoCadena)
            {
                case 1:
                    AccessBuilder accessBuilder = new AccessBuilder();
                    director.Builder = accessBuilder;
                    director.AccessConection();
                    Console.WriteLine(accessBuilder.GetResult().ConnectionString());
                    break;
                case 2:
                    MySQLBuilder mySQLBuilder = new MySQLBuilder();
                    director.Builder = mySQLBuilder;
                    director.MySQLConection();
                    Console.WriteLine(mySQLBuilder.GetResult().ConnectionString());
                    break;
                case 3:
                    SQLBuilder sqlBuilder = new SQLBuilder();
                    director.Builder = sqlBuilder;
                    director.SQLConection();
                    Console.WriteLine(sqlBuilder.GetResult().ConnectionString());
                    break;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nPresione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
