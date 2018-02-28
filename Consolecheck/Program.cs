using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Consolecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicaContext context=new ElectronicaContext();
            context.Database.Create();
            Console.WriteLine("Success");
            Console.Read();
        }
    }
}
