
public class Program
{
    public static void Main(string[] args)
    {
        List<string> studentName = new List<string>() { "Asia", "Austin", "Wendy" };
        List<string> hometowns = new List<string>() { "Lincoln Park", "Akron", "Oxford" };
        List<string> favoriteFoods = new List<string>() { "steak", "tacos", "Italian" };
        List<string> favoriteAnimals = new List<string>() { "cat", "dogs", "anything but rats" };

        while (true)
        {

            int studentId;


            while (true)
            {

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
                Console.WriteLine($"What student would you like to learn more about? Enter a number between 1 and {studentName.Count} .");
                try
                {
                    int studentChoice = int.Parse(Console.ReadLine());

                    if (studentChoice <= 0 || studentChoice > studentName.Count + 1)
                    {
                        Console.WriteLine($"Sorry, that is not a valid.  Please choose a number 1 - {studentName.Count}.");
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
                string newStudentsName;

                Console.WriteLine("Would you like to add another student to the list? Please enter y/n");
                string newInformation = Console.ReadLine().ToLower();
                if (newInformation == "y")
                {
                    Console.WriteLine("Awesome!");
                    while (true)
                    {

                        Console.WriteLine("What student would you like to add to your new list?");
                        newStudentsName = Console.ReadLine().ToLower();
                        if (!string.IsNullOrEmpty(newStudentsName))
                        {
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
                        else
                        {
                            Console.WriteLine("I am sorry I didnt get a vaild response");
                            continue;
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine($"What is {newStudentsName} hometown?");
                        string newStudentsHomeTown = Console.ReadLine().ToLower();
                        if (!string.IsNullOrEmpty(newStudentsHomeTown))
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{newStudentsName} home town is {newStudentsHomeTown}.");
                            Console.WriteLine($"{newStudentsName} home town has been added to the list.");
                            Console.WriteLine();
                            hometowns.Add(newStudentsHomeTown);
                            foreach (var town in hometowns)
                            {
                                Console.WriteLine(town);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I am sorry I didnt get a vaild response");
                            continue;
                        }
                    }

                    Console.WriteLine();

                    while (true)
                    {

                        Console.WriteLine($"What is {newStudentsName} favorite Food?");
                        string newStudentsFavoriteFood = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        if (!string.IsNullOrEmpty(newStudentsFavoriteFood))
                        {
                            Console.WriteLine($"{newStudentsName} favorite Food is {newStudentsFavoriteFood}.");
                            Console.WriteLine($"{newStudentsName} favorite Food been added to the list.");
                            Console.WriteLine();
                            favoriteFoods.Add(newStudentsFavoriteFood);
                            foreach (var food in favoriteFoods)
                            {
                                Console.WriteLine(food);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I am sorry I didnt get a vaild response");
                            continue;
                        }

                        Console.WriteLine();
                        Console.WriteLine($"What is {newStudentsName} favorite animal?");
                        string newSudentsFavoriteAnimal = Console.ReadLine().ToLower();

                        if (!string.IsNullOrEmpty(newSudentsFavoriteAnimal))
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{newStudentsName} favorite animal is {newSudentsFavoriteAnimal}.");
                            Console.WriteLine($"{newStudentsName} favorite animal has been added to the list.");
                            Console.WriteLine();
                            favoriteAnimals.Add(newSudentsFavoriteAnimal);
                            foreach (var animal in favoriteAnimals)
                            {
                                Console.WriteLine(animal);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I am sorry I didnt get a vaild response");
                            continue;
                        }
                    }

                    break;
                }
                else if (newInformation == "n")
                {
                    Console.WriteLine("Thats okay, we already have a list or two to work with!");
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

