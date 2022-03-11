using System;
using System.Collections.Generic;
using System.Text;

namespace classTask.Model
{
    class Student:Person
    {
        
        public int course;

        public Student()
        { }
        public Student (string name)
        {
            this.name = name;
        }
        public Student (string name, string surname) : this(name)
        {
            this.surname = surname;
        }
        public Student(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }
        
    }
}
