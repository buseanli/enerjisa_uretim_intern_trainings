using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which letter do you want to search?");
        string letter = Console.ReadLine();
        List<string> final = new List<string>();
        string[] fruits =
        {
            "Apple", "Apricot", "Avocado", "Banana", "Blackberry", "Blueberry", "Cherry", "Coconut", "Grapes", "Guava",
            "Kiwi", "Lemon", "Mango", "Orange", "Papaya", "Peach", "Pear", "Pineapple", "Plum", "Raspberry",
            "Strawberry", "Watermelon", "Dragon Fruit", "Passion Fruit", "Lychee", "Fig", "Pomegranate", "Kiwifruit",
            "Cantaloupe", "Honeydew"
        };
        
        for (int i = 0; i < fruits.Length -1; i++)
        {
            fruits[i] = fruits[i].ToLower();
        }
        for (int i = 0; i < fruits.Length -1; i++)
        {
            if(fruits[i].Contains(letter.ToLower()))
            {
                final.Add(fruits[i]);
            }
        }
        
        for (int i = 0; i < final.Count -1; i++)
        {
            Console.WriteLine(final[i]);
        }
    }
    }