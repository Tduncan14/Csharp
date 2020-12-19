using System;
using System.IO;
using System.Xml;


var xm11 = new XmlDocument();

XmlDocument xm12 = new XmlDocument();

var file1 = File.CreateText(@"C:\something.txt");
StreamWriter file2 = File.CreateText(@"C:\something.txt");

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // object height = 1.88;
            // object name = "Amir";


            // Console.WriteLine($"{name} is {height} metres tall");

            // // int length1 = name.Length; //gives compile error
            // int length2 = ((string)name).Length;

            // Console.WriteLine($"{name} has {length2} characters.");


            //  storing a string in a dymaic object

            //  dynamic anotherName = "Ahmed";


            //  int length = anotherName.Length;


            //  Console.WriteLine($"{length}");


        //    var  population = 66_000_000; // 
        //    var  weight = 1.88;
        //    var Price = 4.99;
        //    var Fruit = "Apples";
        //    var letter = 'Z'; // chars use single-quotes;
        //    var happy = true;


        }
    }
}
