using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Text;
using HelloUserConsoleApp.Services;
using HelloUserLibrary;

namespace HelloUserConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //using (var pipe = new NamedPipeClientStream(".", "HelloPipe", PipeDirection.Out))
            //{
            //    pipe.Connect();
            //    using (var writer = new StreamWriter(pipe))
            //    {
            //        writer.WriteLine(name);
            //    }
            //}

            //-----
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Process.Start(@"C:\Users\VKAKHZH\source\repos\.NET Basics Program\HelloUserWpfApp\HelloUserWpfApp\bin\Debug\HelloUserWpfApp.exe", name);

            //-----
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //// Path to WpfApp.exe (adjust if needed)
            ////string wpfAppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HelloUserWpfApp.exe");
            //string relativePath = @"..\..\..\..\..\..\..\HelloUserWpfApp\bin\Debug\HelloUserWpfApp.exe";
            //string wpfAppFullPath = Path.GetFullPath(relativePath, AppDomain.CurrentDomain.BaseDirectory);

            //if (!File.Exists(wpfAppFullPath))
            //{
            //    Console.WriteLine($"WpfApp.exe not found at: {wpfAppFullPath}");
            //    return;
            //}

            //// Start WPF app with name as argument
            //Process.Start(wpfAppFullPath, name);

            var userName = args.Length > 0 ? string.Join(" ", args) : string.Empty;
            var greeterService = new GreeterService();
            greeterService.Greet(userName);
        }
    }
}
