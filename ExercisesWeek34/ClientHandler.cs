using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ExercisesWeek34
{
    class ClientHandler
    {
        private StreamReader sr;
        private StreamWriter sw;
        private Socket clientSocket;
        private NetworkStream netStream;

        public ClientHandler(Socket client)
        {
            clientSocket = client;
            //Console.WriteLine("Created new client");
            //sr = new StreamReader(client.GetStream());
            //sw = new StreamWriter(client.GetStream());

            
        }

        //Ex3
        //public void Echo()
        //{
        //    Console.WriteLine("Started echo command");
        //    string msg = sr.ReadLine();
        //    sw.WriteLine(msg);
        //    sw.Flush();
        //}

        private void DoDialog()
        {

        }

        private void ExecuteCommand()
        {

        }

        private void ReceiveFromClient()
        {

        }

        private void SendToClient()
        {

        }
        public void RunClient()
        {

        }

     }
}
