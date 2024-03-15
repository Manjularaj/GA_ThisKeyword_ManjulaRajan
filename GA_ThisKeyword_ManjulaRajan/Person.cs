using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ThisKeyword_ManjulaRajan
{
    public class Person
    {

        // Fields
        private string name;
        private int age;

        // Constructor that uses 'this' to distinguish fields from parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;


        }

        // Method to display the person's details
        public void Display()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        //Existing code...

    // Overloaded constructor
    public Person(string name) : this(name, 0) // Calls the main constructor
        {


        }

        // Existing code...

    // Method to update the person's age(previously it was given age 0)
    public void SetAge(int age)
        {
            this.age = age; // 'this' clarifies that we're assigning to the instance field
        }



        //use of this in constructors and methods.
        //Answer:The this keyword is used to differentiate between the parameters name and age and the fields name and age of the class.
        //this.name = name;: This line assigns the value of the name parameter to the name field of the class. Without this, the assignment would only update the parameter name within the constructor scope, leaving the field name uninitialized.

        //Using this. in Display method and SetAge method:
        // Answer:Use of 'this' clarifies that we're assigning to the instance field: This comment explains that this is used in the SetAge method to explicitly refer to the instance field age. While not strictly necessary in this context, using this can make the code more readable and can help avoid potential confusion, especially when the parameter name (age) is the same as the field name. This ensures that it's clear to the reader that the assignment is to the instance field age.And Use of 'this' to access the fields within the class: This comment explains that this is used in the Display method to access the fields name and age within the class.


    }//class
}
