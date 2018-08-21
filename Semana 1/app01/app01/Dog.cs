using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    class Dog : Animal
    {
        public Dog(int code, string name, string race, double size, double weight , int age)
        {
            this.Code = code;
            this.Weight = weight;
            this.Size = size;
            this.Age = age;
            this.Race = race;
            this.Name = name;
        }
        public string Name { get; set; }
        public string Race { get; set; }
    }
}
