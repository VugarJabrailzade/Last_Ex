using System;
using System.Threading.Channels;

namespace Overload
{
    public class Person
    {
        public string Name { get; private set; }
        public string SurName { get; private set;}
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public double  Height { get; private set; }

        public Person(string name, string surname, int age, double weight, double height)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return "Name:"+ Name + " " + "Surname:" + " " + SurName + " " + "Age:" + " " + Age + " " + "Weight:" + Weight + " " + "Height:" + Height;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {

            string pr_name=Console.ReadLine();
            string pr_surname= Console.ReadLine();
            int pr_age=int.Parse(Console.ReadLine());
            double pr_weight =double.Parse(Console.ReadLine());
            double pr_height=double.Parse(Console.ReadLine());


            Person pr = new(pr_name, pr_surname, pr_age, pr_weight, pr_height);
            
            Console.WriteLine(pr.ToString());

            
            
            





        }



    }












}