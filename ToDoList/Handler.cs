using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Handler
    {

            // Declare List 
            List<Task> ToDoList;

            // Declare constructor
            public Handler()
        {
            ToDoList = new List<Task>();
        }

            // Method: Grab Task 
        
            // Program grab the task at a specific index position from listbox.
            public Task GrabTaskAt(int index)
        {

            if (GrabIndexAt(index))         // Program verify the value at the index position - return information is value is true.
            {
                return ToDoList[index];
            }   else
            {
                return null;
            }
        }


            // Method: Verify the value of the index

            private bool GrabIndexAt(int index)
        {
            // Declare Integer to hold input value

            int CheckIndexValue = index;

            // Program will detect the value to be true or false
            bool Valid = false;


            if ((CheckIndexValue >= 0) && (index < ToDoList.Count)) // Program verify the index position - greater or equal to zero and not greater than the size of the list
            {
                Valid = true;
            }
                return Valid;
        }

            // Method: Add New Instance
            
            // Program verify the input value (indexposition) - if it's valid; add the new information to the list
            public bool AddNewInstance(Task newTask)
        {
            bool CheckInputValues = true;

            if (newTask != null)
                ToDoList.Add(newTask);
            else
                CheckInputValues = false;
            return CheckInputValues;
        }

            // Method: Change Task At Index

            // Program verify the input value (indexposition) - if it's valid; change the new information at the index position
            public bool ChangeTaskAtIndex(Task task, int IndexPos)
        {
            bool VerifyTask = true;
            if ((task != null) && GrabIndexAt(IndexPos))
            {
                ToDoList[IndexPos] = task;
            }
            else
            {
                VerifyTask = false;
            }
                return VerifyTask;
            }

            // Method: Delete Task At Index

            // Program verify the input value (indexposition) - if it's valid; remove information at index position from list
            public bool DeleteTaskAtIndex(int IndexPos)
        {
            bool DeleteAt = false;

            if ((IndexPos>= 0) && (IndexPos < ToDoList.Count))
            {
                ToDoList.RemoveAt(IndexPos);
                DeleteAt = true;
            }
            return DeleteAt;
        }
            
            // Method: Grab List - the program declares an Array of strings with
            // the same size as ListBox. Then iterate through the list; convert
            // the data into Strings and add it to the new Array of Strings.
            // Finally return the information.

            public string[] GrabList()
        {
            string[] GrabInfoFromList = new string[ToDoList.Count];

            for (int i = 0; i < GrabInfoFromList.Length; i++)
            {
                GrabInfoFromList[i] = ToDoList[i].ToString();
            }
            return GrabInfoFromList;
        }

            // Method: Write to File 

            public bool WriteToFile(string ToDoFile)
        {
            FileManager fMngr = new FileManager();
            return fMngr.SaveToDoList(ToDoList, ToDoFile);
        }

            // Method: Read From File

             public bool ReadFromFile(string ToDoFile)
        {
            FileManager fMngr = new FileManager();
            return fMngr.ReadFromFile(ToDoList, ToDoFile);
        }

    }
}