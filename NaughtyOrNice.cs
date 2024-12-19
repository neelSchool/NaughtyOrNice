using System; 
public class HelloWorld 
{ 
    public static int Nice(string s) 
    { 
        return 0; 
    } 
    public static int Naughty(string s) 
    { 
        return 0; 
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
