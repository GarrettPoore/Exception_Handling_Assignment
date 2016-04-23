using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    //This is a class to store the first, middle, and last names along with the test, quiz and final test scores
    public class Student
    {
        //Private variables
        private string firstName; //Accessed by FirstName
        private string middleName; //Accessed by MiddleName
        private string lastName; //Accessed by LastName

        private double testScore; //Accessed by TestScore
        private double quizScore; //Accessed by QuizScore
        private double finalTestScore; //Accessed by FinalTestScore

        //Public get/set methods
        public string FirstName {
            get { return firstName; }
            set { firstName = value; } }

        public string MiddleName {
            get { return middleName; }
            set { middleName = value; } }

        public string LastName {
            get { return lastName; }
            set { lastName = value; } }

        public double TestScore {
            get { return testScore; }
            set { testScore = value; } }

        public double QuizScore {
            get { return quizScore; }
            set { quizScore = value; } }

        public double FinalTestScore {
            get { return finalTestScore; }
            set { finalTestScore = value; } }
        

        //Appends the first, middle, and last names together
        public string FullName  
        {
            get 
            {
                //Check for a middle name
                if (middleName == "")
                {
                    //Format for no middle name
                    return firstName + " " + lastName;
                }
                else
                {
                    //Format with a middle name
                    return firstName + " " + middleName + " " + lastName;
                } 
            } 
        }

        //Finds the average score of all three scores
        public double AverageScore {
            get { return Math.Round((testScore + quizScore + finalTestScore) / 3, 2); } }
        
        
        //Overriden ToString method
        public override string ToString()
        {
            //Output for the list item
            return FullName + " has a Test Score of " + testScore + ", a Quiz Score of " + 
                quizScore + ", a Final Test Score of " + finalTestScore + 
                ", and an average score of " + AverageScore + ".";            
        }

        //Constructor - assigns all variables
        public Student(string fName, string mName, string lName, double tScore, 
            double qScore, double fTestScore)
        {
            firstName = fName;
            middleName = mName;
            lastName = lName;

            testScore = tScore;
            quizScore = qScore;
            finalTestScore = fTestScore;
        }

        //Default Constructor
        public Student() { }
    }
}
