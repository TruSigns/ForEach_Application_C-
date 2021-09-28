using System;

namespace LoopApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;

            string inputValueType;

            Console.WriteLine("Enter a value: ");
            inputValueType = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.WriteLine("Enter :");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    //check string
                    valid = isAllApphabetic(inputValueType);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValueType, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool fetflag = false;
                    valid = bool.TryParse(inputValueType, out fetflag);
                    break;
                default:
                    inputValueType = "Empty";
                    Console.WriteLine("Not able to detect the input type, please try again");
                    break;



            }

            Console.WriteLine("You have enter a value of : {0},", inputValueType);
            if (valid)
            {
                Console.WriteLine("It is valid {0}", inputValueType);

            }
            else
            {
                Console.WriteLine("It is invalid : {0}", inputValueType);
            }

            Console.ReadKey();

        }

        static bool isAllApphabetic(string Value)
        {
            
            foreach( char c in Value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;

        }

    }
}
