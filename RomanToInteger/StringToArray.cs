using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringToArray {
    public string InputString { get; set; }
    public char[] CharArray { get; set; }

    public StringToArray(string inputString) {
        InputString = inputString;
        CharArray = new char[inputString.Length];
    }

    public void Convert() {

        for (int i = 0; i < CharArray.Length; i++) {
            CharArray[i] = InputString[i];
        }
    }
}