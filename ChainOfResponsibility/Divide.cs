namespace ChainOfResponsibility
{
    internal class Divide: Handler
    {
        private readonly int By = 5;
        public Divide(int number)
        {
            By = number;
        }
        public override int? Transform(int number)
        {
            Console.WriteLine("Dividing " + number + " by " + By);
            try
            {
                var result = number / By;
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
