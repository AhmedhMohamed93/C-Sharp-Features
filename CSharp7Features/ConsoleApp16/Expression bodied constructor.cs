using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Expression_bodied_constructor
    {
        public int ProductId
        {get;} = 1;
        public string ProductName
        {
            get;
        }
        public decimal Price => 3000;
        public Expression_bodied_constructor() => ProductName = "Microsoft HoloLens";
    }
}
