namespace ChainOfResponsibility
{
    internal class Multiply: Handler
    {
        private readonly int By = 5;
        public Multiply(int number)
        {
            By = number;
        }
        public override int? Transform(int number)
        {
            Console.WriteLine("Multiplying " + number + " by " + By);
            return number * By;
        }
    }
}
