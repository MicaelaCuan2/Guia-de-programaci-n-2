using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los dos números son iguales");
        }
        else
        {
            if (num1 > num2)
            {
                while (num1 >= num2)
                {
                    Debug.Log(num2);
                    num2++;
                }
            }
            else if (num2 > num1)
            {
                while (num2 >= num1)
                {
                    Debug.Log(num1);
                    num1++;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
