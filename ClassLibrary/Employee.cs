using System;
namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        count++;
                    }

                    if (count == 0 && char.IsUpper(value[0]))
                    {
                        this._name = value;
                    }
                }

            }
        }
            public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        count++;
                    }

                    if(count == 0 && char.IsUpper(value[0]))
                    {
                        this._surname = value;
                    }
                }
            }
        }

        public double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                if (value >= 250)
                {
                    this._salary = value;
                }
            }
        }
        }
    }