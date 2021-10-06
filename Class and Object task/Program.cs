using System;

namespace Class_and_Object_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Garfield = new Cat("Garfield", "Persian Tabby", 7, "orange");
            Console.WriteLine(Garfield.toString());
        }
        public class Cat
        {
            String name;
            String breed;
            int age;
            String color;

            public Cat(String name,String breed,int age,String color)
            {
                this.name = name;
                this.breed = breed;
                this.age = age;
                this.color = color;

            }
            public string getname()
            {
                return name;
            }
            public string getbreed()
            {
                return breed;
            }
            public int getage()
            {
                return age;

            }
            public string getcolor()
            {
                return color;

            }
            public string toString()
            {
                return ("Hi my name is " + this.getname()
                + ".\nMy breed, age and color are " + this.getbreed()
                + ", " + this.getage() + ", " + this.getcolor());
            }
        }
    }
}
