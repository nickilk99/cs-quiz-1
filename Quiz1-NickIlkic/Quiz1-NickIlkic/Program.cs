using System;
using System.Collections.Generic;
using Extensions;

namespace Quiz1_NickIlkic
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. 2- Create a class Name is as Employee (id, name, salary)
            //a.Use a generic collection to put 5 employees in that. (Use optional data)
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1, "Nick", 50000));
            empList.Add(new Employee(2, "Alice", 60000));
            empList.Add(new Employee(3, "Bob", 70000));
            empList.Add(new Employee(4, "Eve", 80000));
            empList.Add(new Employee(5, "Mary", 90000));

            //b. Iterate through the collection and Write the name of the employee in the console. 
            empList.ForEach(emp => Console.WriteLine(emp.empName));

            //c.Use delegate to find the lowest and highest salary among the employee
            findSal highest = findHighest;
            findSal lowest = findLowest;
            Console.WriteLine("highest " + highest(empList));
            Console.WriteLine("lowest " + lowest(empList));



            //3 - Use Tuple to create an object which has 3 fields(name, age, address) and print the fields in the console.
            var ob = Tuple.Create<string, int, int>("Nick", 30, 4444);
            //a. User Interpolation => $”” 
            Console.WriteLine($"Name: {ob.Item1}, Age: {ob.Item2}, Address: {ob.Item3}");
            //b. Use Format ({0}) 
            Console.WriteLine("Name: {0}, Age: {1}, Address: {2}", ob.Item1, ob.Item2, ob.Item3);

            //4- Use Dictionary to keep the values of Information of 5 employees in question 2.
            //a.Use employeeId as the key and the office address as the value.
            String OFFICE_ADDRESS = "5555 Street";
            Dictionary<int, String> EmDict = new Dictionary<int, String>();
            empList.ForEach(emp => EmDict.Add(emp.empId, OFFICE_ADDRESS));
            

            //5- Create a Generic Class the only accepts class reference 
            GenericClass<Employee> GC = new GenericClass<Employee>();

            //6- Use Extension method for integer to check if the number is dividable by 3 
            int testNum = 9;
            Console.WriteLine(testNum.isDivBy3());


            Console.WriteLine(" ");
            //7- Write a method that has one string parameter. By Using predicate check if that string has vowel
            //sounds and print all the vowel sounds in the output. 
            Predicate<String> vowelSound = FindVowelSound;
            vowelSound("Test");

        }





        public delegate double findSal(List<Employee> el);






        public static bool FindVowelSound(String s)
        {
            String[] vowels = { "a", "e", "i", "o", "u" };
            bool b = false;
            foreach(String v in vowels)
            {
                if (s.Contains(v))
                {
                    Console.WriteLine(v);
                    b = true;
                }
            }

            return b;
        }



        static double findLowest(List<Employee> el)
        {
            double lowestSal = 0;
            el.ForEach(emp =>
            {
                if (emp.empSal < lowestSal || lowestSal == 0)
                {
                    lowestSal = emp.empSal;
                }

            });
            return lowestSal;
        }
        static double findHighest(List<Employee> el)
        {
            double highestSal = 0;
            el.ForEach(emp =>
            {
                if (emp.empSal > highestSal)
                {
                    highestSal = emp.empSal;
                }

            });
            return highestSal;
        }

    }

}

