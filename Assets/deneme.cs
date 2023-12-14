using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    private void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            string text = $"{i} sayisina tam bolunenler : ";
            foreach (var item in Numbers(22, 50, i))
            {
                text += item.ToString();
                text += " - ";
            }
            print(text);
            
        }
    }

    List<int> Numbers(int number1,int number2,int divisor)
    {
        List<int> list = new List<int>();
        for (int j = number1; j <= number2; j++)
        {
            if (j % divisor == 0)
            {
                list.Add(j);
            }
        }
        return list;
    }
}
