namespace AdvancedExceptions;

class Program
{
    static void Main(string[] args)
    {
        string? name = "";
        try
        {
            DifferentMethod();
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();
            ComplexMethod(name);
            SimpleMethod();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("You forgot to finish your code!!!");
        }
        catch (Exception) when (name.ToLower() == "jai")
        {
            Console.WriteLine("You used Jai's name!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("I always run!!!");
        }
        Console.ReadLine();
    }

    private static void ComplexMethod(string? name)
    {
        if (name.ToLower() == "jai")
        {
            throw new InsufficientMemoryException("Jai is too tall for this method!!");
        }
        else
        {
            throw new ArgumentException("You are not Jai!!!");
        }
    }

    private static void SimpleMethod()
    {
        throw new InvalidOperationException("You should not be calling the SimpleMethod");
    }

    private static void DifferentMethod()
    {
        Console.WriteLine("This is a different method now implemented!!");
        //throw new NotImplementedException();
    }
}

