﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

namespace BenchmarkSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BenchmarkSample
    {
        public List<int> globalList;
        public BenchmarkSample()
        {
            globalList = Enumerable.Repeat(1, 100).ToList();
        }

        [Benchmark]
        public void CheckListFor()
        {
            for (int i = 0; i < 100; i++)
            {
                var data = globalList[i];
            }
        }

        [Benchmark]
        public void CheckListForeEach()
        {
            foreach (var item in globalList)
            {
                var data = item;
            }
        }


        //[Benchmark]
        //public string ConcatString()
        //{


        //        //    str += i.ToString();
        //    //string str = string.Empty;
        //    //for (int i = 0; i < 1000; i++)
        //    //{
        //    //    str += i.ToString();
        //    //}
        //    //return str;
        //}

        //[Benchmark]
        //public string ConcatStringWithStringBuilder()
        //{
        //    StringBuilder stringBuilder = new();
        //    string str = string.Empty;
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        stringBuilder.Append(i.ToString());
        //    }
        //    str = stringBuilder.ToString();
        //    return str;
        //}
    }
}