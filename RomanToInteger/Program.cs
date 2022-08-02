using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class main {
    static void Main(string[] args) {

        StringToArray input = new StringToArray("MMCCXXIV");
        input.Convert();

        int TotalValue = Calculate.Add(input.CharArray);
        Console.WriteLine(TotalValue);

    }

}