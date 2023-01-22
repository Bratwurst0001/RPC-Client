using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RPC_Client
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Test Client");
			TcpClient client = new TcpClient();
			try
			{
				client.Connect(IPAddress.Parse("127.0.0.1"), 8090);

				using (StreamReader reader = new StreamReader(client.GetStream()))
				{
					String ReciveData = reader.ReadLine();
					// MessageBox.Show("Fetched: " + ReciveData);
					
						Console.WriteLine("Recived: " + ReciveData);


					
					
				}
				Console.WriteLine("Get Data done!");
			}
			catch (Exception e)
			{
				//Client.Connect(IPAddress.Parse("45.142.115.67"), 8090);
				//goto Connecting;
				Console.WriteLine("Failed!" + e.Message);
			}
		}
		public void sendsock()
		{
			Thread.Sleep(4000);
			TcpClient client = new TcpClient();
			client.Connect(IPAddress.Parse("45.142.115.67"), 8090);
			client.GetStream().Write(Encoding.UTF8.GetBytes("test"));
			client.Close();
		}
		}
	}

