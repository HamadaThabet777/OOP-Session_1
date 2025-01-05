using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1_OOP
{
    internal class Employee
    {
        // Attribute 

        //public int id;
        //public string Name;
        //public int salary;

        //--------------------------------------
        //اخد منو الداتا من برا constructor هعمل
        //public Employee(int _id, string _Name, int _salary)//_ بدي البارامتار بتاع الكونستراكتور ب ال
        //{
        //    id = _id; //  اللي جي من برا اساويه ب اللي عندي_id ال
        //    Name = _Name;//اللي جي من برا اساويه ب اللي عندي_name ال
        //    salary = _salary;//  اللي جي من برا اساويه ب اللي عندي_salary ال

        //}

        //--------------------------------------
        //عشان اطبع to string ع ال override هروح بقا اعمل  
        //public override string ToString()
        //{
        //    return $"Id is {id} , name is {Name} , Salary is {salary}";

        //    //main هرجع بقا لل
        //}

        //--------------------------------------

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


        // 1- getter , setter من خلال ال  name هشتغل ع ال

        // getter 

        //public string GetName() //عشان استخدمها برا public لازم تكون

        //{
        //    return Name;//هترجعلي الاسم 
        //}

        //setter
        //public void SetName(string value)
        //{
        //    Name = value; //اللي اليوزر هيدخلها value اللي عندي هيكون بياخد قيمه الname  بقوله ان ال
        //}

        // اللي هو الكلاس definition لو جيت بقا عدلت ف اي حاجه الايرور هيظهر ف مكن ال
        // مش هيظهر عندي هنا ودي فايده الجيتر والسيتر

        // -------------------------------------------------
        // 2- Property من خلال salary هشتغل ع ال 
        //Property عندي كذا نوع م ال

        // 1- full Property
        // 2- Automatic Property

        // 
        //  1- full Property
        //Property من خلال ال attribute=variable  هكلم ال
        //private يكون attribute بس شرط ال 
        //public يكون Property بس شرط ال 
        //يكونو بنفس الاسم والداتا تايب Propertyوال attribute وشرط ان ال
        //attribute ..> small يكون حرف 
        //Property ..>  يكون حرف كابيتال

        //تاني عشان مش عايز اعدل علي اللي فوق attribute هعمل 
        //private int iid;
        //private string nnme;
        //private int ssalary;

        //public int SSalary
        //{
        //   get 
        //   { 
        //     return ssalary; // هنا اسم الاترتبيوت اللي بحروف سمول
        //    }

        //    set

        //    {

        //        ssalary = value; /* >= 4000 ? value : 4000;// control data validation */
        //        //  بقوله لو هيعدل ويخلي السالري اكبر من اربع الاف خدو من مش كده ثبت السالري ع اربعه زي ماهو


        //    }
        //    //set > private طب لو انا مش عايز حد يعدل ع السالري بتاعي هخلي ال

        //}

        // عندي اختصار ممكن يلم كل الهري دا اكتب 
        //tab وادوس profull < اختار full 

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //-----------------------
        //Automatic Property بيقولك لو هعمل جت وست منغير متحط اي فاليديشن عليها استخدم ال
        //public int age;

        //بتعتو property  مش شرط اعرف فاريبال انا هعرفو جوا ال

       // public int age { get; set; }

        // عندي اختصار ممكن يلم كل الهري دا اكتب 
        //tab وادوس prop 
        //public int MyProperty { get; set; }







    }




    #endregion
}


