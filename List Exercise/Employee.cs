using System;
using System.Globalization;

namespace List_Exercise {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
            }
        public void Increase (double amount){
            Salary = Salary +(Salary * amount / 100);
            }
        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
