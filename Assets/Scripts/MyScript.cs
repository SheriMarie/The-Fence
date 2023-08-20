//This is C# - C# is an object oriented programming language (OOP)
//C# has specific Dyntax rules you must follow
    //ending a line with a ;
    //enclosing conditions within ()
    //group statements within {}
    //case sensitive - C and c are ot the same 


//Below are bundles of pre-witten code
//keyword "using" tells our script to include a library 
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//this is a class
//collection of variables or methods (functions)
//a blueprint for behaviours 
//classes can inherit variables and methods from each other allowing modulat code (*polymorphism*)
// : indicated inheritance
//MonoBehaviour is the base class for all sripts we want to attach to game objects

public class MyScript : MonoBehaviour
{
    //a variable is a container to store data we can compare, change and copy
    //we have to declare a variable before we an use it
        //public/private - whether the variable can be seen from another script 
        //data type - what kind of data the variable will hold
        //name - what the variable is called 
    [SerializeField] private int myInteger; //integer - a whole number // [SerializeField] means that a private script can be seen and edited in unity only 
    public float myFloat; //float - number with a decimal place
    public string myString; //string - a collection of characters
    public char myChar; //char - a character 

    public Text scoreText;


    //methods let you manipulate variables 
    //you can call methods (run them) from inside other methods 
    //in C# you can define your methods in any order 
    public void MyMethod() 
    {
        myInteger++;    

       // myInteger++; //Increases by 1
       // myInteger--; //Decreases by 1

       // myInteger = myInteger + 1; //Increases by 1
       // myInteger = myInteger - 1; //Decreases by 1

       // myInteger += 1; //Increases by 1
       // myInteger -= 1; //Decreases by 1
    }

    private void Start()
    {
        MyMethod(); 
    }

    private void Update()
    {
        IncreaseMyFloat();
        scoreText.text = "Score: " + myInteger.ToString();
        // this will print as "Score: 1"
    }

    public void IncreaseMyFloat()
    {
        // if (true)
        // { DoTheseThings(); }
        // else
        //{ DoSomethingElse(); }

       if (Input.GetKeyDown("space"))
        {
            myFloat += 2f;
        }
        
        
    }

}
