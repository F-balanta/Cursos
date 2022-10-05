using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSnippets
{



    public class Snippets
    {

        static public void BasicLinQ()
        {
            string[] cars =
            {
                "VW Golf",
                "VW California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat león"
            };

            // 1. Select * of cars
            var carsList = from car in cars select car;

            foreach (var car in carsList)
            {
                Console.WriteLine(car); ;
            }
            // 2. select  where car is Audi(SELECT AUDIs
            var audiList = from car in cars where car.Contains("Audi") select car;
            foreach (var audi in audiList)
            {
                Console.WriteLine(audi);
            }
        }

        //NumberExamples
        public static void LinqNumbers()
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Each numbre multiplied by 3
            //take all numbers, but 9
            // order number by ascending value

            var processedNumberList =
                numbers
                    .Select(num => num * 3) // {3, 6, 9 etc...}
                    .Where(num => num != 9) /// all but the 9
                    .OrderBy(num => num); // { at the end we order
        }

        public static void SearchExamples()
        {
            List<string> textList = new List<string> { "a", "bx", "c", "d", "e", "cj", "f", "c" };

            // 1. First of all elements
            var first = textList.First();

            //2. First element that is "c"
            var cText = textList.First(x => x.Equals("c"));
            //3. First element that contains "j"
            var jText = textList.First(x => x.Contains("j"));
            //4. First element that contains Z or default
            var firstOrDefault = textList.FirstOrDefault(t => t.Contains("z"));
            //5. Last element that contains Z or default
            var lastOrDefault = textList.LastOrDefault(t => t.Contains("z"));
            //6. Single values
            var uniqueText = textList.Single();
            var uniqueorDefaultsTexts = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otherNUmbers = { 0, 2, 6 };

            // Obtener {4,8}
            var myEvenNumber = evenNumbers.Except(otherNUmbers);
        }

        public static void MultipleSelects()
        {
            //Select Many
            string[] myOpinions =
            {
                "Opinion 1, text 1",
                "Opinion 2, text 2",
                "Opinion 3, text 3"
            };
            var myOpinionsSelection = myOpinions.SelectMany(opinion => opinion.Split(","));

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id  = 1,
                    Name = "Enterprise 1",
                    Employees = new []
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Martin",
                            Email ="martin@dasdasd.com",
                            Salary = 3000
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "pepe",
                            Email ="pepe@dasdasd.com",
                            Salary = 1000
                        },
                        new Employee
                        {
                            Id = 3,
                            Name = "Juancho",
                            Email ="juancho@dasdasd.com",
                            Salary = 2000
                        }
                    }

                },
                new Enterprise()
                {
                    Id  = 2,
                    Name = "Enterprise 1",
                    Employees = new []
                    {
                        new Employee
                        {
                            Id = 4,
                            Name = "Ana",
                            Email ="Ana@dasdasd.com",
                            Salary = 3000
                        },
                        new Employee
                        {
                            Id = 5,
                            Name = "Maria",
                            Email ="maria@dasdasd.com",
                            Salary = 1500
                        },
                        new Employee
                        {
                            Id = 6,
                            Name = "Martha",
                            Email ="martha@dasdasd.com",
                            Salary = 4000
                        }
                    }
                }
            };

            // Obtain all Employees of all enterprises
            var employeesList = enterprises.SelectMany(enterprise => enterprise.Employees);

            //Know if a list is empty
            bool hasEnterprises = enterprises.Any();
            bool hasEmployees = enterprises.Any(enterprise => enterprise.Employees.Any());

            //  AL enterprises at leats has an employees with more than 1000 of salary
            bool hasemployeeWithSalaryMoreThan1000 =
                enterprises.Any(enterprise =>
                        enterprise.Employees.Any(employee => employee.Salary >= 1000));
        }

        public static void linqCollections()
        {
            var firstList = new List<string>() { "a", "b", "c" };
            var secondtList = new List<string>() { "a", "c", "d" };

            // INNER JOIN
            var commonResult = from element in firstList
                               join secondElement in secondtList
                               on element equals secondElement
                               select new { element, secondElement };
            var commonResult2 = firstList.Join(
                    secondtList,
                    element => element,
                    secondElement => secondElement,
                    (element, seconElement) => new { element, seconElement }
                    );

            //OUTER JOIN - LEFT 
            var leftOuterJoin = from element in firstList
                                join secondElement in secondtList
                                on element equals secondElement
                                into temporalList
                                from temporalElement in temporalList.DefaultIfEmpty()
                                where element != temporalElement
                                select new { element = element };
            //OUTER JOIN RIGHT
            var rightOuterJoin = from secondElement in secondtList
                                 join element in firstList
                                 on secondElement equals element
                                 into temporalList
                                 from temporalElement in temporalList.DefaultIfEmpty()
                                 where secondElement != temporalElement
                                 select new { Element = secondElement };

            // Union

            //var unionList = leftOuterJoin.Union(rightOuterJoin);
        }

        public static void SkipTakeLinq()
        {
            var myList = new[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            // SKIP
            var skipTwofirstValues = myList.Skip(2);// {3,4,5,6,7,8,9,10}

            var skipLastTwoValues = myList.SkipLast(2);// { 1,2,3,4,5,6,7,8}

            var skipWhileSmallerThan4 = myList.SkipWhile(num => num < 4);// {5,6,7,8,9,10}
            //TAKE
            var takeFirstTwoValues = myList.Take(2);// {1,2}
            var takeLastTwoValues = myList.TakeLast(2); // {9,10}
            var takeWhileSmallerThan4 = myList.TakeWhile(num => num < 4); // {1,2,3
        }

        // Paging with Skip & Take
        public static IEnumerable<T> GetPage<T>(IEnumerable<T> collection, int pageNUmber, int resultsPage)
        {
            int sartIndex = (pageNUmber - 1) * resultsPage;
            return collection.Skip(sartIndex).Take(resultsPage);
        }

        // Variables
        public static void LinQVariables()
        {
            // Declarar variables dentro de las consultas
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var aboveAverage = from number in numbers
                               let average = numbers.Average()
                               let nSquared = Math.Pow(number, 2)
                               where nSquared > average
                               select number;
            foreach (var number in aboveAverage)
                Console.WriteLine("Average: {0} Square: {1}", number, Math.Pow(number, 2));

        }

        // Zip
        public static void ZipLinq()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] stringNumbers = { "one", "two", "three", "four", "five" };

            IEnumerable<string> zipNumbers = numbers.Zip(stringNumbers, (number, work) => number + "=" + work);

            // {"1=one", "2=two",   ...}
        }

        // Repeat & Range
        public static void repeatRangeLinq()
        {
            //Generate Collection from 1 = 1000 -------> Range
            var first1000 = Enumerable.Range(0, 1000);
            var above = from number in first1000
                        select number;
            // repeat a value N times
            var fiveXs = Enumerable.Repeat("X", 5);// Elemento que se quiere repetir tal cantidad de veces

        }

        public static void  student()
        {
            var classRoom = new[]
            {
                new Student
                {
                    Id = 1,
                    Name = "Martin",
                    Grade = 90,
                    Cerfified = true
                },            new Student
                {
                    Id = 2,
                    Name = "Martin",
                    Grade = 90,
                    Cerfified = true
                },
                new Student
                {
                    Id = 3,
                    Name = "Juan",
                    Grade = 50,
                    Cerfified = false
                },
                new Student
                {
                    Id = 3,
                    Name = "Ana",
                    Grade = 96,
                    Cerfified = true
                },
                new Student
                {
                    Id = 4,
                    Name = "Alvaro",
                    Grade = 10,
                    Cerfified = false
                },
                new Student
                {
                    Id = 5,
                    Name = "Pedro",
                    Grade = 50,
                    Cerfified = true
                }
            };

            var certifiedStudent = from student in classRoom
                                   where student.Cerfified
                                   select student;

            var notCertifiedStudent= from student in classRoom
                                     where student.Cerfified == false
                                     select student;

            var approvedStudentsNames = from student in classRoom
                                   where student.Grade >= 50 && student.Cerfified == true
                                   select student.Name;
        }

        // ALL
        public static void AllLinq()
        {
            var numbers = new List<int>() { 1,2,3,4,5 };

            bool allAreSmallerThan10 = numbers.All(x => x < 10);// true

            bool AllareBigOrEqualThan2 = numbers.All(x => x >= 2); // false

            var emptyList = new List<int>();
            bool allNUmbersAreGreaterThan0 = numbers.All(x => x >= 0); // true
        }

        // Aggregate
        public static void aggregateQueries()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Sum all numbers
            int sum = numbers.Aggregate((prevSum, current) => prevSum + current);
            /**
             * 0, 1 => 1
             * 1. 2 => 3
             * 3, 4 => 7
             * etc.
             */

            string[] words = { "hello,", "my", "name", "is", "martin" };
            string greeting = words.Aggregate((prevGreeting, current) => prevGreeting + current);
            /**
             * ",", "hello"=>hello,
             * "hello,", "my" => "hello my"
             * "hello,my", "name" =>"hellow, my name"
             * etc.
             */
        }

        // Disctinct
        public static void distinctValues()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 5, 4, 3, 2, 1 };

            IEnumerable<int> distinctValues = numbers.Distinct();
        }

        // GroupBy // Agrupacion por condicion
        public static void groupByExamples()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // valores pares - obtener numeros pares y generar 2 grupos
            var grouped = numbers.GroupBy(x => x % 2 == 0);
            foreach (var group in grouped)
            {
                foreach (var value in group)
                {
                    Console.WriteLine(value); // numeros impares  y luego los pares {1,3,5,7,9} {2,4,6,8 }
                }
            }
        }
    }
}