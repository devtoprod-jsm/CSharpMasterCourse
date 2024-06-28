namespace BasicDebuggingAndExceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            BadCall();
        }
        catch (Exception ex)
        {
            Console.WriteLine("There is an error that occured");
            Console.WriteLine(ex.Message);

        }

        Console.ReadLine();
    }

    public static void BadCall()
    {
        int[] numbers = new int[] { 1, 3, 5 };
        for (int i = 0; i <= numbers.Length; i++)
        {
            try
            {
                Console.WriteLine(numbers[i]);

            }

            catch (Exception ex)
            {
                Console.WriteLine("There is an error");
                Console.WriteLine(ex.Message);
                throw new Exception("There is an error that occured handling the array", ex);
            }
        }
    }
}

