using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {

           

            string str= "assdfasfsdafsaGS";
            //1
            var countofs = str.Count(x => (x.ToString() == "s"));
            //2
            //string[] strarr = { "Aas", "Cas", "Zas", "asdfasf","AAAgg","BBBffffd" };
            string[] strarr = { "Aas", "Cas", "Zas" };
            var orderbylastchar = strarr.OrderByDescending(x => x.Length - 1).ToList();

            //3
            var orderbylength = strarr.OrderBy(x => x.Length).ToList();

            //4
            int num = strarr.Max(x => x.Length);
            //var longest = strarr.Single(x => x.Length == num).ToString();

            //5
            int num1 = strarr.Min(x => x.Length);
            //var shortest = strarr.SingleOrDefault(x => x.Length == num1).ToList();
            //var shortest = strarr.Where(x => x.Length == num1).ToList();

            //6
            var twices = counts(strarr);
            // var twices  = strarr.Where(x => x.ToArray().Where(i => i == 's' || i == 'S').Count() >= 2).ToArray();


            //7 
            var lastletterr = strarr.Where(x => x[x.Length - 1] == 'r').ToArray();


            //8
            var morethan5char = strarr.Where(x => x.Length > 5).ToList();

            //9
            var varstartsandm = strarr.Where(x => x[0] == 's' && x[x.Length - 1] == 'm').ToList();

            //10
            var alluppercase = strarr.Where(x => x.All(char.IsUpper)).ToList();

            List<Person> list = new List<Person>();
            list = GetPerson();
            //11 //a
            var age30to60 = list.Where(x => x.Age > 30 && x.Age < 60).ToList();

            //11 //b
            var nameinEmail = list.Where(x => x.Email.Contains(x.Name)).ToList();


            //11 //c
            var emailEndcoil = list.Where(x => x.Email.EndsWith("co.il")).ToList();

            //11 //d
            var oldestAge = list.Max(x => x.Age).ToString();
            var details = list.Where(x => x.Age == int.Parse(oldestAge)).ToList();


            //11 h
            var nameLengthGreater4 = list.Where(x => x.Name.Length > 4).ToList();


            //11 v
            var emailNotContainAt = list.Where(x => !(x.Email.Contains("@"))).ToList();


            //part 2 ex 5
            var groupbylength = strarr.GroupBy(x => x.Length).ToList();


            //part 2 ex 6
            var groupbyevenodd = strarr.GroupBy(x => x.Length%2==0).ToList();

            //part 2 ex 7
            var groupbyidentiarr = strarr.Distinct().ToList();

            //part 2 ex 8
            var is_first_char_capital = strarr.All(x => char.IsUpper(x[0]));


            //part 2 ex 9
            var is_one_even = strarr.Any(x => x.Count() % 2 == 0);

            //part 2 ex 10
            var sum_all_length = strarr.Sum(x => x.Count()).ToString();

            //part 2 ex 11
            var all1Ascii = AsciiArr(strarr);

            //part 2 ex 12
            //string tz = "543535435";
            //int numtz = 0;
            //int.TryParse(tz, out numtz);
            //bool istzvalid = tz.Where(x =>
            //{ return x.Length == 9 && x.ID[x.ID.Length - 1] == '1' && int.TryParse(x.ID, out temp); });

            Person p = new Person();
            int temp = 0;
            List<Person> listt = GetPerson();
            List<Person> filtered = listt.Where(x =>
              x.ID.Length != 9 && x.ID[x.ID.Length - 1] != '1' && int.TryParse(x.ID, out temp)).ToList();



            //Basic Linq
            //1
            int[] numbers = { 21341324, 47567, 23, 867876, 978987,33 };
            var numbers3 = numbers.OrderByDescending(x => x % 3 == 0).ThenByDescending(p=>p> 30).ToArray();

            var numbers33 = numbers.OrderByDescending(x => x % 3 == 0 && x > 30).Where( a=>a % 3 == 0).ToArray();

            //query expression
            var itemList = from x in numbers
                           where x % 3 == 0 && x > 30
                           orderby x % 3 == 0 && x > 30 descending
                           select x;


            //query expression
            int[] vals = { -2, 4, 6, -1, 2, 0, 1, -3, -4, 2, 3, 8 };

            var pos =
                from val in vals
                where val > 0
                select val;

          //  Console.WriteLine(string.Join(" ", pos));

            //query expression
            var evens =
                from val in vals
                where val % 2 == 0
                select val;

           // Console.WriteLine(string.Join(" ", evens));

            //Basic Linq
            //2
            string[] str_arr = { "Aas", "Cas", "Zas", "asdfasf", "AAAgg", "BBBffffd" };
            int maxlength = str_arr.Max(x => x.Length);
            var longestitem = str_arr.SingleOrDefault(x => x.Length == maxlength);


            string[] names = { "Avi", "David", "Moti", "Aaron", "Jimmy", "Homer",
"Momi", "Ibrahim" };


            var listnames = names.OrderBy(x => x).ToArray();

            for (int i = 0; i < listnames.Length; i++)
            {
                Console.WriteLine("Names that begin with "+ listnames[i][0] +": "+ listnames[i]);
            }

            //Linq to Collections
            //1
            List<Product> listOfProduct = GetProducts();
            var Dairy = listOfProduct.Where(x => x.Categoryf == Category.Dairy).ToList();


            //2
            var Allproducts5 = listOfProduct.Where(x => x.Price > 5).ToList();


            //3
            var All3Max = listOfProduct.OrderByDescending(x => x.Price).Take(3).ToList();


            //4
            var allCatSmall10 = listOfProduct.Where(x => x.Price < 10);
            foreach (var item in allCatSmall10)
            {
                Console.WriteLine(item.Categoryf);
            }
            Console.WriteLine();
        }


        static List<Person> GetPerson()
        {
            List<Person> list = new List<Person>()
            {
              new Person {Age = 12, Name = "David", Email = "David@gmail.com",ID="232523491"},
              new Person {Age = 23, Name = "Naama", Email = "Naama@gmail.com",ID="2345234"},
              new Person {Age = 33, Name = "Ron", Email = "Roni@gmail.com",ID="2345234"},
               new Person {Age = 42, Name = "Dr", Email = "Drorgmail.co.il",ID="2345234"},
                new Person {Age = 18, Name = "Keren", Email = "Keren@gmail.com",ID="2345234"},
            };
            return list;
        }
        public delegate bool dodelegate<T>(T p);
        static List<T> filter<T>(List<T> list, dodelegate<T> func)
        {
            List<T> Ilist = new List<T>();
            foreach (var item in list)
            {
                if (func(item))
                {
                    Ilist.Add(item);
                }
            }
            return Ilist;
        }

        static List<string> counts(string [] str)
        {
            List<string> newstr = new List<string>();
            int num = 0;
            string se = "";
            for (int i = 0; i < str.Length; i++)
            {
                se = str[i];
                for (int j = 0; j < se.Length; j++)
                {
                    if (se[j].ToString() == "s")
                    {
                        num ++;
                    }

                }
                if (num > 2)
                {
                    newstr.Add(str[i]);
                }
            }
            return newstr;
        }


        static List<int> AsciiArr(string[] str)
        {
            List<int> newstr = new List<int>();
            int sum = 0;
            string se = "";
            for (int i = 0; i < str.Length; i++)
            {
                sum = 0;
                se = str[i];
                for (int j = 0; j < se.Length; j++)
                {
                    char c = se[j];
                    sum += (int)c;
                }
                newstr.Add(sum);
            }
            return newstr;
        }

        static List<Product> GetProducts()
        {
            List<Product> list = new List<Product>()
            {
                 new Product  { Price=12,Name="Bisli",Categoryf=Category.Sweets},
                 new Product  { Price=14,Name="Bamba",Categoryf=Category.Meat},
                 new Product  { Price=30,Name="Kefli",Categoryf=Category.Fruits},
                 new Product  { Price=5,Name="Chitos",Categoryf=Category.Dairy},
                 new Product  { Price=7,Name="Kabukim",Categoryf=Category.Sweets}

            };



                
           

            return list;
        }

    }
}
