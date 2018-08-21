using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    class Animal
    {
        public Animal()
        {

        }
        public int Code { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public int Age { get; set; }
        public int GenerateRandomCode()
        {
            var r = new Random();
            return r.Next(1000, 999999);
        }
    }


}
