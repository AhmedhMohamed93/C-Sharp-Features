using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public struct MyPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public /* readonly */ double Distance => Math.Sqrt(X * X + Y * Y);

        public  readonly  override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";

        public /* readonly */ void Translate(int xOffset, int yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }
    }
}
