using System;
using System.Globalization;
using static System.Console;

namespace StringSerchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = "Good Morning, Good";

            /*
            WriteLine(g);

            //IndexOf()
            WriteLine($"Indexof 'Good' : {g.IndexOf("Good")}");
            WriteLine($"LastIndexof 'Good' : {g.LastIndexOf("Good")}");

            //StartWith
            WriteLine($"StartWith 'Good' : {g.StartsWith("Good")}");
            WriteLine($"StartWith 'Morning' : {g.StartsWith("Morning")}");

            //Contains()
            WriteLine($"Contains() 'Good' : {g.Contains("Good")}");
            WriteLine($"Contains() 'Morning' : {g.Contains("Morning")}");

            //Replace()
            WriteLine("Replace() 'Morning' to 'Evening' :" +
                $"{g.Replace("Morning","Evening")}");
            if(g.Contains("Good"))
            {
                WriteLine(g.Replace("Good", "Bad"));
            }

            WriteLine($"ToLower : {g.ToLower()}");
            WriteLine($"ToUpper : {g.ToUpper()}");
            WriteLine($"Insert : {g.Insert(g.IndexOf("Morning"),"Very ")}");
            WriteLine("Remove : '{0}'","I Don`t Love You.".Remove(2,6));
            WriteLine("Trim : '{0}'"," No Spaces ".Trim());
            WriteLine("Trim : '{0}'", " No Spaces ".TrimStart());
            WriteLine("Trim : '{0}'", " No Spaces ".TrimEnd());
            */
            /*
            string codes = "MSFT,GOOG,AMZN,AAPL, RHT";
            var result = codes.Split(',');
            foreach (var item in result)
            {
                WriteLine($"each item '{item.Trim()}'");
            }
            WriteLine($"substring : {g.Substring(0,4)}");
            WriteLine($"substring : '{g.Substring(4)}'");
            */

            //WriteLine(string.Format("{0}DEF", "ABC"));
            //WriteLine(string.Format("{0,-10}DEF", "ABC"));
            //WriteLine(string.Format("{0,10}DEF", "ABC"));

            DateTime dt = DateTime.Now;
            /*
            WriteLine(dt);
            WriteLine(string.Format($"{dt:yyyy-MM-dd HH:mm:ss}"));
            WriteLine(string.Format($"{dt:d/M/yyyy HH:mm:ss}"));
            WriteLine(string.Format($"{dt:y yy yyy yyyy}"));
            WriteLine(string.Format($"{dt:M MM MMM MMMM}"));
            */
            WriteLine(dt.ToString("yyyy - MM - dd HH:mm:ss", new CultureInfo("ko-KR")));
            WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));

            decimal mval = 27000000;
            WriteLine(mval.ToString("c"));
            WriteLine(mval.ToString("c",new CultureInfo("en-US")));
            WriteLine(mval.ToString("c", new CultureInfo("fr-FR")));
            WriteLine(mval.ToString("c", new CultureInfo("ja-JP")));
            WriteLine(mval.ToString("c", new CultureInfo("ko-KR")));

        }
    }
}
