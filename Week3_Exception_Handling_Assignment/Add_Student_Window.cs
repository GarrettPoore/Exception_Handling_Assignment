using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_Handling_Assignment
{
    public partial class Add_Student_Window : Form
    {
        //Variable to contain the new student object
        //Public so that the main window can obtain it
        public Student newStudent { get; set; }

        //Initialize the form
        public Add_Student_Window()
        {
            InitializeComponent();
        }

        //Event handler for the add student button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Variables that will hold scores
            double testScore;
            double quizScore;
            double finalTestScore;
            
            //Try to catch exceptions
            try
            {
                //Test the Test Score for a double
                if (double.TryParse(txtTestScore.Text, out testScore))
                {
                    //Test to see if the score is between 100 and 0
                    if (!(testScore <= 100.0 && testScore >= 0.0))
                    {
                        //Throw an exception if it is not between 100 and 0
                        throw new InvalidTestScoreException("The number entered for" +
                        "Test Score is not within the allowed range (0 - 100).", "txtTestScore");
                    }
                }

                else
                {
                    //Failure throws the following exception
                    throw new InvalidTestScoreException("The number entered for " +
                        "Test Score is invalid.", "txtTestScore");
                }

                //Test the Quiz Score for a double
                if (double.TryParse(txtQuizScore.Text, out quizScore))
                {
                    //Test to see if the score is between 100 and 0
                    if (!(quizScore <= 100.0 && quizScore >= 0.0))
                    {
                        //Throw an exception if it is not between 100 and 0
                        throw new InvalidTestScoreException("The number entered for" +
                        "Quiz Score is not within the allowed range (0 - 100).", "txtQuizScore");
                    }
                }

                else
                {
                    //Failure throws the following exception
                    throw new InvalidTestScoreException("The number entered for " +
                        "Quiz Score is invalid.", "txtQuizScore");
                }

                //Test the Final Test Score for a double
                if (double.TryParse(txtFinalTestScore.Text, out finalTestScore))
                {
                    //Test to see if the score is between 100 and 0
                    if (!(finalTestScore <= 100.0 && finalTestScore >= 0.0))
                    {
                        //Throw an exception if it is not between 100 and 0
                        throw new InvalidTestScoreException("The number entered for" +
                        "Final Test Score is not within the allowed range (0 - 100).", "txtFinalTestScore");
                    }
                }

                else
                {
                    //Failure throws the following exception
                    throw new InvalidTestScoreException("The number entered for " +
                        "Final Test Score is invalid.", "txtFinalTestScore");
                }

                //Assign the names
                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;

                //Call method to add a new student object
                Student student = new Student(firstName.Trim(), middleName.Trim(), lastName.Trim(),
                    testScore, quizScore, finalTestScore);

                //Set the global variable to the new object
                newStudent = student;

                //Set the dialog result to OK
                this.DialogResult = DialogResult.OK;

                //Close the dialog box
                this.Close();
            }

            //Catch the invalid test scores
            catch (InvalidTestScoreException ex)
            {
                //Find which text box threw the exception and clear it
                switch (ex.Source)
                {
                    case "txtTestScore":
                        txtTestScore.Text = "";
                        break;

                    case "txtQuizScore":
                        txtQuizScore.Text = "";
                        break;

                    case "txtFinalTestScore":
                        txtFinalTestScore.Text = "";
                        break;

                    default:
                        break;
                }
                //Display the error message
                MessageBox.Show(ex.Message);
            }

            //Default catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Event handler for the clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all the text boxes
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";

            txtTestScore.Text = "";
            txtQuizScore.Text = "";
            txtFinalTestScore.Text = "";
        }

        //Button handler for the close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Has to cancel the dialog box to close the loop in Main
            this.DialogResult = DialogResult.Cancel;

            //Close the form
            this.Close();
        }
    }
}
