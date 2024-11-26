namespace Carwash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Проект автомивка
            //Коли, Работници, Разходи
            //- да можем да измием кола
            //--Бусове, ЛА, Джипове
            //- справка за всеки един автомобил по рег. НОмер
            //Трябва да можем да правим справка за приходите
            //трябва да можем да правим справка за разходите
            //справки за персонала
            //назначаване на хора
            //уволняване на хора
            //плащане назаплати
            //данъци

            Console.WriteLine("Type of carbeing washed:");
            Vehicle poo = new Vehicle(Console.ReadLine());
            Vehicle shoe = new Vehicle(Console.ReadLine());
            Money cost = new Money();
            Money cost2 = new Money();
            cost.vehiclecost(poo);
            cost2.vehiclecost(shoe);
            PrintFinances();
            //Personnel newperson = new Personnel(19, "Jamal", "white");
            //Console.WriteLine(newperson.Age);
            //Console.WriteLine(newperson.Race);
            //Personnel.hireperson(newperson);

        }
    }
}
