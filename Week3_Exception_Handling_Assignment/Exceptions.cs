using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    //This file contains all the code for the Exceptions used in this program

    //Exception for duplicate names entered
    class DuplicateNameException : Exception
    {
        //Default contructor
        public DuplicateNameException() { }

        //Message constructor
        public DuplicateNameException(string message) : base(message) { }

        //Message and inner exception constructor
        public DuplicateNameException(string message, Exception inner) : base(message, inner) { }        
    }

    //Exception for an invalid score being entered
    class InvalidTestScoreException : Exception
    {
        //Default contructor
        public InvalidTestScoreException() { }

        //Message constructor
        //Also assigns the source of the exception throw
        public InvalidTestScoreException(string message, string source) : base(message) 
        {
            this.Source = source;
        }

        //Message and inner exception constructor
        public InvalidTestScoreException(string message, Exception inner) : base(message, inner) { }
    }

    //Exception for an ivalid name being entered
    class InvalidNameException : Exception
    {
        //Default contructor
        public InvalidNameException() { }

        //Message constructor
        public InvalidNameException(string message) : base(message) { }

        //Message and inner exception constructor
        public InvalidNameException(string message, Exception inner) : base(message, inner) { }
    }
}
