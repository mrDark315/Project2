namespace lab1
{
    internal class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;

            Console.WriteLine("Enter amount (in uah): ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter currency (usd/eur/rub): ");
            Currency = Console.ReadLine();

            ConvertToUah();
        }

        public double Usd { get; }
        public double Eur { get; }
        public double Rub { get; }

        public double Amount { get; }
        public string Currency { get; }

        public double ConvertToUah()
        {
            switch (Currency)
            {
                case "usd":
                    return Amount * Usd;
                case "eur":
                    return Amount * Eur;
                case "rub":
                    return Amount * Rub;
                default:
                    return 0;
            }
        }
    }
}
