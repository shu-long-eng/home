using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("程式啟動!!");
            Console.WriteLine("請按任意鍵繼續");
            Console.ReadKey(true);
            do
            {
                Console.WriteLine("請輸入需要進行的動作: ");
                string str = Console.ReadLine();

                if (string.Compare(str, "MoveFile", true) == 0)
                {
                    MyMethods.MoveFile();
                }
                else if (string.Compare(str, "CopyFile", true) == 0)
                {
                    MyMethods.CopyFile();
                }
                else if (string.Compare(str, "ReadFile", true) == 0)
                {
                    MyMethods.ReadFile();
                }
                else if (string.Compare(str, "DeleteFile", true) == 0)
                {
                    MyMethods.DeleteFile();
                }
                else if (string.Compare(str, "CreateFolder", true) == 0)
                {
                    MyMethods.CreateFolder();
                }
                else if (string.Compare(str, "DeleteFolder", true) == 0)
                {
                    MyMethods.DeleteFolder();
                }
                else
                {
                    Console.WriteLine("無效動作");
                }
            } while (true);

            Console.Read();
        }
    }
}
