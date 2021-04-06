using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTextJSONTest
{
    [Serializable]
    public class Address
    {
        public int HouseNumber;
        public string City { get; set; }
        public int PINCode { get; set; }
        public string State { get; set; }
    }
}
