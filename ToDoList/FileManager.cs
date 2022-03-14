using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class FileManager
    {
        // Declaring constant 
        private const string fvToken = "Name";                      // Name
        private const double fV = 1.0;                              // File Version

        // Method: Save To File 
         public bool SaveToDoList(List<Task> taskList, string ToDoFile)
        {
            bool sWrite = true;                                     // Boolean: to be used while trying to Save data/info to the file
            StreamWriter writer = null;                             // Declaring Streamwriter - set default value

            //Open Streamwriter
            try
            {
                writer = new StreamWriter(ToDoFile);                // Writing to the textfile
                writer.WriteLine(fvToken);                          // Adding on the firstl line the file version token
                writer.WriteLine(fV);                               // Adding to the second line the file version
                writer.WriteLine(taskList.Count);                   // Adding the amount of items to the text file

                // FOR-LOOP to iterate through the TaskList and adding each item
                // in it's correct order from the object to the textfile
                // <All the object's attributes>
                for (int i = 0; i <taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].TaskDescr);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].Date.Year);
                    writer.WriteLine(taskList[i].Date.Month);
                    writer.WriteLine(taskList[i].Date.Day);
                    writer.WriteLine(taskList[i].Date.Hour);
                    writer.WriteLine(taskList[i].Date.Minute);
                    writer.WriteLine(taskList[i].Date.Second);
                }
            }
            catch   // Catch: program will through statement in order to avoid exception error
            {
                sWrite = false;
            }
            finally // Close Streamwriter.
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return sWrite;
        }

            // Method: Read From File

            public bool ReadFromFile(List<Task> taskList, string ToDoFile) {

            bool sRead = true;                                  // Boolean: to be used while trying to from file
            StreamReader reader = null;                         // Declaring Streamwriter - set default value

                // Try-Block
                try{

                if (taskList != null)                           // Program verify if tasklist is empty
                    taskList.Clear();                           // Program clear tasklist
                else
                    taskList = new List<Task>();                // Program create new list

                reader = new StreamReader(ToDoFile);            // Declaring a Streamreader to read the textfile

                string versionTest = reader.ReadLine();             // String test file version
                double version = double.Parse(reader.ReadLine());   // Double holds File Version


                if ((versionTest == fvToken) && (version == fV))   // Program check if the version matches (test version and the double holding file version)
                {                                                  // The program will update the GUI based on information from the file

                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.TaskDescr = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.Date = new DateTime(year, month, day, hour, minute, second);

                        taskList.Add(task);
                    }
                }
            }
            catch // Catch: program will through statement in order to avoid exception error
            {
                sRead = false;
            }
            finally // Program close the Streamwriter
            {
                if (reader != null)
                    reader.Close();
            }
            return sRead;
        }
    }
}