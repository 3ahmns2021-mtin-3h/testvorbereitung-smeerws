using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testvorbereitung : MonoBehaviour
{
    private bool isTrueExpression = true;
    public GameObject[] myGOs;

    //Alte Testvorbereitung +
    //If-Statements
    //For-Schleifen
    //Array

    private void Start()
    {
        //PrintBools();
        //Fors();
        Arrays();

        for(int i = 0; i< myGOs.Length; i++)
        {
            myGOs[i].gameObject.transform.position = new Vector3(3f, 3f, 3f);
        }
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

    bool a1 = false;
    bool a2 = true;
    bool a3 = true; 

    void PrintBools()
    {
        if (a1 || a2 && a3)
        {
            Debug.Log("a1 && a2 || a3");
        }

        if (a1 || (a2 && a3))
        {
            Debug.Log("a1 && (a2 || a3)");
        }
    }

    void Fors()
    {
        for(int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }

        }

        for (int i = 20; i >= 0 ; i--)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }

        }
    }

    void Arrays()
    {
        int[] x = new int[7];

        for(int i = 0; i < x.Length; i++)
        {
            x[i] = 5;
        }

        PrintMyArray(x);
    }

    void PrintMyArray(int[] y)
    {
        for(int i = 0; i < y.Length; i++)
        {
            Debug.Log(y[i]);
        }
    }

}
