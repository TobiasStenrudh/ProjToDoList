using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{

    public partial class MainForm : Form
    {
        // Declare & Initalize

        private Handler handler;                                            // Handler
        string ToDoFile = Application.StartupPath + "\\ToDoFile.txt";       // Hardcode method: path to textfile


        // MainForm
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
                // Update program titlebar
                this.Text = "To do reminder app.";

                // object: Handler
                handler = new Handler();

                // Cleaning up ComboBox (GUI)
                ComboBox.Items.Clear();                                             // Clearing any Items of the ComboBox 
                ComboBox.Items.AddRange(Enum.GetNames(typeof(PriorityType)));       // Adding the range of Items from Enum Class
                ComboBox.SelectedIndex = (int)PriorityType.Normal;                  // Setting default value (in order to avoid unwanted behaviour/or results

                // Setting up the ListBox
                lstboxObjects.Items.Clear();                                        // Clearing Items
                txtbox_ToDo.Text = string.Empty;                                    // Setting string to empty
                DateTimePicker.Format = DateTimePickerFormat.Custom;                // Setting a default value for  Date & Time
                DateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";                   // Setting default value

                // Calling method
                SetDefaultValues();


        }
            // Method: Set Default Values
            
            // Program set predefined String values to
            // respectively element on the GUI (Labels,
            // Buttons, Group and Listbox)


            private void SetDefaultValues()
        {

            // Labels
            label_DateAndTime.Text = "Date and Time";
            label_ToDo.Text = "Add New Task";
            label_PriorityCombo.Text = "Select Priority";
            label_Date.Text = "Date";
            label_Hour.Text = "Hour";
            label_Priority.Text = "Priority";
            label_Description.Text = "Task/Description";

            // Buttons
            btn_AddToList.Text = "Add";
            btn_Change.Text = "Change";
            btn_Delete.Text = "Delete";

            // Groupbox & Listbox
            groupbox_ToDoList.Text = "Getting Things Done!";
        }

            private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

            private void MainForm_Load(object sender, EventArgs e)
        {

        }
            // Method: Update Graphical User-Interface
            
            // Program declares an Array to hold information from
            // listbox with the method: GrabList. Thereafter, program
            // clear the listbox and finally run a for-loop to restore
            // previous stored information

            private void UpdateGUI()
        {
                string[] infoStrings = handler.GrabList();                      // Declaring Array
                lstboxObjects.Items.Clear();                                    // Clearing Listbox
                
                for (int i = 0; i < infoStrings.Length; i++)                    // for-loop iterate and any data from each index pos. which is
                                                                                // equilivent to the integer, will be added to the new listbox 
            {
                string holdInfo = (infoStrings[i].ToString());                  // Convert information to String
                lstboxObjects.Items.Add(holdInfo);                              // Adding each String
            }
        }

            // Method: Read User Input
            // The program verify the user input - update information on GUI based on information from the user
            
            private Task ReadInput()
        {

            if (!string.IsNullOrEmpty(txtbox_ToDo.Text))
            {
                Task task = new Task(); 
                task.TaskDescr = txtbox_ToDo.Text;                        
                task.Date = DateTimePicker.Value;                          
                task.Priority = (PriorityType)ComboBox.SelectedIndex;     
                return task;
            }
            else
            {
                MessageBox.Show("ERROR: program fail to add a new task!");
                return null;
            }
        }
            // New: InitalizeGUI
            private void newToolStripMenuItem1_Click(object sender, EventArgs e){
                
                    InitializeGUI();
            }


            // Button: Add to list
            private void btn_AddToList_Click(object sender, EventArgs e)
            {

            Task newTask = ReadInput();                                         // Declaring a new instance of the Task class

            if (handler.AddNewInstance(newTask))                                // Program verifying input values - adding new task with values from user input - update GUI
                {
                UpdateGUI();
                }
            }

            // Button: Change
            private void btn_Change_Click(object sender, EventArgs e) 
            {
         
                int indexPos = lstboxObjects.SelectedIndex;                     // Declaring Index - value equal to index position (selected by user)

                if (indexPos >= 0) {                                            // Program verify indexposition to be equal to-, or greater than zero

                Task task = ReadInput();                                        // New instance: Task

                bool TaskAtIndex = handler.ChangeTaskAtIndex(task, indexPos);   // Boolean to verify the value
                if (TaskAtIndex)                                                
                {                                                              
                    UpdateGUI();                                                // Program will update the GUI - prompt a message to user
                    MessageBox.Show("Update successfully!");    
                } else if (indexPos < 0) {
                    MessageBox.Show("Update Fail! Try again.");
               }
            }
        }

            // Button: Delete
            private void btn_Delete_Click(object sender, EventArgs e)
            {

                int indexPos = lstboxObjects.SelectedIndex;                     // Declaring Index - value equal to index position (selected by user)
                
                if (indexPos >= 0){                                             // Program verify indexposition to be equal to-, or greater than zero
                                                                                
                bool deleteAtIndex = handler.DeleteTaskAtIndex(indexPos);       // Boolean to verify the value - call for method to delete object from the index position

                        if (!deleteAtIndex)                                     // If program fails to delete - prompt message to user
                {
                    MessageBox.Show("Deleting the task from the list failed. Select a task before and try again.");
                }
                        else
                {   
                    MessageBox.Show("you are about to delete task number: " + (indexPos+1).ToString());

                    UpdateGUI();                                                // Program success to delete - call method to update the GUI
                }
            }

        }

            // Menu
             private void openToolStripMenuItem_Click(object sender, EventArgs e){       // Menu - open existing file

             bool openTXT = handler.ReadFromFile(ToDoFile);                              // Boolean verify the existing file

                if (openTXT != true){                                                    // File not avaible/not readable - prompt message to user
                MessageBox.Show("ERROR: Could not read from file");                      // Else program update GUI with information from the file
                } else {
                UpdateGUI();
                }   
             }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e){        // Menu - save information to file

            bool writeTXT = handler.WriteToFile(ToDoFile);                               // Boolean verify information to be written to file

           
                if (writeTXT != true)                                                    // Program verify Boolean - prompt message
            {
                MessageBox.Show("ERROR: Could not save to file!");                       // Program fail to write to file
            }
                else
            {
                MessageBox.Show("Saved Success! - data saved to file: " + Environment.NewLine + ToDoFile); // Program successfully write to file
            }
        }

             
           // Exit - Dialog Result Window
           private void exitToolStripMenuItem_Click(object sender, EventArgs e){

            DialogResult msgBoxAsk = MessageBox.Show("You are about to exit the program - are you sure?", // Program prompt message to user
                                                     "Exit Program", MessageBoxButtons.YesNo);
                         
            if (msgBoxAsk == DialogResult.Yes){                                         // User press 'Yes' - the program terminates itself
                             Application.Exit();
            }
            else if (msgBoxAsk == DialogResult.No){                                     // User press 'No' - the program continues to run
          }
        }

           //  About - Program prompt message to user
               private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
               MessageBox.Show("Program made by T.S");
        }
    }
}