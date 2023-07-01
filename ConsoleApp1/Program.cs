using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Singleton
    {
       private singleton() { }
        private static singleton _instance;
        private static object _lock=new object();
            public static singleton instance()
            {
                if (_instance == null)
                {
                lock (_lock)
                {
                    _instance = new singleton();
                }
                }
                return _instance;
            }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

}
