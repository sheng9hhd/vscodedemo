using System;
using RestSharp;

namespace vscode_works
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://forum.qidian.com");
            var request = new RestRequest("/index/8817709703599303", Method.GET);
            var response = client.Execute(request);
            var content = response.Content;

            // 分析得到的json数据

            Console.WriteLine("Hello World!" + content);
        }
    }
}
