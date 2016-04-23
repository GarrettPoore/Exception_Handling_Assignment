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
    //This program will accept multiple Student objects, and list them for the user
    public partial class Main : Form
    {
        //List variable to hold all student objects
        public List<Student> studentList = new List<Student>();

        //Initialize the form
        public Main()
        {
            InitializeComponent();
        }

        //Event handler when the Add New Student button is clicked
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            //Using to create a dialog box to take information for the new student
            using (var addStudentForm = new Add_Student_Window())
            {
                //Exit flag for the loop
                bool exitFlag = true;

                //Loop until the user either exits the dialog box, or properly enters the information
                do
                {
                    //Open the dialog box and obtain the result
                    var result = addStudentForm.ShowDialog();

                    //If the user tries to enter the student information
                    if (result == DialogResult.OK)
                    {
                        //Try to catch exceptions
                        try
                        {
                            //Check to see if a name was entered
                            if (addStudentForm.newStudent.FullName != "  ")
                            {
                                //Loop through the list to compare the entered student to each current student, to check for duplicates
                                foreach (Student student in studentList)
                                {
                                    //Compare names
                                    if ((student.FirstName == addStudentForm.newStudent.FirstName) &&
                                        (student.MiddleName == addStudentForm.newStudent.MiddleName) &&
                                        (student.LastName == addStudentForm.newStudent.LastName))
                                    {
                                        //Thrown exception for duplicate names
                                        throw new DuplicateNameException("The name " + student.FullName + " appears to have already been added to the list.");
                                    }
                                }

                                //Add the studen to the list
                                studentList.Add(addStudentForm.newStudent);

                                //Set the exit flag for the loop
                                exitFlag = false;
                            }

                            //If a name was not entered
                            else
                            {
                                //Throw an invalid name exception
                                throw new InvalidNameException("Please enter the student's name.");
                            }
                        }

                        //Duplicate name exception catch
                        catch (DuplicateNameException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //Invalid name exception catch
                        catch (InvalidNameException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        //Default exception catch
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    //If the user cancels the dialog box
                    else
                    {
                        exitFlag = false;
                    }
                } while (exitFlag); //loops until flagged
            }

            //Call method to refresh the list
            RefreshList();
        }

        //Close button event handler
        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.Close(); 
        }

        //Method to refresh the list items
        private void RefreshList()
        {
            //Clear the current list
            lstShow.Items.Clear();

            //Loop through the list
            foreach (Student student in studentList)
            {
                //Show the student entry
                lstShow.Items.Add(student.ToString());
            }
        }
    }
}
