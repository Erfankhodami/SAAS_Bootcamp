class Program
{
    static void Main()
    {
        string inputString;
        inputString = Console.ReadLine();
        int firstCharAscii=(int) inputString[0];
        if (inputString[0] != '#')
        {
            PrintInvalid(inputString);
        }

        bool isValid=true;
        foreach (char c in inputString.Substring(1))
        {
            int ascii = (int)c;
            if ((ascii >= 65 && ascii <= 70)|| (ascii >= 48 && ascii <= 57))
            {
                continue;
            }
            isValid=false;
            break;
        }

        if (isValid)
        {
            PrintValid(inputString);
        }
        else
        {
            PrintInvalid(inputString);
        }
    }

    static void PrintInvalid(string inputString)
    {
        Console.WriteLine("'"+inputString+"'"+" isn't valid.");
    }

    static void PrintValid(string inputString)
    {
        Console.WriteLine("'"+inputString+"'"+" is valid.");
    }
}