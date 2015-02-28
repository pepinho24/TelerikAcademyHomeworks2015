/*Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image (http://telerikacademy.com/Content/Images/news-img01.png)) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.*/
namespace _04.DownloadFile
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Threading;

    public class DownloadFile
    {
        static string fullpath = string.Empty;

        static void Main()
        {
            while (true)
            {
                try
                {
                    //user input
                    Console.Write("Enter URL Path to download image: ");
                    string path = Console.ReadLine();

                    Console.Write("Enter Filename: ");
                    string filename = Console.ReadLine();

                    //create WebClient
                    WebClient wc = new WebClient();

                    //set default path 
                    string savePath = Environment.CurrentDirectory;
                    string extentionOfImage = GetExtentionFromURL(path);
                    fullpath = savePath + @"\" + filename + extentionOfImage;

                    //start Webclient Async Download + event handlers
                    wc.DownloadFileAsync(new Uri(path), filename + extentionOfImage);
                    wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;

                    //block the main thread with Console.ReadLine()
                    string answer = Console.ReadLine();

                    //open the file?
                    if (answer == "y")
                        Process.Start(fullpath);

                    Console.WriteLine("Bye");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was something wrong with your image {0}", ex.Message);
                }
            }
        }

        private static string GetExtentionFromURL(string path)
        {
            return Path.GetExtension(path);
        }

        static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //every time new bytes are received this method is triggered
            double percentage = e.ProgressPercentage;
            Console.Write("{0} bytes / {1} bytes : ", e.BytesReceived, e.TotalBytesToReceive);
            Console.WriteLine("{0} %", percentage);
            Thread.Sleep(50);
        }

        static void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //triggered when the download is complete
            Console.Write("Your file has been downloaded to {0}, do you want to open it now? (y/n): ", fullpath);
        }
    }
}
