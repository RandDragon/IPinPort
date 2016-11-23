using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MinimalisticTelnet;

namespace IPinPort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int countMac = 0;
            //List<String> listStr = new List<string>();
            //StreamWriter sw = new StreamWriter("log.txt");
            ////create a new telnet connection to hostname "gobelijn" on port "23"
            //TelnetConnection tc = new TelnetConnection("9sov-des2.vs.bcitelecom.ru", 23);

            ////login with user "root",password "rootpassword", using a timeout of 100ms, and show server output
            //string s = tc.Login("roman", "hme55cumo", 500);
            //Console.Write(s);

            //// server output should end with "$" or ">", otherwise the connection failed
            //string prompt = s.TrimEnd();
            //prompt = s.Substring(prompt.Length - 1, 1);
            //if (prompt != "#" && prompt != ">")
            //    throw new Exception("Connection failed");

            //prompt = "";

            //while (tc.IsConnected && prompt.Trim() != "logout")
            //{
            //    // display server output
            //    //Console.Write(tc.Read());
            //    String text = tc.Read();
            //    if (text.Length > 5)  listStr.Add(text);
            //    Console.Write(text);

            //    foreach (String str in listStr)
            //        {
            //            try
            //            {
            //                int i = str.IndexOf("Total Entries: 1");
            //                if (i > 0)
            //                {
            //                    char a = str[i + 15];
            //                    String b = "" + a;
            //                    countMac = int.Parse(b);
            //                }
            //            }
            //            catch { }
            //        }
            //    if (countMac == 1) tc.WriteLine("logout");


            //    // send client input to server
            //    prompt = Console.ReadLine();
            //    tc.WriteLine(prompt);


            //    // display server output
            //    text = tc.Read();
            //    if (text.Length > 5) listStr.Add(text);
            //    Console.Write(text);
            //    //Console.Write(tc.Read());

            //}

            //foreach (String str in listStr)
            //    sw.Write(str);
            //sw.Close();

            //Console.WriteLine("***DISCONNECTED");
            //foreach (String str in listStr)
            //{
            //    try
            //    {
            //        int i = str.IndexOf("Total Entries: ");
            //        if (i>0) Console.WriteLine(str[i+15]);
            //    }
            //    catch { }
            //}
            //Console.ReadLine();

            List<Client> ClientList = new List<Client>();
            StreamReader sr = new StreamReader("LoadBD.csv", Encoding.GetEncoding(1251));
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                try
                {

                    string[] str = sr.ReadLine().Split(';');

                    String[] port = str[1].Split('@');
                    int numport;

                    int.TryParse(port[0], out numport);
                    Client client = new Client(str[0], numport, str[2], port[1]);
                    ClientList.Add(client);

                }
                catch (Exception)
                { }

            }
            foreach (Client client in ClientList)
            {
                if (client.Port > 0) Console.WriteLine(client.ToString());
                if (client.Switch1 == "br13-des2.vs.bcitelecom.ru") Console.WriteLine(client.addACL());
            }

            Console.ReadLine();
        }
    }
}
