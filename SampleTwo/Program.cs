using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTwo
{
    internal class Program
    {
        //public static double averageRankMovie(List<double> lists)
        //{
        //    double avrerage = lists.Average();
        //    return avrerage;
        //}

        //public static double MaxMovies(List<double> lists)
        //{
        //    double Max = double.MaxValue;
        //    for (int i = 0; i < lists.Count; i++)
        //    {
        //        Max = lists.Max();
        //    }
        //    return Max; 
        //}


        static Random rnd = new Random();
        public static string convertCharToString(char charStart, char charEnd, int len)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                char index = (char)rnd.Next((int)charStart, (int)charEnd);
                sb.Append(index);
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            for (int i = 1; i < 20; )
            {
                string newString = convertCharToString('a', 'c', 3);
                if (stringList.IndexOf(newString) != -1)
                    continue;
                stringList.Add(newString);
                i++;

            }
            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }











        //string[] moviesCollection = { "Fakt Mahilao Maate", "Laung Laachi 2", "Dobaaraa", "Karthikeya 2", "Thallumaala", "Gaalipata 2" };
        //List<double> rankMovieList = new List<double>();
        //for (int i = 0; i < moviesCollection.Length; i++)
        //{
        //    string item = moviesCollection[i];
        //    Console.WriteLine($"Please enter a rank movie {item}:");
        //    double rankMovie = Convert.ToDouble(Console.ReadLine());
        //    rankMovieList.Add(rankMovie);
        //}

        //Console.WriteLine($"average is:{ averageRankMovie(rankMovieList)}");
        //Console.WriteLine(MaxMovies(rankMovieList)); 
        //Console.ReadKey();
    }


}
