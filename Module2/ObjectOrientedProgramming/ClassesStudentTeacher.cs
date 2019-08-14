using System;

namespace ObjectOrientedProgramming
{
    class ClassesStudentTeacher
    {
        static void Main(string[] args)
        {
            Person my_person = new Person();
            my_person.greet();

            Student my_student = new Student();
            my_student.setAge(21);
            my_student.greet();
            my_student.showAge();

            Teacher my_teacher = new Teacher();
            my_teacher.setAge(30);
            my_teacher.greet();
            my_teacher.explain();
        }
    }
    class Person
    {
        protected int age;
        public void greet()
        {
            Console.WriteLine("Hello");
        }
        public void setAge(int n)
        {
            age = n;
        }
    }
    class Student : Person
    {
        public void showAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
        public void goToClassses()
        {
            Console.WriteLine("I'm going to class");
        }
    }
    class Teacher : Person
    {
        private string subject;
        public void explain()
        {
            Console.WriteLine("Explanation begins");
        }

    }
}
