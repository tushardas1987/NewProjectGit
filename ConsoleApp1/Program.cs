using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ain
    {
       private ain() { }
        private static ain _instance;
        private static object _lock=new object();
            public static ain instance()
            {
                if (_instance == null)
                {
                lock (_lock)
                {
                    _instance = new ain();
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
