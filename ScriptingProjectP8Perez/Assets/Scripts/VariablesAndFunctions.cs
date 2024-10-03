using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{   //Create A variable of type integer
    int myInt = 18;



    // Start is called before the first frame update
    void Start()
    {
        //I am going to run my int through my function to multiply it by two
        myInt = MultiplyingByTwo(myInt);
        //im going to print the results to thje console
        Debug.Log(myInt);

    }
    // Update is called once per frame
    void Update()

    {

    }


    //Creating a function that takes a int parameter and multiplies it by 2
    int MultiplyingByTwo(int number)

    {
        //creating a variable to store my results
        int results;
        //multiplying the pases parameter by 2
        results = number * 2;

        //returning the results
        return results;
    }

}