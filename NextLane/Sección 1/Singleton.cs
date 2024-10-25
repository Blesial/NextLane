using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLane.Sección_1
{
    public class Database
    {
        private static Database? instance;

        private Database()
        {
            Console.WriteLine("Conexión a base de datos inicializada");
        }

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public  void Query(string sql)
        {
            Console.WriteLine($"Ejecutando Consulta: {sql}");
        }
    }

}
