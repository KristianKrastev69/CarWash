namespace Carwash
{

    internal class Money
    {
        private double revenue = 0;
        private double expenses = 0;
        public void vehiclecost(Vehicle vehicle)
        {
            switch (vehicle.Vehicletype)
            {
                case "sedane":
                    Console.WriteLine("Car costs 2lv");
                    revenue += 2;
                    expenses += 0.5;
                    break;
                case "jeep":
                    revenue += 4;
                    expenses += 1;
                    break;
                case "bus":
                    revenue += 6;
                    expenses += 2;
                    break;
            }
        }
        public void PrintFinances()
        {
            Console.WriteLine($"Your revenue is {revenue}$");
            Console.WriteLine($"Your expences are {expenses}$");

        }
    }
}
