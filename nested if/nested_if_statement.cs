using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nested_if
{
    class nested_if_statement
    {
        public void nested_if_method()
    {

          
    /* local variable definition */
         int a1 = 100;
         int b = 200;
         
         /* check the boolean condition */
         if (a1 == 100)
         {
            /* if condition is true then check the following */
            if (b == 200)
            {
               /* if condition is true then print the following */
               Console.WriteLine("Value of a is 100 and b is 200");
            }
         }
         Console.WriteLine("Exact value of a is : {0}", a1);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();

            //nested if
            int first = 7, second = -23, third = 13;
			if (first > second)
			{
				if (first > third)
				{
					Console.WriteLine("{0} is the largest", first);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
			}
			else
			{
				if (second > third)
				{
					Console.WriteLine("{0} is the largest", second);
				}
				else
				{
					Console.WriteLine("{0} is the largest", third);
				}
}
    }
    }