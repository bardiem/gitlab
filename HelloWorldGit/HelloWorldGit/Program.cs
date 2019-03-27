using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldGit
{
    namespace HelloWorldGit
    {
        class Program
        {
            static void Main(string[] args)
            {
                FileStream file = new FileStream("file.txt", FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(file); 
                writer.WriteLine(DateTime.Now.ToString());
                StreamReader reader = new StreamReader(file);
                string lastLaunch = "";
                while (!reader.EndOfStream)
                {
                    lastLaunch = reader.ReadLine();
                }
                if (lastLaunch == "")
                    Console.WriteLine("Файл пустий");
                Console.WriteLine(lastLaunch);
                writer.Close();
                reader.Close();
                Console.ReadKey();
            }
        }
    }

}
