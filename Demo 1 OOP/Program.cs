using System;
using System.Threading;
namespace Demo_1_OOP
{

    //namespace اي اللي مسموح اكتبو جوا ال
    // class
    // Struct( stands for structure >> from C 
    // interface
    // Enum
    //--------------------------------------
    //namespace اللي مسموح اكتبها جواال Access modifier اي هي ال
    // 1- internal >> default Access modifier
    // 2- public

    #region Enum
    //class , struct , interface زيو زي ال namespase  بيتكتب جوا ال 
    //value type من نوع data type  دي 
    // بعملها لما يكون عندي حاجات ثابته مفيش حاجه غيرها 
    //انا معنديش اختيار غير دول male , female  زي مثلا 


    //enum/* اديله اسم*/ Grade
    //{
    //    // label << دول اسمهم
    //// default value for 0 index
    ////  0   1    2   3   4
    //    A , B , C , D , F
    //}// انا ممكن اغير الترتيب عادي هحطو ب ايدي وهو هيبدا عد من بعدو
    //#endregion
    //enum Gander
    //{
    //    Male=1 , Female=2 , M=2 , F=1
    //    //هما كده نفس الحاجه Maleاو M معني اللي عملتو ان لو اختار 
    //    //هما كده نفس الحاجه Female F معني اللي عملتو ان لو اختار 
    //}
    //enum DayOfWeek
    //{
    //    Saturday = 1 ,
    //    Sunday ,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday ,

    //}

    //[Flags]
    //enum DayOfWeek
    // {
    //None = 0,
    //Sunday = 1,
    //Monday = 2,
    //Tuesday = 4,
    //Wednesday = 8,
    //Thursday = 16,
    //Friday = 32,
    //Saturday = 64
    // }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region definition 
            //Class or Struct  اي اللي مسموح اكتبو جوا ال 
            // 1- Attribute = filed = variable
            // 2- property (full property - Automatic property - indexer)
            // 3- functions ( constructor _ getter/setter - method )
            // 4- Event
            //--------------------------------------
            //struct و class الفرق بين ال

            // 1- struct
            // heap مش stack عني يتم تخزين البيانات فيه في Value Type، دا من نوع 
            // Inheritance مش بيدعم 

            // 2- class
            // stack مش heap عني يتم تخزين البيانات فيه في Value Type، دا من نوع 
            // Inheritance,Polymorphism بيدعم 

            //--------------------------------------
            // struct اللي مسموح اكتبها جواال Access modifier اي هي ال
            //  private >> default Access modifier

            // 1- private >>يعني لو في ستراكت تاني ميشوفش الحاجات دي struct مش همتشاف خارج حدود ال
            // 2- internal >>  متشاف داخل حدود البروجكت دا بس اي بروجكت تاني مش هيشةفه
            // 3- public >> يمكن الوصول إليه من أي مكان.
            //--------------------------------------
            // Class اللي مسموح اكتبها جواال Access modifier اي هي ال
            //  private >> default Access modifier

            // 1- private >>يعني لو في كلاس تاني ميشوفش الحاجات دي Class مش همتشاف خارج حدود ال
            // 2- private Protected >> مكن الوصول إليه فقط داخل نفس الكلاس أو الكلاسات المشتقة منه.
            // 3- Protected >>مزيج من الاثنين، يمكن الوصول إليه فقط داخل نفس الكلاس أو الكلاسات المشتقة الموجودة في نفس الملف   
            // 4- internal >> متشاف داخل حدود البروجكت دا بس اي بروجكت تاني مش هيشوفه
            // 5- internal Protected >>Inheritance  يمكن الوصول إليه داخل نفس الملف او من خلال ال
            // 6- public >> يمكن الوصول إليه من أي مكان.
            //-----------------------------------------------
            //interface اي اللي مسموح اكتبو جوا ال 
            // 1- signature for property
            // 2- signature for methods
            // 3- default implemented methods

            // -------------
            // interface اللي مسموح اكتبها جواال Access modifier اي هي ال
            // public >> default Access modifier

