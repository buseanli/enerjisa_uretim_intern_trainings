using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("How many stars do you want?");
        var stars = Console.ReadLine();
        int starsint = int.Parse(stars);
        StringBuilder spaces= new StringBuilder();
        StringBuilder star = new StringBuilder();
        // Loop for increasing sequence
        for (int i = 0; i < starsint; i++)
        {
            star.Append("*");
            Console.WriteLine("{0}",star);
        }
        // Loop for decreasing sequence
        for (int i = starsint; i > 0; i--)
        {
            StringBuilder starremoval = star;
            Console.WriteLine("{0}",starremoval);
            starremoval.Remove(i-1, 1);
            spaces.Append(" ");
        }
        // Loop for increasing stars mirrored
        for (int i = 0; i < starsint; i++)
        {
            star.Append("*");
            spaces.Remove(starsint-i-1,1);
            Console.WriteLine("{0}{1}",spaces, star);
        }
        // Loop for decreasing stars mirrored
        for (int i = 0; i < starsint; i++)
        {
            Console.WriteLine("{0}{1}",spaces, star);
            spaces.Append(" ");
            star.Remove(starsint-i-1,1);
            
        }
    }
}