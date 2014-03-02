using System;
using BasicDataStructure;
using System.Collections.Generic;
/// <summary>
/// </summary>
///



namespace MyNamespace
{
    public class Employee
    {
        private string name;
        private int age;

        public string _name { get; set; }
        public int _age { get; set; }

       
        public override bool Equals (object B)
        {
            if (B == null) return false;
            if (GetType() != B.GetType()) return false;

            Employee C= (Employee) B;
            return (_name == C._name) && (_age == C._age);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() * _age;

        }

    }


    public class employee
    {
        private string name;
        private int age;

        public string _name { get; set; }
        public int _age { get; set; }


    }



}