            //--------------------------------------
            // Encapsulation اللي مسموح اكتبها جواال Access modifier اي هي ال
            // 1- private >>يعني لو في كلاس تاني ميشوفش الحاجات دي calss مش همتشاف خارج حدود ال
            // 2- internal >>  متشاف داخل حدود البروجكت دا بس اي بروجكت تاني مش هيشوفه
            // 3- public >> يمكن الوصول إليه من أي مكان.
            // 4- Protected >>مزيج من الاثنين، يمكن الوصول إليه فقط داخل نفس الكلاس أو الكلاسات المشتقة الموجودة في نفس الملف   


            #endregion

            #region Enum
            //class , struct , interface زيو زي ال namespase  بيتكتب جوا ال 
            //value type من نوع data type  دي 
            // بعملها لما يكون عندي حاجات ثابته مفيش حاجه غيرها 
            //انا معنديش اختيار غير دول male , female  زي مثلا 

            //Grade grade = Grade.A;
            ////A وقولتله عايز الدرجه اللي اسمها grade واديته اسم Gradeاللي لسا معرفة فوق enum نديت ع ال
            //if (grade == Grade.A)
            //{
            //    Console.WriteLine(" congratulate A+");
            //}
            //else
            //{
            //    Console.WriteLine("sorry");
            //}

            //------------------------------------------------------------
            //------------------------------------------------------------

            //Console.WriteLine("Enter the day of the week ():");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true ,out DayOfWeek userDay)) //عشان اخلي ميفرقش معايا مدخل كابتال ولا سمول true حطيت 
            //{
            //    Console.WriteLine($"You entered: {userDay}");
            //    Console.WriteLine($"num of this Day is: {(int)userDay}");
            //}
            //else
            //    Console.WriteLine("Invalid input!");

            //if (userDay == DayOfWeek.Friday || userDay == DayOfWeek.Saturday )
            //{
            //    Console.WriteLine($"{userDay} is a weekend! 🎉");
            //}
            //else
            //{

            //}
            //    Console.WriteLine($"{userDay} is a weekday. Keep working! 💻");

            //--------------------
            //عشان اطبع كل ايام الاسبوع دي هعمل اي 
            //Console.WriteLine($"Days of week is :");
            //foreach (string days in Enum.GetNames(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine($"{days} ");
            //}
            //------------------------------------------------------------
            //------------------------------------------------------------
            //flag  عشان انا اعرض بقا ان الويك اند جمعه وسبت هحتاج اعمل حاجه مهمه باستدخدام 
            // هحط الكود دا فوق 
            //[Flags]
            //enum DayOfWeek
            // {
            //None = 0,
            //Sunday = 1,
            //Monday = 2,
            //Tuesday = 4,
            //Wednesday = 8,
            //Thursday = 16,
            //Friday = 32,
            //Saturday = 64
            // }
            //DayOfWeek weekend = DayOfWeek.Saturday | DayOfWeek.Saturday;
            //Console.WriteLine($"week end is {weekend}");
            //// ساعتها دول هيشتغلو

            #endregion

            #region Struct
            //point هشتغل ع كلاس ال 

            //stack يتم تخزينه في stack value type دا نوعه
            // attribute = variable , constructor , methods , properties , event
            //عندي نوعين منه 
            // built in >> int , float , double , decimal , data , datetime والحاجات دي
            // user define انا اللي بعملة ب ايدي
            //عشان اكريت ستراكت مش موجود عندي انا بعمل كلاس عادب واششيل كيمه كلاس واعملها ستراكت

            //point p1 = new point();// parameterless

            //جديد هي هنا بتخليني احدد هشتفل ف اني كونتسراكتور object هنا مش بتعمل  new
            //point من نوع  object direct form struct  كده انا عملت
            //4 to x , 4 to y < 8 byte < stack هحجز ف ال
            // عشان اشتغل لاوم اكون محدد انا هشتفل ف اني كونتسراكتور
            //Console.WriteLine($"x is {p1.x} ");//0
            //Console.WriteLine($"y is {p1.y} ");//0

