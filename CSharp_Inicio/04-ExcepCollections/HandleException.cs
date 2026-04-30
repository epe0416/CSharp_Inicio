using System.Linq.Expressions;

partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try
        {
            //int numbre = 10;
            //int result = numbre / 0;
            Write("Ingrese un monto: ");
            amount = ReadLine();
            if (string.IsNullOrEmpty(amount)) return;

            //double amountValue = double.Parse(amount);
            if(double.TryParse(amount, out double amountValue))
            {
                WriteLine($"El monto que introdujiste es el siguiente: {amountValue:C}");
            }
            else
            {
                WriteLine("No se pudo convertir el texto a numero");
            }
            ValidateAge(16);
            

        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: División por cero");
        }
        catch (FormatException) when (amount?.Contains("$") == true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("No es necesario usar '$'");
        }
        catch (Exception ext)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(ext.Message);
        }
        finally
        {
            Console.ResetColor();
            WriteLine("Esto siempre se ejectura");
        }
    }
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("La edad debe ser mayor a 18");

        }
    }

}