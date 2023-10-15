namespace ChainOfResponsibility
{
    internal class Add: Handler
    {
        private readonly int More = 2;
        public Add(int number)
        {
            More = number;
        }
        public override int? Transform(int number)
        {
            Console.WriteLine("Adding " + More + " TO " + number);
            return number + More;
        }
    }
}
