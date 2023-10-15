// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility;

Console.Write("Enter an integer between 1 and 100: ");
if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 100)
{
    var stepAdd = new Add(2);
    var stepMultiply = new Multiply(5);
    var stepSubtract = new Subtract(10);
    var stepDivide = new Divide(5);

    stepAdd.Next = stepMultiply;
    stepMultiply.Next = stepSubtract;
    stepSubtract.Next = stepDivide;

    stepAdd.Update(number);
}
else
{
    Console.WriteLine("Invalid answer. I am disappointed! Exiting...");
}