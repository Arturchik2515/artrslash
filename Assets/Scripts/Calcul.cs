using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcul : MonoBehaviour
{
    //public float a;
    //public float b;
    //public char sign; // +-*/


    // Start is called before the first frame update
    void Start()
    {
 /*       if(sign == '+')
        {
            Plus();
        }
        else if(sign == '-')
        {
            Min();
        }
        else if(sign == '/')
        {
           Delen();
        }
        else if(sign == '*')
        {
            Ymnozh();
        }
        else
        {
           print("Неправильный ввод действий");
        }
*/

       /* float width = 13;
        float length = 15; */

        // GetPerimetr()

        float width = 13;
        float length = 15;
       // GetPerimetr()
        GetS(width, length);
    }

    private void GetS(float n1, float n2)
    {
        float s = n1 * n2;
        print($"s = {s}");
    }


   /* private void GetPerimetr(float n1, float n2)
    {
        float p = (n1 + n2) * 2;
        print($"p = {p}")
    }

    // доступ тип Название (аргументы) {тело}
    private void Plus()
    {
        float result = a + b;
        print($"{a} + {b} = {result}");
    }

    private void Min()
    {
        float result = a - b;
        print($"{a} - {b} = {result}");
    }

    private void Delen()
    {
        float result = a / b;
        print($"{a} / {b} = {result}");
    }

    private void Ymnozh()
    {
        float result = a * b;
        print($"{a} * {b} = {result}");
    }
*/



    // Update is called once per frame
    void Update()
    {
        
    }
}
