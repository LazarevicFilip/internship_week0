using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_week0.Domain
{
    internal class Cat : Animal, ICommunication
    {
        public Cat(string name, float weight, string furColor) : base(name, weight, furColor)
        {
        }

        protected override string Food => "Carnivorous";
        public void Communicate()
        {
            Console.WriteLine("Meows...");
        }
    }
}
