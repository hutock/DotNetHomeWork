using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    class Customer
    {
        public string name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   name == customer.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
