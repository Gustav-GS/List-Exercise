using System;
using System.Globalization;
using System.Collections.Generic;

namespace List_Exercise {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("How many employeers will be registered?: ");
            int workersAmount = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= workersAmount; i++) {
                Console.WriteLine("Employee #" + i + ": ");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
                }
            Console.WriteLine("Enter the id of the employee that will have the Salary increase: ");
            int idFind = int.Parse(Console.ReadLine());
            Employee workerList = list.Find(x => x.Id == idFind);
            if (workerList != null) {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                workerList.Increase(percentage);
                }
            else {
                Console.WriteLine("This id doesn't exist!");

                }
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
                }
            }
        }
    }

