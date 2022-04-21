using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    int counter = 1;
    int counterMax = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (counter <= counterMax)
        {
            Debug.Log(counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
