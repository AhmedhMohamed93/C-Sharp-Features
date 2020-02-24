using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class SwitchExpressions
    {
        public static void Demo()
        {
            var i = 10;

            // basic syntax
            var x = i switch

            {

                1 => "one",
				2 => "two",
				3 => "three",
				_ => "many"  // discard = default

            };
            Console.WriteLine(x);


			// supports pattern matching
			string Display(object o) => o switch   
			{
				Point p when(p.X == 0) && (p.Y == 0)	=> "origin",
				Point p => $"({p.X}, {p.Y})",
				_										=> "unknown"
			};
             Console.WriteLine(Display(new Point(0, 0))); // origin


			
			string DisplayOld(object o)
            {
            switch (o)
             {
                case Point p when (p.X == 0) && (p.Y == 0):
                    return "origin";
                case Point p:
                    return $"({p.X}, {p.Y})";
                default:
                    return "unknown";
            }
            }
             Console.WriteLine(DisplayOld(new Point(0, 0)));
		}
    }
}
