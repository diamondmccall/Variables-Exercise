namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; // declaration syntax

            dogName = "Jordan";// initalize syntax --- assigning a value

            int dogAge = 5; // declairing and initzaliting

            char firstInital = 'J'; // declairing and initializing

            bool isHungry = true; // declairing and initalizing

            double dogWeight = 9.7; // declairing and initalinzing

            decimal dogHeight = 7.8m; //declairing and initaling


            Console.WriteLine($"My dog's name is {dogName},He is {dogAge} years old. ");
               
            Console.WriteLine ($"He is {dogWeight} pounds and {dogHeight} inches tall.");

            Console.WriteLine($"It is {isHungry} that {firstInital} always seems hungry.");



    
        }
    }
}
