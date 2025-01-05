using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1_OOP
{
    internal struct point
    {
        // Attribute = variable
         //public int x;
         //public int y;

        // constructor > is a special methods/function
        // الصفات المميزه فيه 
        // 1- اسمو دايما لازم يكون نفس اسم الكلاس او الاستركت
        // 1- has no return مش بيرجع حاجه

        //!! 0 اللي فوق دول هما x , y بتاع ال default value  مش ال
        //لا يصحبي مليش فيه هو مبيعترفش ب كده لازم اقول كده بنفسي

        //public point /*نقس اسم كلاس الاستراكت*/ () // parameterless دا كده
        //{
        //    x = 0;
        //    y = 0;
        //}
        // دا لو معملتوش بيتعمل لوحده ف الخلفيه علي طول وبيفضل موجود ولو مسحتة بيفضل موجود برضو

        // هو لازم اخد قيمتهم من هنا انا عايز اخدهو من برا
        //public point (int _x, int _y) // معناها اني هاخدها من برا (_) 
        //{
        //    x = _x; //اللي هي هنا دي x = اللي هاخدها من برا _x 
        //    y = _y; //اللي هي هنا دي y = اللي هاخدها من برا _y 
        //}

        //public override string ToString()
        //{
        //    return $"x is = {x} , y is = {y}";
        //}
    }


}
