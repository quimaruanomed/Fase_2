using System;
using System.Xml.Serialization;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {

            const double leapYear= 1948;
            double turnYear = 4; //cada cuatro años hay un año bisiesto
            double a = 0.0, b=0.0, c=0.0;
            double difLBirthay = 1972 - 1948; //años que hay entre 1948 y 1972
            double yL = difLBirthay / turnYear; //Cantidad/Numero de años bisiestos que hay entre 1948 y 1972 
           
                        
            Console.WriteLine("Cuantos años hay entre 1948 y  1972: " + " " + difLBirthay +  "\n");
            Console.WriteLine(" Años bisiestos entre 1948 y 1972: " + yL + "\n");
            
            

        }
    }
}
