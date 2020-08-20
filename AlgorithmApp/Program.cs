using System;

namespace Algorithm.App
{
    /// <summary>
    /// 本项目主要用于记录基础算法的研究与学习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************客户端程序调用开始****************************");
            try
            {
                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"程序出错:{ex.Message}");
            }
            Console.WriteLine("***************************客户端程序调用完成****************************");
            Console.ReadKey();
        }
    }
}
