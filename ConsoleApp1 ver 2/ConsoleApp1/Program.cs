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
           
                

                if (string.Compare(args[0], "MoveFile", true) == 0)
                {
                    MyMethods.MoveFile(args);
                }
                else if (string.Compare(args[0], "CopyFile", true) == 0)
                {
                    MyMethods.CopyFile(args);
                }
                else if (string.Compare(args[0], "ReadFile", true) == 0)
                {
                    MyMethods.ReadFile(args);
                }
                else if (string.Compare(args[0], "DeleteFile", true) == 0)
                {
                    MyMethods.DeleteFile(args);
                }
                else if (string.Compare(args[0], "CreateFolder", true) == 0)
                {
                    MyMethods.CreateFolder(args);
                }
                else if (string.Compare(args[0], "DeleteFolder", true) == 0)
                {
                    MyMethods.DeleteFolder(args);
                }
                else
                {
                    Console.WriteLine("無效動作");
                }
           

            Console.Read();
        }
    }
}
