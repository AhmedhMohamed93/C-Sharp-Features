using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpFeatures
{
    class TargetTypedNew
    {
        public static void Demo()
        {
            // Current C#
            using (var reader = XmlReader.Create("https://knowledge-base.havit.eu/feed/", new XmlReaderSettings() { IgnoreWhitespace = true })) { }

        }
    }
}
