using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheMeaningOfLife
{
    class Program
    {
        static List<EventWaitHandle> threadFinishEvents = new List<EventWaitHandle>();
        static Dictionary<String, int> amountPerFile = new Dictionary<String, int>();

        static void Main(string[] args)
        {
            startNewThread(args);
            
            Mutex.WaitAll(threadFinishEvents.ToArray());

            print(amountPerFile);

            Console.Read();
        }

        static void exe(object argsObject)
        {
            string[] args = (string[])argsObject;
            String fullPath = Path.GetFullPath(args[0]);
            FileAttributes attr = File.GetAttributes(fullPath);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                String[] files = Directory.GetFiles(fullPath, "*", SearchOption.AllDirectories);
                foreach (String file in files)
                {
                    args[0] = file;
                    startNewThread(args);
                }
            }
            else
            {
                //if (!amountPerFile.ContainsKey(fullPath))
                //{
                //    amountPerFile.Add(fullPath, 0);
                //}
                //string[] lines = System.IO.File.ReadAllLines(fullPath);

                //foreach (String line in lines)
                //{
                //    string[] words = line.Split(' ');
                //    foreach (String word in words)
                //    {
                //        if (word.Contains("42"))
                //        {
                //            int amount = 0;
                //            amountPerFile.TryGetValue(fullPath, out amount);

                //            amountPerFile[fullPath] = amount + 1;
                //        }

                //    }
                //}

                int count = 0;
                byte[] bytes = File.ReadAllBytes(fullPath);
                foreach (byte b in bytes)
                {
                    Console.Write(b + " ");
                    if (b == 42)
                        count++;
                }
                Console.WriteLine("\nAmount of bytes with value 42: " + count);
            }
        }

        private static void print(Dictionary<string, int> amountPerFile)
        {
            foreach (String key in amountPerFile.Keys)
            {
                Console.WriteLine(key + ": " + amountPerFile[key]);
            }
        }

        private static void startNewThread(string[] args)
        {
            var threadFinish = new EventWaitHandle(false, EventResetMode.ManualReset);
            threadFinishEvents.Add(threadFinish);

            var localArgs = args.Clone();

            Thread t = new Thread(delegate()
                {
                    exe(localArgs);
                    threadFinish.Set();
                });

            t.Start();


        }
    }
}