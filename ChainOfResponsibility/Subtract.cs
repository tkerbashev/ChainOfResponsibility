namespace ChainOfResponsibility
{
    internal class Subtract: Handler
    {
        private readonly int Less = 10;
        public Subtract(int number)
        {
            Less = number;
        }
        public override int? Transform(int number)
        {
            Console.WriteLine("Subtracting " + Less + " from " + number);
            return number - Less;
        }
    }
}
