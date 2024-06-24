using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which substring do you want to look up?");
        string letter = Console.ReadLine();
        List<string> final = new List<string>();
        string[] fruits =
        {
            "Apple", "Apricot", "Avocado", "Banana", "Blackberry", "Blueberry", "Cherry", "Coconut", "Grapes", "Guava",
            "Kiwi", "Lemon", "Mango", "Orange", "Papaya", "Peach", "Pear", "Pineapple", "Plum", "Raspberry",
            "Strawberry", "Watermelon", "Dragon Fruit", "Passion Fruit", "Lychee", "Fig", "Pomegranate", "Kiwifruit",
            "Cantaloupe", "Honeydew"
        };
        
        for (int i = 0; i < fruits.Length; i++)
        {
            if(fruits[i].ToLower().Contains(letter.ToLower()))
            {
                final.Add(fruits[i]);
            }
        }
        
        for (int i = 0; i < final.Count; i++)
        {
            Console.WriteLine(final[i]);
        }
    }
    }