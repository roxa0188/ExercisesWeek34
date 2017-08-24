using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ExercisesWeek34
{
    class Program
    {
        private List<Thread> threadsList = new List<Thread>();
        private bool programRunning = true;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            IPAddress ip = IPAddress.Any;
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();

            while(programRunning)
            {
                TcpClient client = listener.AcceptTcpClient();
                //StreamReader sr = new StreamReader(client.GetStream());
                //StreamWriter sw = new StreamWriter(client.GetStream());


                //Ex1
                //string msg = sr.ReadLine();
                //sw.WriteLine(msg);
                //sw.Flush();


                //Ex2
                //ClientHandler clientHandler = new ClientHandler(client);
                //clientHandler.Echo();

                //Ex3
                ClientHandler clientHandler = new ClientHandler(client);
                Thread thread = new Thread(clientHandler.Echo);
                thread.Start();
                threadsList.Add(thread);

                //Ex
            }
        }
    }
}
