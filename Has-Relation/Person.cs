using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_Relation
{
    internal class Person
    {
        public string Name { get; }

        public int Age { get; }

        public Car firstCar { get; }

        public Person(string name, int age, Car firstCar)
        {
            Name = name;
            Age = age;
            this.firstCar = firstCar;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nCar:\n{firstCar.ToString()}";
        }
    }
}
