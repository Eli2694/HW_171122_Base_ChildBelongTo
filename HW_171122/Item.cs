using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_171122
{

    class RunItem
    {
        public void runTwoItems()
        {
            Item[] items1 = new Item[2];
            Food pizza = new Food(1,5);
            Drink Cola = new Drink(1,"Black");

            items1[0] = pizza;
            items1[1] = Cola;


        }

        public void runTenItems()
        {

            Food pizza = new Food(1, 5);
            Drink Cola = new Drink(1, "Black");

            Item[] items2 = new Item[10];
            int countItmes = 0;
            for (int i = 0; i < 10; i++)
            {
                if (countItmes < 5)
                {
                    items2[countItmes] = pizza;

                }
                else
                {
                    items2[countItmes] = Cola;
                }
                countItmes++;
            }

            pizza.Name = "Pizza";
            Cola.Name = "Cola";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Id: {0} Name: {1}", items2[i].Id, items2[i].Name);
            }
        }

        public void runHundredItems()
        {
            Item[] items3 = new Item[100];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                if (random.Next(1, 3) == 1)
                {
                    Console.WriteLine("Enter drink id:");
                    string strNum = Console.ReadLine();
                    int idNum = 0;
                    Int32.TryParse(strNum, out idNum);
                    Console.WriteLine("Choose Drink Color:");
                    string drink_color = Console.ReadLine();
                    items3[i] = new Drink(idNum, drink_color);
                    Console.WriteLine("Choose Drink Name:");
                    string drink_name = Console.ReadLine();
                    items3[i].Name = drink_name;
                    Console.WriteLine("Choose Drink Price:");
                    int drink_price = 0;
                    drink_price = Convert.ToInt32(Console.ReadLine());
                    items3[i].Price = drink_price;
                }
                else
                {
                    Console.WriteLine("Enter food id:");
                    string Id = Console.ReadLine();
                    int id = 0;
                    Int32.TryParse(Id, out id);
                    Console.WriteLine("Choose Food Weight:");
                    string weight = Console.ReadLine();
                    int food_weight = 0;
                    Int32.TryParse(weight, out food_weight);
                    items3[i] = new Food(id, food_weight);
                    Console.WriteLine("Choose Food Name:");
                    string food_name = Console.ReadLine();
                    items3[i].Name = food_name;
                    Console.WriteLine("Choose Food Price:");
                    int food_price = 0;
                    food_price = Convert.ToInt32(Console.ReadLine());
                    items3[i].Price = food_price;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Id: {0}", items3[i].Id);
            }

            //How to check from which class the object was originally created
            for (int i = 0; i < 5; i++)
            {
                if(items3[i] is Drink)
                {
                    Drink drink = (Drink)items3[i];
                    Console.WriteLine("Id: {0} LiquidColor: {1} Name: {2} Price: {3}", drink.Id, drink.LiquidColor, drink.Name, drink.Price);
                }
                else if(items3[i] is Food)
                {
                    Food food = (Food)items3[i];
                    Console.WriteLine("Id: {0} Weight: {1} Name: {2} Price: {3}", food.Id, food.Weight, food.Name,food.Price);
                }
            }

        }
    }
    public class Item
    {
        //var
        private int id; 
        private string name;    
        private int price;
        //Props
        public int Id {
            get  { return id; } 
        }
        public string Name {
            get { return name; }
            set { name = value; } 
        }
        public int Price {
            get { return price; } 
            set { price = value; } 
        }

        //constructor
        public Item(int id)
        {
            this.id = id;
        }



    }
}
