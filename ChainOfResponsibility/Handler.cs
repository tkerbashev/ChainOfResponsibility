namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        public Handler? Next { get; set; }

        public virtual int? Transform (int number)
        {
            return null;
        }

        public void Update(int number)
        {
            var transformedNumber = Transform(number);

            if (!transformedNumber.HasValue)
            {
                Console.WriteLine("The transformation failed during " + this.GetType().Name + "!");
                return;
            }

            if (Next != null)
            {
                Next.Update(transformedNumber.Value);
            }
            else
            {
                Console.WriteLine("The final result is " + transformedNumber);
            }
        }
    }
}
