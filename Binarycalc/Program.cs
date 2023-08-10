using System;
#nullable disable

public class BinaryCalc
{
    static int Main(string[] args)
    {
        System.Console.WriteLine("Enter input1: ");
        string str = Console.ReadLine();
        while (!IsValid(str))
        {
            System.Console.WriteLine("Enter a valid input: ");
            str = Console.ReadLine();
        }
        double input1 = Convert.ToDouble(str);

        System.Console.WriteLine("Enter input2: ");
        str = Console.ReadLine();
        while (!IsValid(str))
        {
            System.Console.WriteLine("Enter a valid input: ");
            str = Console.ReadLine();
        }
        double input2 = Convert.ToDouble(str);
        string res = BinaryCalculator(ConvertFloatToBinary(input1), ConvertFloatToBinary(input2));
        System.Console.WriteLine("result in number " + ConvertBinaryToDecimal(res));

        return 0;
    }

    static bool IsValid(string input)
    {
        try
        {
            Convert.ToDouble(input);
        }
        catch(Exception)
        {
            return false;
        }

        return true;
    }

    static string BinaryCalculator(string binary1, string binary2)
    {
        if (binary1[0] == '0' ^ binary2[0] == '0')
            return SubBinaryPointNumbers(binary1, binary2);
        else
        {
            char signBit = binary1[0];
            return signBit + AddBinaryPointNumbers(binary1.Substring(1), binary2.Substring(1));
        }
    }

    static string ConvertFloatToBinary(double num)
    {
        int signBit = (num < 0) ? 1 : 0;
        num = Math.Abs(num);
        int integerPart = (int)num;
        double i = integerPart * 1.0;
        double decimalPart = num - i;
        string binary = "";

        if (integerPart == 0)
            binary = "0";
        else
        {
            while (integerPart > 0)
            {
                int temp = integerPart % 2;
                binary = temp + binary;
                integerPart /= 2;
            }
        }

        binary += ".";
        if (decimalPart != 0)
        {

            while (decimalPart != 0)
            {

                decimalPart *= 2;
                if (decimalPart >= 1)
                {
                    binary += "1";
                    decimalPart -= 1;
                }
                else
                {
                    binary += "0";
                }
            }
        }
        else if (decimalPart == 0)
        {
            binary += "0";
        }
        return signBit + binary;
    }

    static double ConvertBinaryToDecimal(string binary)
    {
        int isNegative = binary[0] - '0';
        binary = binary.Substring(1);
        int len = binary.Length;
        int point = binary.IndexOf('.');
        double intDecimal = 0,
               fracDecimal = 0,
               twos = 1;
        for (int i = point - 1; i >= 0; i--)
        {
            intDecimal += (binary[i] - '0') * twos;
            twos *= 2;
        }
        twos = 2;
        for (int i = point + 1; i < len; i++)
        {
            fracDecimal += (binary[i] - '0') / twos;
            twos *= 2.0;
        }
        if (isNegative == 1)
            return -(intDecimal + fracDecimal);
        else
            return intDecimal + fracDecimal;
    }

