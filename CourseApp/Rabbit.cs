using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Rabbit
    {
       
            private string name;
            private int age;

            public Rabbit(int age, string name)
            {
                this.age = age;
                this.name = name;
            }

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Age
            {
                get => age;
                set => age = value;
            }

        public void GetInfo() => Console.WriteLine($"Возвраст: {age}  Имя: {name}");
        
    }
}
