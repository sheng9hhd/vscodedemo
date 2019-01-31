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

            // 分析得到的json数据,测试版本控制工具
            // 追加直播代码
            // 测试是否记住用户名和密码

            Console.WriteLine("Hello World!" + content);
        }
    }
}
