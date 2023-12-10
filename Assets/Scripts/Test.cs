using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int a;
    public int b;
    // Start is called before the first frame update
    void Start()
    {
        int sign = 1;
        if(a < 0 && b > 0 || b < 0 && a > 0)
        {
            sign = -1;
            a = Mathf.Abs(a);
            b = Mathf.Abs(b);
        }
        if(a < 0 && b < 0)
        {
            a = Mathf.Abs(a);
            b = Mathf.Abs(b);
        }

        int summa = 0;
        for(int i = 0; i < b; i++)
        {
            summa += a;
        }
        // 3 * 5 = 15
        // »нтерпол€ци€ строк
        // ѕеременные внутри строки
        print($"{a} * {b} = {summa}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