    static string AddBinaryPointNumbers(string binaryNo1, string binaryNo2)
    {

        string[] num1Parts = binaryNo1.Split('.');
        string[] num2Parts = binaryNo2.Split('.');
        string num1Int, num2Int, num1Frac, num2Frac;


        if (num1Parts[0].Length >= num2Parts[0].Length)
        {
            num1Int = num1Parts[0];
            num2Int = num2Parts[0];
        }
        else
        {
            num1Int = num2Parts[0];
            num2Int = num1Parts[0];
        }


        if (num1Parts[1].Length >= num2Parts[1].Length)
        {
            num1Frac = num1Parts[1];
            num2Frac = num2Parts[1];
        }
        else
        {
            num1Frac = num2Parts[1];
            num2Frac = num1Parts[1];
        }
        int carry = 0;
        string add = "";
        int i = num1Frac.Length - 1, j = num2Frac.Length - 1;
        int maxFracSize = num1Frac.Length > num2Frac.Length ? num1Frac.Length : num1Frac.Length;
        while (i >= 0)
        {
            if (i > j)
            {
                add = num1Frac[i] + add;
            }
            else
            {
                int temp = (num1Frac[i] - '0') + (num2Frac[i] - '0') + carry;
                if (temp <= 1)
                {
                    add = temp + add;
                    carry = 0;
                }
                else if (temp == 2)
                {
                    add = "0" + add;
                    carry = 1;
                }
                else
                {
                    add = "1" + add;
                    carry = 1;
                }
            }
            i--;
        }
        add = "." + add;
        i = num1Int.Length - 1;
        j = num2Int.Length - 1;
        while (i >= 0)
        {
            if (j < 0)
            {
                int temp = (num1Int[i] - '0') + carry;
                if (temp < 2)
                {
                    add = temp + add;
                    carry = 0;
                }
                else
                {
                    add = "0" + add;
                    carry = 1;
                }
            }
            else
            {
                int temp = (num1Int[i] - '0') + (num2Int[j] - '0') + carry;
                if (temp <= 1)
                {
                    add = temp + add;
                    carry = 0;
                }
                else if (temp == 2)
                {
                    add = "0" + add;
                    carry = 1;
                }
                else
                {
                    add = "1" + add;
                    carry = 1;
                }
            }
            i--;
            j--;
        }
        if (carry == 1)
        {
            add = "1" + add;
        }
        return add;
    }
    static string SubBinaryPointNumbers(string binaryNo1, string binaryNo2)
    {

        int signNum = binaryNo1[0] == '1' ? 1 : 2;
        binaryNo1 = binaryNo1.Substring(1);
        binaryNo2 = binaryNo2.Substring(1);
        string[] num1Parts = binaryNo1.Split('.');
        string[] num2Parts = binaryNo2.Split('.');
        string num1Int, num2Int, num1Frac, num2Frac;
        num1Int = num1Parts[0].Length > 0 ? num1Parts[0] : "0";
        num2Int = num2Parts[0].Length > 0 ? num2Parts[0] : "0";
        num1Frac = num1Parts[1].Length > 0 ? num1Parts[1] : "0";
        num2Frac = num2Parts[1].Length > 0 ? num2Parts[1] : "0";

        if (num1Int.Length > num2Int.Length)
            num2Int = num2Int.PadLeft(num1Int.Length, '0');
        else if (num1Int.Length < num2Int.Length)
            num1Int = num1Int.PadLeft(num2Int.Length, '0');

        if (num1Frac.Length > num2Frac.Length)
            num2Frac = num2Frac.PadRight(num1Frac.Length, '0');
        else if (num1Frac.Length < num2Frac.Length)
            num1Frac = num1Frac.PadRight(num2Frac.Length, '0');

        binaryNo1 = num1Int + "." + num1Frac;
        binaryNo2 = num2Int + "." + num2Frac;
        int flag = 0;
        for (int i = 0; i < binaryNo1.Length; i++)
        {
            if (binaryNo1[i] == '1' && binaryNo2[i] == '0')
            {
                flag = 1;
                break;
            }
            else if (binaryNo1[i] == '0' && binaryNo2[i] == '1')
            {
                flag = 2;
                break;
            }
        }
        string s = AddBinaryPointNumbers(num1Int + "." + num1Frac, Complement(num2Int + "." + num2Frac, 1));
        string signBit = "";
        if (signNum == flag)
            signBit = "1";
        else signBit = "0";
        if ((num1Int + "." + num1Frac).Length < s.Length)
            return signBit + s.Substring(1);
        else
        {
            s = Complement(s, 2);
            if ((num1Int + "." + num1Frac).Length < s.Length)
                return signBit + s.Substring(1);
            else
                return signBit + s;
        }

    }

    static string Complement(string binary, int repeat)
    {
        string res = "";
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
                res = res + '1';
            else if (binary[i] == '1')
                res = res + '0';
            else
                res = res + binary[i];
        }

        int carry = 1;
        int resSize = res.Length - 1;
        string compAdd = "";
        while (resSize >= 0)
        {
            int t = res[resSize] - '0' + carry;
            if (t == 0 || t == 1)
            {
                compAdd = t + compAdd;
                carry = 0;
            }
            else if (t == 2)
            {
                compAdd = '0' + compAdd;
                carry = 1;
            }
            else compAdd = '.' + compAdd;
            resSize--;
        }
        if (carry == 1 && repeat != 2)
            return binary;
        else
            return compAdd;
    }
}