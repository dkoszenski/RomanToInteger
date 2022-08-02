using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class RomanNumerals {
    public static readonly Dictionary<char, int> RomanNumeralsDictionary;

    static RomanNumerals() {
        RomanNumeralsDictionary = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
    }

    public static int GetValue(char c) {
        return RomanNumeralsDictionary[c];
    }

    public static bool ValidateNumeral(char c) {
        return RomanNumeralsDictionary.ContainsKey(c);
    }
}
