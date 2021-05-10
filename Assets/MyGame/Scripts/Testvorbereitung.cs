using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testvorbereitung : MonoBehaviour
{
    private bool isTrueExpression = true;

    //Alte Testvorbereitung +
    //If-Statements
    //For-Schleifen
    //Array

    private void Start()
    {
        
    }

    void IfStatements()
    {
        if (isTrueExpression)
        {
            Debug.Log("is True");
        }

        if (isGreatherFive(2, 5))
        {
            Debug.Log("is Greather 5");
        }
    }

    bool isGreatherFive(int a, int b)
    {
        if((a+b) > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    bool a1 = true;
    bool a2 = true;
    bool a3 = true; 

    void PrintBools()
    {
        if (a1 && a2 || a3)
        {
            Debug.Log("a1 && a2 || a3");
        }

        if (a1 && (a2 || a3))
        {
            Debug.Log("a1 && (a2 || a3)");
        }
    }



}
