namespace Carwash
{
    internal class Personnel
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }

        public Personnel(int age, string name, string race)
        {
            this.Age = age;
            this.Name = name;
            this.Race = race;
        }

        public static void hireperson(Personnel personnel)
        {
            if (personnel.Age < 16 || personnel.Race == "black")
            {
                Console.WriteLine("You cannot work with us");
            }
            else
            {
                Console.WriteLine("You are hired");
            }



        }



    }
}
