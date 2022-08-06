namespace stringbasics
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "Giraffe Academy";


            Console.WriteLine(phrase.ToUpper());
            //use \n to print out the phrase onto the next line
            Console.WriteLine("This is how to print something out on\nthe next line");

            Console.WriteLine(phrase.Contains("e")); //returns a true or false;

            Console.WriteLine(phrase[3]); //always starts at 0 Zero

            Console.WriteLine(phrase.IndexOf("Academy"));

            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 3));

            Console.ReadLine();
        }

       
    }
}