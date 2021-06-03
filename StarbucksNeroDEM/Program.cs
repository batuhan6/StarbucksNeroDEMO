using NeroStarbucks;
using NeroStarbucks.Abstract;
using NeroStarbucks.Concrete;
using StarbucksNeroDemo.Adapters;
using System;
namespace StarbucksNeroDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { dateYear = new DateTime(1993, 11, 18), firstName = "Batuhan", lastName = "Baykal", TcNo = "54406053276" });
            //Console.ReadLine();
        }
    }
}
