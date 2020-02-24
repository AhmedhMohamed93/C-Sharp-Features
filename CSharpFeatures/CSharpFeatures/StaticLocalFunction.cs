using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class StaticLocalFunction
    {
        public static void Demo()
        {
            void DoSomething(object x)
            {
                Console.WriteLine(x.ToString());
                Thread.Sleep(2000);
            }

            DoSomething("Calling static local function...");
        }
    }
}
