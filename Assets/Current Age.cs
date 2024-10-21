using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableMethod : MonoBehaviour
{

    public void CurrentAge(int age)
    {
        age += 1;
        Debug.Log("Next year my age will be " + age);
    }

    public void Age(int age, int years)
    {
        for (int i = 1; i <= years; i++)
        {
            age += 1;
            Debug.Log("In " + i + " years, my age will be " + age);
        }
    }

    void Start()
    {

        int currentAge = 24;

        int yearsInTheFuture = 10;

        Age(currentAge, yearsInTheFuture);


    }



    // Update is called once per frame
    void Update()
    {

    }
}
