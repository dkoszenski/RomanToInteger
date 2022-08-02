using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculate {
    public static int Add(char[] c) {
        int total = 0;
        bool subtract;
        for(int i = 0; i < c.Length; i++) {
            int CurrentValue = RomanNumerals.GetValue(c[i]);
            Console.WriteLine(CurrentValue);

            if (i + 1 >= c.Length) {
                subtract = false;
            }
            else {
                subtract = SubtractValue(c[i + 1], CurrentValue);
            }

            if (subtract) {
                total -= CurrentValue;
            }
            else {
                total += CurrentValue;
            }

            Console.WriteLine("Total: " + total);
        }

        return total;
    }

    public static bool SubtractValue(char c, int i) {
        int NextValue = RomanNumerals.GetValue(c);
        if(NextValue !<= i) {
            return false;
        } 
        else {
            return true;
        }
    }

}