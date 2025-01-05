using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Assigment_1
{

    #region problem 1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Sunday,
        Saturday,

    }
    #endregion

    #region problem 3
    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter,
    //}
    #endregion

    #region problem 4

    //[Flags]
    //enum Permissions
    //{
    //    None = 0,        
    //    Read = 1,        
    //    Write = 2,       
    //    Delete = 4,      
    //    Execute = 8   
    //}

    #endregion

    #region problem 5

    //enum Colors

    //{
    //    red , 
    //    green ,
    //    blue 
    //}
    #endregion

    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1 
            // question is:
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.

            // ------------------------------------------

            //Console.WriteLine("days of week is : ");
            //foreach (string Days in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(Days);
            //}
            #endregion

            #region problem 2
            // question is:
            //Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.Then,
            //write a C# program to display the details of all the persons in the array.

            // ------------------------------------------

            //int age;
            //string name;
            //person[] people = new person [3] ;
            //Console.WriteLine("Please enter Name and Age for 3 person ");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Name of person number {i+1} :");
            //     name = Console.ReadLine();
            //    Console.Write($"Age of person number {i+1} : ");
            //    while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive number for age:");
            //    }

            //    people[i] = new person(name, age);

            //}
            //Console.WriteLine(" details of person is ");
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region problem 3
            // question is:
            /*Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            Write a C# program that takes a season name as input from the user 
            and displays the corresponding month range for that season.
            Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February*/

            // ------------------------------------------

            //string Season_Name; 
            // Console.WriteLine("Please enter Season ");
            //Season_Name = Console.ReadLine();

            //if (Enum.TryParse(Season_Name, true, out Season season) && Enum.IsDefined(typeof(Season), season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine($"Spring months: March, April, May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine($"Summer months: June, July, August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine($"Autumn months: September, October, November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine($"Winter months: December, January, February");
            //            break;
            //    }
            //}
            //else

            //    Console.WriteLine("Invalid season. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            #endregion

            #region problem 4  
            // question is:
            /*Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            Create Variable from previous Enum to Add and Remove Permission from variable,
            check if specific Permission is existed inside variable*/

            // ------------------------------------------

            //Permissions perm = Permissions.Write;

            //Console.WriteLine($"Current Permissions: {perm}");

            //perm |= Permissions.Read;

            //Console.WriteLine($"Current Permissions: {perm}");

            //perm &= ~Permissions.Write;

            //Console.WriteLine($"Current Permissions after removing Write: : {perm}");

            //if (perm == Permissions.Execute)

            //    Console.WriteLine("Permission Execute is exist");

            //else

            //    Console.WriteLine("Permission Execute is Not exist");

            //perm |= Permissions.Execute;
            //Console.WriteLine($"Current Permissions after adding Execute: : {perm}");
            //Console.WriteLine("Permission Execute is exist");
            #endregion

            #region problem 5
            // question is:
            /*
             5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
             Write a C# program that takes a color name as input from the user 
             and displays a message indicating whether the input color is a primary color or not. */

            // ------------------------------------------

            //Console.WriteLine("Please Enter Color");
            //string color_name = Console.ReadLine();

            //if (Enum.TryParse(color_name, true, out Colors color))
            //{
            //    Console.WriteLine($"The color {color_name} is a primary color");
            //}
            //else
            //    Console.WriteLine($"The color {color_name} is not a primary color");
            #endregion

            #region problem 6
            //// question is:
            ///*Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
            //Write a C# program that takes two points as input from the user and calculates the distance between them.*/

            // ------------------------------------------

            //bool flag;
            //double x1, y1, x2, y2;
            //Console.WriteLine("Please Entre 2 points to calculates the distance between them ");
            //Console.WriteLine("Input point 1:");
            //do
            //{

            //    Console.WriteLine("point 1 x is :");
            //    flag = double.TryParse(Console.ReadLine(), out x1);
            //    if (!flag)
            //        Console.WriteLine("Please enter a valid point.");

            //} while (!flag);

            //do
            //{

            //    Console.WriteLine("point 1 y is :");
            //    flag = double.TryParse(Console.ReadLine(), out y1);
            //    if (!flag)
            //        Console.WriteLine("Please enter a valid point.");
            //} while (!flag);

            //Console.WriteLine("Input point 2:");

            //do
            //{
            //    Console.WriteLine("point 2 x is :");
            //    flag = double.TryParse(Console.ReadLine(), out x2);
            //    if (!flag)
            //        Console.WriteLine("Please enter a valid point.");
            //} while (!flag);

            //do
            //{
            //    Console.WriteLine("point 2 y is :");
            //    flag = double.TryParse(Console.ReadLine(), out y2);

            //} while (!flag);

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = Point.CalculateDistance(point1, point2);

            //Console.WriteLine($"The distance between {point1} and {point2} is : {distance}");
            #endregion

            #region Propblem 7
            //// question is:
            /* 7. Create a struct called "Person" with properties "Name" and "Age".
            /Write a C# program that takes details of 3 persons as input from the user 
            and displays the name and age of the Oldest person. */

            //---------------------------------------------------------------
            //int age;
            //string name;
            //Oldest_person[] people = new Oldest_person[3];
            //Console.WriteLine("Please enter Name and Age for 3 person ");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Name of person number {i + 1} :");
            //    name = Console.ReadLine();
            //    Console.Write($"Age of person number {i + 1} : ");
            //    while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive number for age:");
            //    }

            //    people[i] = new Oldest_person(name, age);

            //}
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"\n{person}");
            //}

            //int maxAge = int.MinValue;
            //string OldestPerson = "";

            //foreach (var person in people)
            //{
            //    if (person.age > maxAge)
            //    {
            //        maxAge = person.age; 
            //        OldestPerson = person.name; 
            //    }
            //}

            //Console.WriteLine($"\nThe oldest person is {OldestPerson} with age is {maxAge}");
            #endregion
        }
    }
}
