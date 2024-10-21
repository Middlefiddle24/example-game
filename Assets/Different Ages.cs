using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySecondVariableMethod : MonoBehaviour
{
    public void CurrentAge(int age, int[] yearsAdded)
    {
        foreach (int years in yearsAdded)
        {
            int futureAge = age + years; 
            Debug.Log("In " + years + " years, my age will be " + futureAge);
        }
    }

    void Start()
    {
        int initialAge = 24; 

        int[] yearsAddedToCheck = { 2, 10, 35, 100 };

        CurrentAge(initialAge, yearsAddedToCheck);
    }
}