            //// طب هاخد داتا بقا
            //point p2 = new point(4 , 2 );
            //Console.WriteLine($"x is {p2.x} ");//0
            //Console.WriteLine($"y is {p2.y} ");//0
            ////الاه دا برضو طلعلي 0و0 امال فين 4و2 دول
            ////جوا ةاعرف فيها شكل الطباعه override  لازم اكون عامل
            //Console.WriteLine(p2);
            #endregion

            #region Encapsulation
            //الاول واجي هنا تاني employee هشتغل ع كلاس ال

            // لو هدخب ب ايدي
            //Employee emp = new Employee(10 , "Hamada" , 200000);
            //Console.WriteLine(emp);

            ////لو هاخد داتا م اليوزر
            //int id, salary;
            //string name;
            //Console.WriteLine("please enter ID");
            //while (!int.TryParse(Console.ReadLine(), out id))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid numeric ID:");

            //}

            //Console.WriteLine("please enter Name");
            //name = Console.ReadLine();

            //Console.WriteLine("please enter Salary ");
            //while (!int.TryParse(Console.ReadLine(), out salary))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid numeric salary:");
            //}
            //Employee emp = new Employee(id, name, salary );
            //Console.WriteLine("Employee Details:");
            //Console.WriteLine(emp);

            //--------------------------------------------------------
            //mainطب يعم لو انا عايو اغير حاجه معينه هروح بقا اغير المسميات دي ملها جوا الكلاس وف الكونستراكتور وف الاتربيوت وف ال
            //Encapsulation كده كده حوار عشان كده انا هستخدم ال

            #region Encapsulation
            //إخفاء التفاصيل الداخلية للكلاس ومنع الوصول المباشر إلى بياناته من الخارج
            // sperate data definition (attribute) from it's ues 
            //main عن استخدامها برا ف ال employee هفصل تعريف الداتا اللي عندي ف كلاس ال 


            //  نستخدمه عشان ؟
            //1- حماية البيانات
            //2- التعديل غير المقصود أو الخاطئ للبيانات

            // Encapsulation اللي مسموح اكتبها جواال Access modifier اي هي ال
            // 1- private >>يعني لو في كلاس تاني ميشوفش الحاجات دي calss مش همتشاف خارج حدود ال
            // 2- internal >>  متشاف داخل حدود البروجكت دا بس اي بروجكت تاني مش هيشوفه
            // 3- public >> يمكن الوصول إليه من أي مكان.
            // 4- Protected >>مزيج من الاثنين، يمكن الوصول إليه فقط داخل نفس الكلاس أو الكلاسات المشتقة الموجودة في نفس الملف   

            // عشان اقدر اتحكم فيه عندي 3 طرق من خلال
            // 1- getter بعرض من خلالها/ setter  دي بعدل ف قيمه من خلالها
            // 2- Properties =Property 
            // 3- indexer


            // لو هدخب ب ايدي
            //Employee emp = new Employee(10, "Hamada", 200000);
            //Console.WriteLine(emp);

            ////انا هعدل الاسم اللي عندي
            ////بعدل من خلالها الاسم set name انا عندي فنكشن اسمها
            //emp.SetName("omar");
            //    Console.WriteLine(emp.GetName());
            ////اللي بتعرضلي الاسم getname هنادي عليها من خلال الفنكش اللي اسمها
            //Console.WriteLine(emp);

            // اللي هو الكلاسdefenition  لو جيت بقا عدلت ف اي حاجه الايرور هيظهر ف مكن ال
            // مش هيظهر عندي هنا ودي فايده الجيتر والسيتر

            //-------------------------------------------------------

            // property 
            //Employee emp = new Employee(10, "Hamada", 200000);
            //Console.WriteLine(emp);

            ////انا هعدل الاسم اللي عندي
            ////بعدل من خلالها الاسم set name انا عندي فنكشن اسمها
            //emp.SSalary = 3000; // property بنادي عليها من خلال اسم ال // Set
            //Console.WriteLine(emp.SSalary); // Get
                                            //اللي بتعرضلي الاسم getname هنادي عليها من خلال الفنكش اللي اسمها

            //set > private طب لو انا مش عايز حد يعدل ع السالري بتاعي هخلي ال

            // emp.age = 22;
            //Console.WriteLine($"The person's age is: {emp.age}");




            #endregion

            #endregion


        }
    }
}
