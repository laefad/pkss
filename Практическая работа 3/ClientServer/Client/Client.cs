using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{

    public class Client
    {

        private IPEndPoint remoteEndPoint;
        private Socket sender;

        public Client(int localPort)
        {
            try
            {
                sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList.First(a => a.AddressFamily == AddressFamily.InterNetwork);
                remoteEndPoint = new IPEndPoint(ipAddress, localPort);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
        }

        public void send(string enteredText)
        {
            byte[] msg = Encoding.Unicode.GetBytes(enteredText);
            int bytesSent = sender.Send(msg);
            // Console.WriteLine("Sent {0} bytes over the network", bytesSent);
        }

        public string getFromConsole(string helloMessage, bool newLine = false)
        {
            if (helloMessage != null)
            {
                if (newLine)
                {
                    Console.WriteLine(helloMessage);
                }
                else
                {
                    Console.Write(helloMessage);
                }
            }
            return Console.ReadLine() ?? "";
        }

        public string recieve()
        {
            byte[] bytes = new byte[1024];
            int bytesReceived = sender.Receive(bytes);
            return Encoding.Unicode.GetString(bytes, 0, bytesReceived);
        }

        public void run()
        {
            sender.Connect(remoteEndPoint);

            Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint);
            while (true)
            {
                var recievedText = recieve();
                Console.WriteLine(recievedText);

                var enteredText = getFromConsole("> ", false);
                send(enteredText);
            }

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        static int Main(string[] args)
        {
            var client = new Client(12312);
            client.run();
            return 0;
        }

    }

}