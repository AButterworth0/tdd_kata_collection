public static class FizzBuzz
{
    public static string GetOutput(int number)
    { 
        if (IsMultipleOf5(number) && IsMultipleOf3(number))
            return "FizzBuzz";

        if (IsMultipleOf5(number))
            return "Buzz";

        if (!IsMultipleOf5(number) && !IsMultipleOf3(number))
            return number.ToString();

        if (IsMultipleOf3(number))
            return "Fizz";

        return "";
    }

    private static bool IsMultipleOf5(int number)
    {
        if (number % 5 == 0)
            return true;

        return false;  
    }

    private static bool IsMultipleOf3(int number)
    { 
        if (number % 3 == 0)
            return true;

        return false;
    }
}
