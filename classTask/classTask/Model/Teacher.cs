using System;
using System.Collections.Generic;
using System.Text;

namespace classTask.Model
{
    class Teacher:Person
    {
        public int salary;
        public Teacher()
        { }
        public Teacher(string name)
        {
            this.name = name;
        }
        public Teacher(string name, string surname) : this(name)
        {
            this.surname = surname;
        }
        public Teacher(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }
    }
}
