
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            List<string> studentName = new List<string>() { "Asia", "Austin", "Wendy" };
            List<string> hometowns = new List<string>() { "Lincoln Park", "Akron", "Oxford" };
            List<string> favoriteFoods = new List<string>() { "steak", "tacos", "Italian" };
            List<string> favoriteAnimals = new List<string>() { "cat", "dogs", "anything but rats" };

            int studentId;

            // you can use ex homeTown.Add("persons home town here"); to add to a list
            // you can use ex homeTown[2]"persons home town here"; to okverwrite index with a new value to a list
            // ex string name = PartyAtendees[3]; Like an array this will return the value at index 3

            while (true)
            {

                //   add another student.If they choose to add another student
                //   get the name and each piece of info and add them to the end of the list
                //   Validate input--don’t accept blanks for any of the questions.

                //*************THIS IS FOR BUILD SPECIFICATIONS #3***************

                Console.WriteLine("Would you like to see a list of all students in the class? Please enter y/n");
                string studentList = Console.ReadLine().ToLower();
                if (studentList == "y")
                {
                    Console.WriteLine($"The students we have in our class are:");
                    foreach (var name in studentName)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if (studentList == "n")
                {
                    Console.WriteLine("Not a problem");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I dont understand.");
                }


                Console.WriteLine();
                Console.WriteLine("What student would you like to learn more about? Enter a number 1-3.");
                try
                {
                    int studentChoice = int.Parse(Console.ReadLine());

                    if (studentChoice <= 0 || studentChoice > studentName.Count + 1)
                    {
                        Console.WriteLine("Sorry, that is not a valid.  Please choose a number 1-3.");
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        studentId = studentChoice - 1;
                        break;
                    }
                }
                catch (FormatException e)
                { 
                    Console.WriteLine(e.Message); 
                }

            }

            while (true)
            {
                Console.WriteLine($"You have chosen {studentName[studentId]}. What would you like to know about {studentName[studentId]}? Please enter hometown, favorite food, favorite animal. ");
                string navigationChoice = Console.ReadLine().ToLower().Trim();

                if (navigationChoice.Contains("town"))
                {
                    Console.WriteLine($"{studentName[studentId]} is from {hometowns[studentId]}.");
                    Console.WriteLine();
                    break;
                }
                else if (navigationChoice.Contains("food"))
                {
                    Console.WriteLine($"{studentName[studentId]}'s favorite food is {favoriteFoods[studentId]}.");

                    break;
                }
                else if (navigationChoice.Contains("animal"))
                {
                    Console.WriteLine($"{studentName[studentId]}'s favorite animal is {favoriteAnimals[studentId]}.");

                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I dont understand. Please choose hometown or favorite food.");

                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine("Would you like to add another student to the list? Please enter y/n");
                string newInformation = Console.ReadLine().ToLower();
                // List<string> first = new List<string> { "do", "rey", "me" };
                //List<string> second = new List<string> { "fa", "so", "la", "te" };
                //first.AddRange(second);
                //foreach (var e in first)
                //{
                //    Console.WriteLine(e);
                if (newInformation == "y")
                {
                    Console.WriteLine("Awesome!");
                    Console.WriteLine("What student would you like to add to your new list?");
                    string newStudentsName = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    Console.WriteLine($"You added {newStudentsName} to the list.");
                    Console.WriteLine();
                    studentName.Add(newStudentsName);
                    foreach (var student in studentName)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                }
                else if (newInformation == "n")
                {
                    Console.WriteLine("Thats okay, we already have some list to work with!");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I dont understand. Please choose y/n");
                }

            }

            Console.WriteLine("Would you like to run the program again? Please enter y/n");
            string userContinue = Console.ReadLine().ToLower();

            if (userContinue == "y")
            {
                Console.WriteLine("Awesome!");
                continue;
            }
            else if (userContinue == "n")
            {
                Console.WriteLine("See you next time, Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("I'm sorry, I dont understand. Please choose y/n");
            }
        }
    }
}




//****************Extra Challenges:***********************
//Create the original lists in alphabetical order by student name.
//When a user adds a new student, insert them at the correct location alphabetically.
//Remember to put the information about a particular student at the same index in each list!
