using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int itemsRows = Convert.ToInt32(Console.ReadLine().Trim());
            int itemsColumns = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<string>> items = new List<List<string>>();

            for (int i = 0; i < itemsRows; i++)
            {
                items.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
            }

            int sortParameter = Convert.ToInt32(Console.ReadLine().Trim());

            int sortOrder = Convert.ToInt32(Console.ReadLine().Trim());

            int itemsPerPage = Convert.ToInt32(Console.ReadLine().Trim());

            int pageNumber = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> result = new List<string>();
            result = result.FetchItemsToDisplay(items, sortParameter, sortOrder, itemsPerPage, pageNumber);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();

        }
        //   // The function is expected to return a STRING_ARRAY.
        //* The function accepts following parameters:
        //*  1. 2D_STRING_ARRAY items
        //*  2. INTEGER sortParameter - 0=name; 1=relevance; 2=price;
        //*  3. INTEGER sortOrder 0= asc; 1=desc;
        //*  4. INTEGER itemsPerPage
        //*  5. INTEGER pageNumber
        public static List<string> FetchItemsToDisplay(List<List<string>> items, int sortParameter, int sortOrder, int itemsPerPage, int pageNumber)
        {
            List<string> result = new List<string>();

            if (sortParameter == 0)
            {
                items = items.OrderBy(i => i.First()).ToList();
            }
            else if (sortParameter == 1)
            {
                items = items.OrderBy(i => i.Skip(1).First()).ToList();

            }
            else if (sortParameter == 2)
            {
                items = items.OrderBy(i => i.Skip(2).First()).ToList();
            }


            if (sortOrder == 0)
            {
                items = items.OrderBy(x => x).ToList();
            }
            else if (sortOrder == 1)
            {
                items.OrderByDescending(x => x).ToList(); ;
            }

            for (int i = 0; i < items.Count; i++)
            {
                string name = items[i][0];
                result.Add(name);
            }
            

            result = result.GetRange((itemsPerPage * pageNumber - 1), itemsPerPage);

            return result;
        }
    }
}

