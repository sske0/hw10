namespace hw10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result1 = new Addition();
            var result2 = new Substraction();
            var result3 = new Multiplication();
            var result4 = new Division();
            int number1 = 25;
            int number2 = 5;

            Console.WriteLine($"Addition: first number = {number1}, second number = {number2}, Result: {result1.Operate(number1, number2)}");
            Console.WriteLine($"Substraction: first number = {number1}, second number = {number2}, Result: {result2.Operate(number1, number2)}");
            Console.WriteLine($"Multiplication: first number = {number1}, second number = {number2}, Result: {result3.Operate(number1, number2)}");
            Console.WriteLine($"Division: first number = {number1}, second number = {number2}, Result: {result4.Operate(number1, number2)}");


        }
    }
}