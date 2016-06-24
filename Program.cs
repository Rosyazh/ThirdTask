using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Practice: Develop a custom class Human containing basic information about a person and two subclasses of a Human class – Boy and Girl classes.
Represent differences of two classes by adding new methods and properties into subclasses; represent similarities by overriding methods and properties of a base class.
*/

namespace ThirdTask
{
    abstract class Human
    {
        private int age;
        private string name;
        private string surname;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public virtual double Mood
        {
            get
            {
                return 0;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("Personal information:");
        }
    }

    class Boy : Human
    {
        private int strength;
        private bool beer = false;

        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                if (value < 40)
                    strength = 40;
                else if (value > 200)
                    strength = 200;
                else
                    strength = value;
            }
        }

        public void Gym()
        {
            Random rand = new Random();
            Strength += rand.Next(1, 161);
        }
        
        public override double Mood
        {
            get
            {
                if (beer == false)
                    return (double)strength / 40;
                else
                    return (double)strength * 2 / 40;
            }
        }

        public void DrinkBeer(bool _beer)
        {
            beer = _beer;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Name: " + Name + "  Surname: " + Surname + "  Age: " + Age + " Strength: " + Strength + "  Mood: " + Mood + "\n");
        }
    }

    class Girl : Human
    {
        private int weight;
        private bool chocolate = false;

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value < 30)
                    weight = 30;
                else if (value > 150)
                    weight = 150;
                else
                    weight = value;
            }
        }

        public void Fitness()
        {
            Random rand = new Random();
            Weight -= rand.Next(1,121);
        }
        
        public override double Mood
        {
            get
            {
                if (chocolate == false)
                    return 150 / (double)weight;
                else
                    return 150 / ((double)weight / 2);
            }
        }

        public void EatChoco(bool _choco)
        {
            chocolate = _choco;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Name: " + Name + "  Surname: " + Surname + "  Age: " + Age + "  Weight: " + Weight + "  Mood: " + Mood + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Boy b1 = new Boy { Name = "Peter", Surname = "Ivanov", Age = 25, Strength = 40 };

            Girl g1 = new Girl { Name = "Julia", Surname = "Kiseleva", Age = 45, Weight = 150 };

            b1.DrinkBeer(true);
            b1.Gym();

            g1.EatChoco(true);
            g1.Fitness();

            b1.Print();
            g1.Print();
            
            Console.ReadKey();
        }
    }
}
