
using System.Numerics;
using System.Threading;
using Demo01.Data;
using static LINQ3.ListGenerator;
using static LINQ3.Order;
namespace LINQ3
    
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators
            //1
            //fluent syntax
            //var result = ProductList.Where(p => p.UnitsInStock == 0);

            //// query syntex
            //result = from p in ProductList
            //         where p.UnitsInStock == 0
            //         select p;
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}


            //2
            //var result1 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice>3);

            // foreach (var unit in result1)

            // {
            //     Console.WriteLine(unit);    
            // }
            //3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result03=Arr.Select((name, index) => new { Name = name, Value = index }).Where(p => p.Name.Length < p.Value).ToList();
            //foreach (var unit in result03)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion




            #region  LINQ - Element Operators
            //1
            //var result04 = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            ////2
            //var first = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            ////3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var retrive=Arr.Select(p=>p>5).First();
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region LINQ - Aggregate Operators
            ////1
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int odd= arr.Count(p => p % 2 != 0);
            ////2
            //var result = CustomerList.Select(p => new{ CustomerID = p.CustomerID, orders= p.Orders}).ToList();
            ////3
            //var result04=ProductList.Select(p => new{ ProductID = p.ProductID,    ProductName = p.ProductName }).ToList();    

            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);



            #endregion

            #region LINQ - Ordering Operators
            //1 
            //var result = ProductList.OrderBy(p => p.ProductName);

            ////2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var x=Arr.OrderBy(p=>p,) ????

            //3
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock > 0);

            ////4
            //string[] arr = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var x= arr.OrderBy(p => p.Length).ThenBy(p => p).ToList();

            //5
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = arr.OrderBy(p => p.Length).ThenBy(p => p).ToList();

            //6
            //var result=ProductList.OrderBy(p=>p.Category).ThenByDescending(p=>p.UnitPrice).ToList();

            //7
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = arr.OrderBy(p => p.Length).ThenByDescending(p =>p.ToLower()).ToList();

            //8
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(p => p.Length > 1 && p[1] == 'i').Reverse().ToList();

            #endregion

            #region LINQ – Transformation Operators
            //1
            //var result = ProductList.Select(p => p.ProductName).ToList();

            //2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //3
            //var result = ProductList.Select(p => new{p.ProductID, p.ProductName,Price = p.UnitPrice,p.UnitsInStock}).ToList();


            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Select((value,i) => new { value,i }).Where()   ???

            //5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var rsult = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { a, b };

         //6 
         //??
         ////7
         //??
            #endregion
        }
                }
}
