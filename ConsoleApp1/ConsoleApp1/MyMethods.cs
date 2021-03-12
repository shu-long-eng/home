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
        
        public static void MoveFile()
        {
            do
            {
                do
                {
                    Console.Write("請輸入檔案來源路徑: ");   //判斷來源路徑是否存在
                                                             //如果否就執行迴圈
                    PathFrom = Console.ReadLine();           //如果存在就跳脫迴圈

                    if (File.Exists(PathFrom)) { break; }
                    Console.Write("檔案路徑不存在 ");
                    Console.Write("\n");
                    Console.Write("\n");

                } while (true);

                do
                {
                    Console.Write("請輸入檔案目標路徑: ");           //判斷目的路徑是否存在
                                                                     //如果是就執行迴圈
                    PathTo = Console.ReadLine();                    //如果不存在就跳脫迴圈



                    if (!Directory.Exists(Path.GetDirectoryName(PathTo)))
                    {
                        Console.WriteLine("路徑一部分不存在!");
                    }
                    else if (!File.Exists(PathTo)) { break; }
                    
                    else if (File.Exists(PathTo)){
                        Console.Write("檔案路徑已存在 ");
                        Console.Write("\n");
                    }

                } while (true);

                do
                {
                    Console.Write("請問是否進行移動(Y/N)");                     
                    string confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { break; }  //判斷Y or N
                                                                      //如果是 Y 跳脫迴圈                                                                  
                    if (confirm == "n" || confirm == "N")             //如果是 N 就關閉程式
                    {
                        if(count != 0) {
                            Console.WriteLine($"移動結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
                            Console.WriteLine($"移動了{count}個檔案。");
                            Console.WriteLine("請按任意鍵離開程式。");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        Console.WriteLine("取消移動。");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);
                
                 Console.WriteLine("");

                    sw.Start();  //設定開始時間

                    File.Move(PathFrom, PathTo);    //檔案由PathFrom到PathTo

                    sw.Stop();    //完成時間

                    count++;                        //次數增加
            
                


                do
                {
                    Console.Write("移動完成，請問是否繼續移動檔案(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { exit = false; break; }
                    if (confirm == "n" || confirm == "N") { exit = true; break; }
                } while (true);
                if (exit == true)
                {
                    break;
                }

            } while (true);
            Console.WriteLine($"移動結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
           
            Console.WriteLine($"移動了{count}個檔案。");
            
            Console.WriteLine("");
           
            Console.WriteLine("請按任意鍵離開程式。");
          
            Console.ReadKey();
           
            Environment.Exit(0);


        }
        

        
        public static void CopyFile() 
        {

           
            do
            {
                do
                {
                    Console.Write("請輸入檔案來源路徑: ");

                    PathFrom = Console.ReadLine();

                    if (File.Exists(PathFrom)) { break; }

                    Console.Write("檔案路徑不存在 ");
                    Console.Write("\n");
                    Console.Write("\n");

                } while (true);



                do
                {
                    Console.Write("請輸入檔案目標路徑: ");

                    PathTo = Console.ReadLine();
                    
                    if (!File.Exists(PathTo)) { break; }

                    Console.Write("檔案路徑已存在 ");
                   
                    Console.Write("\n");

                } while (true);

                
                do
                {
                    Console.Write("請問是否進行複製(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { break; }
                    if (confirm == "n" || confirm == "N")
                    {
                         if(count != 0) {
                            Console.WriteLine($"移動結束，總共花費{ sw.Elapsed.TotalMilliseconds}毫秒");
                            Console.WriteLine($"移動了{count}個檔案。");
                            Console.WriteLine("請按任意鍵離開程式。");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        Console.WriteLine("取消複製。");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);

                Console.WriteLine("");

                sw.Start();

                File.Copy(PathFrom, PathTo);

                sw.Stop();

                count++;
                
                do {
                    Console.Write("複製完成，請問是否繼續複製(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { exit = false; break; }
                    if (confirm == "n" || confirm == "N") { exit = true; break; }
                } while (true);

                if(exit == true)
                {
                    break;
                }
            
            } while (true);

            Console.WriteLine($"複製結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine($"複製了{count}個檔案。");
            Console.WriteLine("");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }
        
        
        
        public static void ReadFile()
        {
            
            do
            {
                do
                {
                    Console.Write("請輸入檔案來源路徑: ");

                    PathFrom = Console.ReadLine();

                    if (File.Exists(PathFrom)) { break; }

                    Console.Write("檔案路徑不存在 ");
                    Console.Write("\n");
                    Console.Write("\n");

                } while (true);

                do
                {
                    Console.Write("請問是否進行讀取(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { break; }
                    if (confirm == "n" || confirm == "N")
                    {
                        
                            if (count != 0)
                            {
                                Console.WriteLine($"讀取結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
                                Console.WriteLine($"移動了{count}個檔案。");
                                Console.WriteLine("請按任意鍵離開程式。");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        
                        Console.WriteLine("取消複製。");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                } while (true);

                sw.Start();

                string read = File.ReadAllText(PathFrom);

                sw.Stop();

                count++;

                Console.WriteLine("");
                Console.WriteLine("檔案內容為");
                Console.WriteLine("===================");
                Console.WriteLine(read);
                Console.WriteLine("===================");

                do
                {
                    Console.Write("讀取完成，請問是否繼續讀取(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { exit = false; break; }
                    if (confirm == "n" || confirm == "N") { exit = true; break; }
                } while (true);

                if (exit == true)
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"讀取結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine($"讀取了{count}個檔案。");
            Console.WriteLine("");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }
       

        
        public static void DeleteFile()
        {

            string str;

            string[] arr;

            string[] arr2;
          
            Console.WriteLine("請輸入欲刪除的檔案路徑(如有多個檔案請以空白為區隔):");

            str = Console.ReadLine();

            arr = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            arr2 = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (File.Exists(arr[i]))
                {
                    do
                    {
                        Console.Write($"請問是否刪除{arr[i]}路徑的檔案(Y/N)");
                        confirm = Console.ReadKey().Key.ToString();
                        Console.WriteLine("");
                        if (confirm == "y" || confirm == "Y") { exit = false; break; }
                        if (confirm == "n" || confirm == "N") { exit = true; break; }
                    } while (true);

                    if (exit == true) { continue; }
                }

                if (!File.Exists(arr[i]))
                {
                    do
                    {
                        Console.Write($"{arr[i]}路徑不存在，請問是否繼續刪除後續資料夾(Y/N)");
                        confirm = Console.ReadKey().Key.ToString();
                        Console.WriteLine("");
                        if (confirm == "y" || confirm == "Y") { exit = false; break; }
                        if (confirm == "n" || confirm == "N") { exit = true; break; }
                    } while (true);

                    if (exit == true)
                    {
                        Console.WriteLine($"總共刪除了{count}個檔案，花費{sw.Elapsed.TotalMilliseconds}毫秒");
                        Console.WriteLine("請按任意鍵離開程式。");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    if (exit == false) { continue; }
                }

                Console.WriteLine("");

                sw.Start(); //設定開始時間

                File.Delete(arr[i]);

                sw.Stop();    //完成時間

                count++;

            }

            Console.WriteLine($"總共刪除了{count}個檔案，花費{sw.Elapsed.TotalMilliseconds}毫秒");
        
        }
       

       
        public static void CreateFolder()
        {
            string name = "一個新的資料夾";

            do
            {
                do
                {
                    Console.Write("請輸入欲創建資料夾的路徑: ");
                    PathFrom = Console.ReadLine();
                    if (!Directory.Exists(PathFrom+name)) { break; }
                    Console.WriteLine("該路徑已經創建新的資料夾");
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

                Directory.CreateDirectory(PathFrom + name);

                sw.Stop();

                if (!Directory.Exists(PathFrom + name))
                {
                    Console.WriteLine("創建資料夾失敗。");
                    Console.WriteLine("請按任意鍵離開程式。");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                count++;

                do
                {
                    Console.Write("創建完成，請問是否繼續創建資料夾(Y/N)");
                    confirm = Console.ReadKey().Key.ToString();
                    Console.WriteLine("");
                    if (confirm == "y" || confirm == "Y") { exit = false; break; }
                    if (confirm == "n" || confirm == "N") { exit = true; break; }
                } while (true);

                if (exit == true)
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"創建結束，總共花費{sw.Elapsed.TotalMilliseconds}毫秒");
            Console.WriteLine($"創建了{count}個資料夾。");
            Console.WriteLine("");
            Console.WriteLine("請按任意鍵離開程式。");
            Console.ReadKey();
            Environment.Exit(0);

        }


        
        public static void DeleteFolder()
        {
            string path;
            string[] arr;
            

            Console.WriteLine("請輸入欲刪除的資料夾路徑:");

            path = Console.ReadLine();

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
