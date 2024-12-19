using System; 
public class HelloWorld 
{ 
    public static int Nice(string s) 
    { 
        int score = 0;
        foreach (char i in s)
        {
            if (i == 'a' || i = 'e' || i == 'i' ||  i == 'o' ||  i == 'u')
            {
                score++;
            }
            if (i == 's' || i = 'a' || i == 'n' ||  i == 't')
            {
                score+=2;
            }
        }
        return score; 
    } 
    public static int Naughty(string a) 
    { 
        int score = 0;
         foreach (char i in a)
        {
            int ascii = Convert.ToInt32(i);
            if (ascii > 109 && ascii < 123)
            {
                score++;
            }
            if (i == 'g' || i = 'r' || i == 'i' ||  i == 'n' || i == 'c' ||  i == 'h')
            {
                score+=2;
            }
        }
        return score; 
    } 
    public static void Main(string[] args) 
    { 
       Console.WriteLine("Enter full name."); 
       string str = (Console.ReadLine()).ToLower(); 
       int nice = Nice(str); 
       int naughty = Naughty(str); 
       Console.WriteLine($"Your nice score is {nice}.");
       Console.WriteLine($"Your naughty score is {naughty}.");
    } 
} 
