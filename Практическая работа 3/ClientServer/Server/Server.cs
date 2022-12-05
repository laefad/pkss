using Server.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class Server
    {
        private IPEndPoint localEndPoint;
        private Socket listener;
        private Socket handler;

        public Server(int localPort)
        {
            try
            {
                listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList.First(a => a.AddressFamily == AddressFamily.InterNetwork);
                localEndPoint = new IPEndPoint(ipAddress, localPort);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
        }

        public void send(string enteredText, bool withRecieve =  false)
        {
            if (withRecieve)
            {
                enteredText += (withRecieve ? "\n Введите что угодно, чтобы продолжить" : "");
            }

            byte[] msg = Encoding.Unicode.GetBytes(enteredText);
            int bytesSent = handler.Send(msg);

            if (withRecieve)
            {
                recieve();
            }
        }

        public string recieve()
        {
            byte[] bytes = new byte[1024];
            int bytesReceived = handler.Receive(bytes);
            return Encoding.Unicode.GetString(bytes, 0, bytesReceived);
        }

        public int recieveInt()
        {
            var data = recieve();
            return int.Parse(data);
        }

        public double recieveDouble()
        {
            var data = recieve();
            return double.Parse(data);
        }

        public void run()
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);
            while (true)
            {
                handler = listener.Accept();
                Console.WriteLine("Client connected");
                while (handler.Connected)
                {
                    try
                    {
                        trashMethod();
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        send("Произошла ошибка", true);
                    }
                }
            }
        }

        public void trashMethod() 
        {
            send("Выберите номер задачи [7, 10, 13, 16, 19]");
            var numberOfTask = recieveInt();

            switch (numberOfTask)
            {
                case 7:
                    {
                        send("Введите число(double): ");
                        var x = recieveDouble();
                        send("Результат  = " + Task7.calculate(x), true);
                        break;
                    }
                case 10:
                    {
                        send("Введите число(int): ");
                        var x = recieveInt();
                        send("Результат  = " + Task10.getNearestNumber(x), true);
                        break;
                    }
                case 13:
                    {
                        send("Введите число(int): ");
                        var x = recieveInt();
                        send("Результат  = " + (Task13.isThreePow(x) ? "Да" : "Нет"), true);
                        break;
                    }
                case 16: 
                    {
                        send("Результат  = " + string.Join(",", Task16.values()), true);
                        break;
                    }
                case 19:
                    {
                        send("Результат  = " + Task19.firstNegative(), true);
                        break;
                    }
                default:
                    {
                        send("Такой задачи нет!!!", true);
                        break;
                    }
            }
        }

        static int Main(string[] args)
        {
            var server = new Server(12312);
            server.run();
            return 0;
        }
    }
}
