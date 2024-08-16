using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class fileSorter
    {
        public static void sortFile()
        {
            Console.WriteLine("Enter File Path including File name (.../text.txt):");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("File Content: ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Array.Sort(lines);

            Console.WriteLine("\nAfter Sorting File:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Random random = new Random();
            int randomNumber = random.Next();
            string dir = Path.GetDirectoryName(path);
            string ext = Path.GetExtension(path);
            var newPath = Path.Combine(dir, Path.GetRandomFileName() + ext);

            //FileStream fs = File.Create(newPath);
            File.WriteAllLines(newPath, lines);

            Console.WriteLine("New File created, Path: {0}\n", newPath);
        }
    }
}
