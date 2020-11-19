using FluentFTP;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace HttpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://postman-echo.com/get?foo1=bar1&foo2=bar2
            //var getRequest = WebRequest.Create("https://postman-echo.com/get?foo1=bar1&foo2=bar2");
            //getRequest.Method = "GET";
            ////getRequest.Headers.Add(...)

            //var getResponse = getRequest.GetResponse() as HttpWebResponse;

            //using (var stream = new StreamReader(getResponse.GetResponseStream()))
            //{
            //    //var stringBuilder = new StringBuilder();

            //    ////do
            //    ////{
            //    //    var buffer = new byte[256];
            //    //    stream.Read(buffer, 0, buffer.Length);

            //    //    stringBuilder.Append(Encoding.UTF8.GetString(buffer));
            //    //} while (stream.DataAvailable);

            //    //Console.WriteLine(stringBuilder.ToString());
            //    Console.WriteLine(stream.ReadToEnd());
            //}
            //getResponse.Close();


            var client = new FtpClient("ftp://ftp.dlptest.com/", new NetworkCredential("dlpuser@dlptest.com", "eUj8GeW55SvYaswqUyDSm5v6N"));

            client.Connect();

            foreach(var item in client.GetListing())
            {
                Console.WriteLine(item.FullName);
            }

            client.Disconnect();


            //var ftpRequest = FtpWebRequest.Create("ftp://ftp.dlptest.com/PWD");
            //ftpRequest.Credentials = new NetworkCredential("dlpuser@dlptest.com", "eUj8GeW55SvYaswqUyDSm5v6N");
            //var response = ftpRequest.GetResponse();

            //using (var stream = new StreamReader(response.GetResponseStream()))
            //{
            //    Console.WriteLine(stream.ReadToEnd());
            //}

            //response.Close();
        }
    }
}
