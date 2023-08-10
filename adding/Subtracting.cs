class Calculator
{
    static string ArrayToString(int[] array)
    {
        string str = "";
        for (int i = 0; i < array.Length; i++)
        {
            str = str + array[i];
        }
        return str;
    }

    static string Adder(int[] num1, int[] num2, int num1Size, int num2Size)
    {
        int[] sum = new int[num1Size];
        int i = num1Size - 1, j = num2Size - 1, k = num1Size - 1;
        int carry = 0, s = 0;

        while (i >= 0)
        {
            s = j >= 0 ? num1[i] + num2[j] + carry : num1[i] + carry;
            // s = num1[i] + num2[j] + carry ;
            sum[k] = (s % 10);
            carry = s / 10;
            k--;
            i--;
            j--;
        }
        // while (i >= 0)
        // {
        //     s = num1[i] + carry;
        //     sum[k] = (s % 10);
        //     carry = s / 10;
        //     i--;
        //     k--;
        // }
        if (carry == 1)
            sum[0] += 10;
        string result = "";
        for (int t = 0; t < num1Size; t++)
        {
            result = result + sum[t];
        }
        return result;
    }

    static string CalSum(int[] num1, int[] num2)
    {
        int num1Size = num1.Length;
        int num2Size = num2.Length;
        if (num1Size >= num2Size)
            return Adder(num1, num2, num1Size, num2Size);
        else
            return Adder(num2, num1, num2Size, num1Size);
    }

    public class InvalidInputException : Exception
    {
        public InvalidInputException(String message) : base(message)
        {
        }
    }
    static string Subtracter(int[] num1, int[] num2, int num1Size, int num2Size)
    {
        Array.Reverse(num1);
        Array.Reverse(num2);

        int i, carry = 0;
        int[] result = new int[num1.Length];

        for (i = 0; i < num1.Length; i++)
        {
            int digit1 = num1[i];
            int digit2 = (i < num2.Length) ? num2[i] : 0;
            int diff = digit1 - digit2 - carry;

            if (diff < 0)
            {
                diff += 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            result[i] = diff;

        }
        string s = ArrayToString(result);
        i = 0;
        string res = "";
        while (i < s.Length && s[i] == '0')
        {
            i++;
        }
        if (i == s.Length)
        {
            return "0";
        }
        while (i < s.Length)
        {
            res = s[i] + res;
            i++;
        }
        // Console.WriteLine(res);

        return res;
    }
    static string calDif(int[] num1, int[] num2)
    {

        int num1Size = num1.Length;
        int num2Size = num2.Length;
        if (num1Size > num2Size)
        {
            return "-" + Subtracter(num1, num2, num1Size, num2Size);
        }
        else if (num1Size == num2Size)
        {
            for (int i = 0; i < num1Size; i++)
            {
                if (num1[i] > num2[i])
                {
                    string s = Subtracter(num1, num2, num1Size, num2Size);
                    if (s.Equals("0"))
                        return s;
                    else
                        return "-" + s;
                }
                if (num1[i] < num2[i])
                    return Subtracter(num2, num1, num2Size, num1Size);
            }
        }
        return Subtracter(num2, num1, num2Size, num1Size);
    }

    public static void UpdateName(Employee Emp2)
    {
        Emp2.Name = "Smith";
        Console.WriteLine($"Emp2 Name = {Emp2.Name}");
    }

    static void Main(string[] args)
    {
        Employee Emp1 = new Employee();
        Emp1.EmployeeID = 1001;
        Emp1.Name = "James";
        UpdateName(Emp1);
        Console.WriteLine($"Emp1 Name = {Emp1.Name}");
        Console.ReadKey();
        // var watch = new System.Diagnostics.Stopwatch();
        // watch.Start();
        // try
        // {
        //     if (args.Length < 2 || (args[0].Length == 0 || (args[0].Length == 1 && args[0][0] == '-')) || (args[0].Length == 0 || (args[1].Length == 1 && args[1][0] == '-')))
        //         throw new InvalidInputException("Invalid input");

        //     args[0] = args[0][0] == '-' ? '-' + args[0].Substring(1).TrimStart('0') : args[0].TrimStart('0');
        //     args[1] = args[1][0] == '-' ? '-' + args[1].Substring(1).TrimStart('0') : args[1].TrimStart('0');
        //     args[0] = args[0].Equals("-") ? "-0" : args[0];
        //     args[1] = args[0].Equals("-") ? "-0" : args[1];
        // foreach(char c in args[0]){
        //     Console.Write(c+" ");
        // }
        // System.Console.WriteLine();
        //  foreach(char c in args[1]){
        //     Console.Write(c+" ");
        // }
        // System.Console.WriteLine();
        //     if (args[0][0] == '-' ^ args[1][0] == '-')
        //     {
        //         int[] num1 = args[0][0] == '-' ? new int[args[0].Length - 1] : new int[args[0].Length];
        //         int[] num2 = args[1][0] == '-' ? new int[args[1].Length - 1] : new int[args[1].Length];
        //         int i = 0, j = 0;
        //         if (args[0][0] == '-') { i = 1; j = 0; }
        //         while (i < args[0].Length)
        //         {
        //             num1[j] = args[0][i] - '0';
        //             if (!(num1[j] >= 0 && num1[j] <= 9))
        //                 throw new InvalidInputException("Found invalid char in second input");
        //             i++; j++;
        //         }
        //         i = 0; j = 0;
        //         if (args[1][0] == '-') { i = 1; j = 0; }
        //         while (i < args[1].Length)
        //         {
        //             num2[j] = args[1][i] - '0';
        //             if (!(num2[j] >= 0 && num2[j] <= 9))
        //                 throw new InvalidInputException("Found invalid char in second input");
        //             i++; j++;
        //         }
        //         if (args[0][0] == '-')
        //             Console.WriteLine(calDif(num1, num2));
        //         else
        //             Console.WriteLine(calDif(num2, num1));
        //     }
        //     else
        //     {
        //         int i = 0; int j = 0;
        //         if (args[0][0] == '-')
        //         {
        //             i = 0;
        //             j = 1;
        //         }
        //         int[] num1 = new int[args[0].Length - j];
        //         int[] num2 = new int[args[1].Length - j];
        //         int tempi = i;
        //         int tempj = j;
        //         while (tempi < num1.Length)
        //         {
        //             num1[tempi] = args[0][tempj] - '0';
        //             if (!(num1[tempi] >= 0 && num1[tempi] <= 9))
        //                 throw new InvalidInputException("Found invalid char in first input");
        //             tempi++;
        //             tempj++;
        //         }
        //         tempi = i;
        //         tempj = j;
        //         while (tempi < num2.Length)
        //         {
        //             num2[tempi] = args[1][tempj] - '0';
        //             if (!(num2[tempi] >= 0 && num2[tempi] <= 9))
        //                 throw new InvalidInputException("Found invalid char in second input");
        //             tempi++;
        //             tempj++;
        //         }

        //         int num1Size = num1.Length;
        //         int num2Size = num2.Length;
        //         if (args[0][0] == '-')
        //         {
        //             string s = CalSum(num1, num2);
        //             if (s.Equals("0"))
        //             {
        //                 Console.WriteLine(s);
        //             }
        //             else
        //                 Console.WriteLine("-" + s);
        //         }
        //         else
        //             Console.WriteLine(CalSum(num1, num2));
        //     }
        // }
        // catch (InvalidInputException e)
        // {
        //     Console.WriteLine(e);
        // }
        // // watch.Stop();
        // Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}