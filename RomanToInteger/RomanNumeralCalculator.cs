using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RomanNumeralCalculator : IStringToIntCalculator{

    private static readonly Dictionary<char, int> RomanNumeralsDictionary = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };
    public int CalculateStringToInt(string str) {
        int total = 0;
        bool shouldSubtract;
        int indexNextValue;
        for(int targetIndex = 0; targetIndex < str.Length; targetIndex++) {
            int indexCurrentValue = RomanNumeralsDictionary[str[targetIndex]];

            if ( targetIndex + 1 == str.Length) {
                shouldSubtract = false;
            }
            else {
                indexNextValue = RomanNumeralsDictionary[str[targetIndex + 1]];
                shouldSubtract = indexNextValue > indexCurrentValue;
            }

            total += shouldSubtract ? -indexCurrentValue : indexCurrentValue;            

        }

        return total;
    }
}
