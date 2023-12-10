using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
   // public int a;
   // public int b;


    // Start is called before the first frame update
    void Start()
    {
        // int S = 0;

        // Принцип DRY - Dont Repeat Yourself
        // i - index
        // for(счетчик; условие работы; что делать в конце)

       
        /*
        for(int i = k - 10; i < k; i++)
        {
            print(i);
        }

        for(int i = k; i < k + 10; i++)
        {
            print(i);
        }
        */
        
/*
        for(int i = 0; i < k; i++)
        {
            S = S + p / 100.0f * S;
        }
        print(S);  */

        /* for(int i = 1; i < 100; i++)
        {
            int lastDigit = i % 10;
            if(lastDigit != 3)
            {
                S += i;
            }
        }
        print(S); */

 /*       int sing = 1;
        if(a < 0 && b > 0 || b < 0 && a > 0)
        {
            sing = -1; 
            a = Mathf.Abs(a);
            b = Mathf.Abs(b);
        }
        if(a < 0 && b < 0)
        {
            a = Mathf.Abs(a);
            b = Mathf.Abs(b);
        }

        int s = 0;
        for(int i = 0; i < b; i++)
        {
           s += a; 
        }
        if(sing == -1)
        {
            // Интерполяция строк
            print($"Произведение {a} и {b} равно {-s}");
        }
        else
        {
            print($"Произведение {a} и {b} равно {s}");
        }
        
*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
