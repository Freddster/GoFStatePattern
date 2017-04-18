using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Flashlight FL = new Flashlight();

            FL.Power();
            FL.Power();
            FL.Power();
        }
    }
}
