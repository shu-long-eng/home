using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Collections; //使用ArrayList
using System.Diagnostics;

namespace ConsoleApp1
{
    class MyMethods
    {
        
        static Stopwatch sw = new Stopwatch();//計算時間
        static int count = 0;//計算程式跑了幾次
        static string PathTo;//目的地路徑
        static string PathFrom;//目標路徑
        static string confirm;//Y  or  N
        static bool exit;//是否離開
        
        public static void MoveFile(string [] arr)
        {



            if (!File.Exists(arr[1]))
            {
                Console.Write("檔案路徑不存在，無法移動 ");
                Console.WriteLine("");
                Console.WriteLine("請按任意鍵離開程式。");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (File.Exists(arr[2]))
            {
                Console.Write("檔案路徑已存在，無法移動 ");
                Console.WriteLine("");
                Console.WriteLine("請按任意鍵離開程式。");
                Console.ReadKey();
                Environment.Exit(0);
            }

                do
                {
                    Console.Write("請問是否進行移動(Y/N)");                     
                    string confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { break; }  //判斷Y or N
                                                                      //如果是 Y 跳脫迴圈                                                                  
                    if (confirm == "n" || confirm == "N")             //如果是 N 就關閉程式
                    {
                        
                        Console.WriteLine("取消移動。");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);

                Console.WriteLine("");

                sw.Start();  //設定開始時間

                File.Move(arr[1], arr[2]);    //檔案由PathFrom到PathTo

                sw.Stop();    //完成時間
       
            Console.WriteLine($"移動結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒"); 
            
            Console.WriteLine("");
           
            Console.WriteLine("請按任意鍵離開程式。");
          
            Console.ReadKey();
           
            Environment.Exit(0);

        }
        

        
        public static void CopyFile(string [] arr) 
        {

            PathFrom = arr[1];

            if (!File.Exists(PathFrom))
            {

                Console.Write("檔案路徑不存在 ");
                Console.Write("\n");
                Console.WriteLine("請按任意鍵離開程式。");
                Console.ReadKey();
                Environment.Exit(0);

            }

            PathTo = arr[2];

            if (File.Exists(PathTo))
            {

                Console.Write("檔案路徑已存在 ");

                Console.Write("\n");

                Console.WriteLine("請按任意鍵離開程式。");
                Console.ReadKey();
                Environment.Exit(0);

            }


                
                do
                {
                    Console.Write("請問是否進行複製(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { break; }
                    if (confirm == "n" || confirm == "N")
                    {
                         
                        Console.WriteLine("取消複製。");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);

                Console.WriteLine("");

                sw.Start();

                File.Copy(arr[1], arr[2]);

                sw.Stop();
                
               

            Console.WriteLine($"複製結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine("");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }



        public static void ReadFile(string[] arr)
        {

     




            if (!File.Exists(arr[1]))
            {

                Console.Write("檔案路徑不存在 ");
                Console.Write("\n");
                Console.WriteLine("請按任意鍵離開程式。");
                Console.ReadKey();
                Environment.Exit(0);

            }

            do
            {
                Console.Write("請問是否進行讀取(Y/N)");
                confirm = Console.ReadKey().Key.ToString();
                Console.WriteLine("");
                if (confirm == "y" || confirm == "Y") { break; }
                if (confirm == "n" || confirm == "N")
                {

                    Console.WriteLine("取消複製。");
                    Console.WriteLine("請按任意鍵離開程式。");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            } while (true);

                sw.Start();

                string read = File.ReadAllText(arr[1]);

                sw.Stop();

                Console.WriteLine("");
                Console.WriteLine("檔案內容為");
                Console.WriteLine("===================");
                Console.WriteLine(read);
                Console.WriteLine("===================");


            Console.WriteLine($"讀取結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine("");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }
       

        
        public static void DeleteFile(string[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                if (File.Exists(arr[i]))
                {
                    do
                    {
                        Console.Write($"請問是否刪除{arr[i]}檔案(Y/N)");
                        confirm = Console.ReadKey().Key.ToString();
                        Console.WriteLine("");
                        if (confirm == "y" || confirm == "Y") { exit = true; break; }

                        if (confirm == "n" || confirm == "N") { exit = false; break; }
                     
                    } while (true);

                    if(exit == false) { continue; }

                    sw.Start();

                    File.Delete(arr[i]);

                    sw.Stop();

                    count++;

                }
                else
                {
                    Console.Write($"{arr[i]}不存在，跳過此檔案");
                    Console.WriteLine("請按任意鍵繼續。");
                    Console.ReadKey();
                }

            }
            Console.WriteLine($"總共刪除了{count}個檔案，花費{sw.Elapsed.TotalMilliseconds}毫秒");
        
        }
       

       
        public static void CreateFolder(string [] arr)
        {
            string name = "一個新的資料夾";

            
                do
                {
                    if (!Directory.Exists(arr[1]+name)) { break; }
                    Console.WriteLine("該路徑已有相同名稱的資料夾");
                    Console.WriteLine("");
                } while (true);

                do
                {
                    Console.Write("是否進行創建(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { break; }
                    if (confirm == "n" || confirm == "N")
                    {
                        Console.WriteLine("取消創建資料夾。");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);

                sw.Start();

                Directory.CreateDirectory(arr[1] + name);

                sw.Stop();

                if (!Directory.Exists(arr[1] + name))
                {
                    Console.WriteLine("創建資料夾失敗。");
                    Console.WriteLine("請按任意鍵離開程式。");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            Console.WriteLine($"創建結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine("");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }


        
        public static void DeleteFolder(string [] arr)
        {





            string path = arr[1];

            DirectoryInfo fileInfo = new DirectoryInfo(path);

            arr = Directory.GetFiles(path); //陣列存放資料夾內檔案名稱

            if (arr.Length == 0)
            {
                do
                {
                    Console.WriteLine($"請問是否刪除{path}路徑資料夾(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y")
                    {
                        sw.Start();

                        Directory.Delete(path);

                        sw.Stop();

                        Console.WriteLine($"資料夾已刪除，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");

                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);

                    }
                    if (confirm == "n" || confirm == "N")
                    {
                        Console.WriteLine("取消刪除");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);
            }
            do
            {
                Console.WriteLine($"請問是否刪除{path}路徑資料夾及資料夾內所有檔案(Y/N)");
                confirm = Console.ReadKey().Key.ToString();
                Console.WriteLine("");
                if (confirm == "y" || confirm == "Y") { break; }
                if (confirm == "n" || confirm == "N")
                {
                    Console.WriteLine("取消刪除");
                    Console.WriteLine("請按任意鍵離開程式。");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            } while (true);

            sw.Start();

            foreach (string item in arr)
            {
                File.SetAttributes(item, FileAttributes.Normal);
                File.Delete(item);
            }

            Directory.Delete(path);

            sw.Stop();

            Console.WriteLine($"刪除完成，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }
        
    }
}
