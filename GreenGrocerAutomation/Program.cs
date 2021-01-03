using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreenGrocerAutomation
{
    class Program
    {
        public static ArrayList wholesaleFruits = new ArrayList() { "Apple", "Pear", "Banana", "Cherry", "Strawberry" };
        public static ArrayList wholesaleVegetables = new ArrayList() { "Eggplant", "Tomato", "Pepper", "Potato", "Onion" };

        public static ArrayList fruits = new ArrayList();
        public static ArrayList vegetables = new ArrayList();
        public static ArrayList customer = new ArrayList();

        public static double Apple = 0, Pear = 0, Banana = 0, Cherry = 0, Strawberry = 0, Eggplant = 0, Tomato = 0, Pepper = 0, Potato = 0, Onion = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Wholesale Transactions\n2-Green Grocer Transactions\n3-Customer Transactions\nPlease select a transaction:");
                int transaction = Convert.ToInt32(Console.ReadLine());
                switch (transaction)
                {
                    case 1:
                        wholesaler:
                        Console.WriteLine("Welcome to marketplace !");
                        Console.WriteLine("Would you like fruits or vegetables ? Please make your choice : F / V");
                        string choice = Console.ReadLine().ToUpper();
                        switch (choice)
                        {
                            case "F":
                                for (int i = 0; i < wholesaleFruits.Count; i++)
                                {
                                    Console.WriteLine((i) + "-" + wholesaleFruits[i]);
                                }
                                int fruit = Convert.ToInt32(Console.ReadLine());
                                if (0 <= fruit && fruit < wholesaleFruits.Count)
                                {
                                    fruitSales(fruit);
                                    if (goBack())
                                    {
                                        goto wholesaler;

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect transaction selection!");
                                    Console.WriteLine("You are redirected to the main menu...");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                }
                                    break;

                                    case "V":
                                        for (int i = 0; i < wholesaleVegetables.Count; i++)
                                    {
                                        Console.WriteLine((i) + "-" + wholesaleVegetables[i]);

                                    }
                                    int vegetables = Convert.ToInt32(Console.ReadLine());
                                    if (0 <= vegetables && vegetables < wholesaleVegetables.Count)
                                    {
                                        vegetableSales(vegetables);
                                        if (goBack())
                                        {
                                            goto wholesaler;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect transaction selection!");
                                        Console.WriteLine("You are redirected to the main menu...");
                                        Thread.Sleep(3000);
                                        Console.Clear();
                                    }
                                    break;
                               default:
                                    Console.WriteLine("Incorrect transaction selection!");
                                    Console.WriteLine("You are redirected to the main menu...");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                }
                                break;

                            case 2:
                                greenGrocer:
                                Console.WriteLine("Welcome to Green Grocer! ");
                                Console.WriteLine("Would you like fruits or vegetables ? Please make your choice : F / V");
                                string choice1 = Console.ReadLine().ToUpper();
                                int j = 1;
                                switch (choice1)
                                {
                                    case "F":
                                        if (fruits.Count == 0)
                                        {
                                            Console.WriteLine("There are no more fruits.");
                                            Console.WriteLine("You are redirected to the main menu...");
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                            goto greenGrocer;
                                        }
                                        foreach (string item in fruits)
                                        {
                                            Console.WriteLine(j + "-" + item);
                                            j++;
                                        }
                                        string fruit = Console.ReadLine().ToUpper();

                                        if (fruits.Contains(fruit))
                                        {
                                            if (customer.Contains(fruit) == false)
                                            {
                                                customer.Add(fruit);

                                            }
                                            Console.WriteLine("How many kilos would you like ?");
                                            double kilo = Convert.ToDouble(Console.ReadLine());

                                            if (fruit == "Apple" && Apple >= kilo)
                                            {
                                                Apple = Apple - kilo;
                                                if (Apple == 0)
                                                {
                                                    Console.WriteLine("There are no more apples.");
                                                    fruits.Remove(fruit);
                                                }
                                            }
                                            else if (fruit == "Pear" && Pear >= kilo)
                                            {
                                                Pear = Pear - kilo;
                                                if (Pear == 0)
                                                {
                                                    Console.WriteLine("There are no more pears.");
                                                    fruits.Remove(fruit);

                                                }

                                            }
                                            else if (fruit == "Banana" && Banana >= kilo)
                                            {
                                                Banana = Banana - kilo;
                                                if (Banana == 0)
                                                {
                                                    Console.WriteLine("There are no more bananas.");
                                                    fruits.Remove(fruit);

                                                }

                                            }
                                            else if (fruit == "Cherry" && Cherry >= kilo)
                                            {
                                                Cherry = Cherry - kilo;
                                                if (Cherry == 0)
                                                {
                                                    Console.WriteLine("There are no more cherries.");
                                                    fruits.Remove(fruit);

                                                }

                                            }
                                            else if (fruit == "Strawberry" && Strawberry >= kilo)
                                            {
                                                Strawberry = Strawberry - kilo;
                                                if (Strawberry == 0)
                                                {
                                                    Console.WriteLine("There are no more strawberries.");
                                                    fruits.Remove(fruit);

                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect fruit input!");
                                                goto greenGrocer;
                                            }
                                        }
                                        Console.WriteLine("Do you have any other request? Please make your choice Y(Yes) / N(No)");
                                        string goBack = Console.ReadLine().ToUpper();
                                        switch (goBack)
                                        {
                                            case "Y":
                                                goto greenGrocer;
                                            case "N":
                                                Console.WriteLine("You are redirected to the main menu...");
                                                Thread.Sleep(3000);
                                                Console.Clear();
                                                break;
                                        }
                                        break;

                                    case "V":
                                        if (vegetables.Count == 0)
                                        {
                                            Console.WriteLine("There are no more vegetables.");
                                            Console.WriteLine("You are redirected to the main menu...");
                                            Thread.Sleep(3000);
                                            Console.Clear();
                                            goto greenGrocer;
                                        }
                                        foreach (string item in vegetables)
                                        {
                                            Console.WriteLine(j + "-" + item);
                                            j++;

                                        }
                                        string vegetable = Console.ReadLine().ToUpper();

                                        if (vegetables.Contains(vegetable))
                                        {
                                            if (customer.Contains(vegetable) == false)
                                            {
                                                customer.Add(vegetable);

                                            }

                                            Console.WriteLine("How many kilos would you like?");
                                            double kilo = Convert.ToDouble(Console.ReadLine());

                                            if (vegetable == "Eggplant" && Eggplant >= kilo)
                                            {
                                                Eggplant = Eggplant - kilo;
                                                if (Eggplant == 0)
                                                {
                                                    Console.WriteLine("There are no more eggplants.");
                                                    vegetables.Remove(vegetable);

                                                }
                                            }

                                            else if (vegetable == "Tomato" && Tomato >= kilo)
                                            {
                                                Tomato = Tomato - kilo;
                                                if (Tomato == 0)
                                                {
                                                    Console.WriteLine("There are no more tomatoes.");
                                                    vegetables.Remove(vegetable);
                                                }

                                            }
                                            else if (vegetable == "Pepper" && Pepper >= kilo)
                                            {
                                                Pepper = Pepper - kilo;
                                                if (Pepper == 0)
                                                {
                                                    Console.WriteLine("There are no more peppers.");
                                                    vegetables.Remove(vegetable);
                                                }

                                            }
                                            else if (vegetable == "Potato" && Potato >= kilo)
                                            {
                                                Potato = Potato - kilo;
                                                if (Potato == 0)
                                                {
                                                    Console.WriteLine("There are no more potatoes.");
                                                    vegetables.Remove(vegetable);
                                                }

                                            }
                                            else if (vegetable == "Onion" && Onion >= kilo)
                                            {
                                                Onion = Onion - kilo;
                                                if (Onion == 0)
                                                {
                                                    Console.WriteLine("There are no more onions.");
                                                    vegetables.Remove(vegetable);
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect vegetable input!");
                                                goto greenGrocer;
                                            }
                                        }
                                        Console.WriteLine("Do you have any other request? Please make your choice Y(Yes) / N(No)");
                                        string goBack1 = Console.ReadLine().ToUpper();
                                        switch (goBack1)
                                        {
                                            case "Y":
                                                goto greenGrocer;
                                            case "N":
                                                Console.WriteLine("You are redirected to the main menu...");
                                                Thread.Sleep(3000);
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Incorrect Transaction Selection.");
                                                Console.WriteLine("You are redirected to the main menu...");
                                                Thread.Sleep(3000);
                                                Console.Clear();
                                                break;

                                        }
                                        break;
                                }
                                break;

                            case 3:
                                Console.WriteLine("Customer Basket");
                                foreach (var item in customer)
                                {
                                    Console.WriteLine(item);

                                }
                                break;
                            default:
                                Console.WriteLine("Incorrect Transaction Selection.");
                                Console.WriteLine("You are redirected to the main menu...");
                                Thread.Sleep(3000);
                                Console.Clear();
                                break;
                        }
                }
            }

            static void fruitSales(int fruit)
            {

                if (fruits.Contains(wholesaleFruits[fruit]) == false)
                {
                    fruits.Add(wholesaleFruits[fruit]);
                }
                Console.WriteLine("How many kilos would you like?");
                double kilo = Convert.ToDouble(Console.ReadLine());

                switch (wholesaleFruits[fruit])
                {
                    case "Apple":
                        Apple += kilo;
                        break;
                    case "Pear":
                        Pear += kilo;
                        break;
                    case "Banana":
                        Banana += kilo;
                        break;
                    case "Cherry":
                        Cherry += kilo;
                        break;
                    case "Strawberry":
                        Strawberry += kilo;
                        break;
                }
            }

            static void vegetableSales(int vegetable)
            {
                if (vegetables.Contains(wholesaleVegetables[vegetable]) == false)
                {

                    vegetables.Add(wholesaleVegetables[vegetable]);
                }
                Console.WriteLine("How many kilos would you like ?");
                double kilo = Convert.ToDouble(Console.ReadLine());

                switch (wholesaleVegetables[vegetable])
                {
                    case "Eggplant":
                        Eggplant += kilo;
                        break;
                    case "Tomato":
                        Tomato += kilo;
                        break;
                    case "Pepper":
                        Pepper += kilo;
                        break;
                    case "Potato":
                        Potato += kilo;
                        break;
                    case "Onion":
                        Onion += kilo;
                        break;
                }
            }
            static bool goBack()
            {
                Console.WriteLine("Do you have any other request? Please make your choice Y(Yes) / N(No)");
                string goBack = Console.ReadLine().ToUpper();
                switch (goBack)
                {
                    case "Y":
                        return true;
                    case "N":
                        Console.WriteLine("You are redirected to the main menu...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return false;
                    default:
                        Console.WriteLine("Incorrect Transaction Selection.");
                        Console.WriteLine("You are redirected to the main menu...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return false;
                }
            }
        }
    }



















  