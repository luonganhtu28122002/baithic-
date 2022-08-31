
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Lion : tbase
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }

        public Lion() { }
        public Lion(int weight, string name) : base(weight, name)
        {
            Weight = weight;
            Name = name;
        }
        public override string ToString()
        {
            return "Name :" + Name + " Weight :" + Weight;
        }

        public override void SetMe(int weight, string name)
        {
            Console.WriteLine("Fix Weight , Fix Name :");
            Weight = weight;
            Name = name;
        }

        public override void Show()
        {
            Name = "Lion";
            Weight = 100;
            Console.WriteLine(ToString());
        }


    }
}