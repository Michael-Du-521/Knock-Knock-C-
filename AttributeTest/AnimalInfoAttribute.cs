using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTest
{
    internal class AnimalInfoAttribute : Attribute
    {//fields
        private string name;
        private string phylum;
        private string classis;
        private string familia;
//constructor
public AnimalInfoAttribute(string nameValue,string familiaValue)
        {
            name = nameValue;
            familia = familiaValue;
        }
    }
}
