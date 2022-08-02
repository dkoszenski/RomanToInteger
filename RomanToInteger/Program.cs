using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class main {
    static void Main(string[] args) {

        string inputString = Console.ReadLine();
        
        RomanNumeralCalculator calc = new RomanNumeralCalculator();

        Console.WriteLine(calc.CalculateStringToInt(inputString));
        

    }

}