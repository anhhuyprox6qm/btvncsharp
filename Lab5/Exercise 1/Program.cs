using System;
using System.Runtime.InteropServices;
using Lab5.Customer;
using Lab5.Order;
namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        ShowSelection();
        }
        public static void ShowSelection()
        {
            while (true)
            {
                Console.WriteLine("Enter username: ");
                var name = Console.ReadLine();
                CustomerName customerName = new CustomerName();
                customerName.Customer(name);
                Console.WriteLine("YOUR CHOICE:");
                Console.WriteLine("* * * * * * * * * * * * * ");
                Console.WriteLine("1.Groceries");
                Console.WriteLine("2.Bakery Product");
                Console.WriteLine("Enter your choose(1-2):");
                var selection = int.Parse(Console.ReadLine());
                if (selection==1)
                {
                    GroceryItems groceryItems = new GroceryItems();
                    Console.WriteLine(groceryItems.Groceries());
                    break;
                }else if (selection==2)
                {
                    Bakery bakery = new Bakery();
                    Console.WriteLine(bakery.BakeryProduct());
                    break;
                }
                else
                {
                    Console.WriteLine("You have to choose from 1-2!");
                }
            }
        }
    }
}