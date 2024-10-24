using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermProject_Brodie
{
    public partial class Form1 : Form
    {
        //Array to store tasks
        private string[] tasks = new string[10]; //array for to do tasks
        private string[] tasksInProgress = new string[10]; //array for In Progress tasks
        private string[] tasksCompleted = new string[10]; //array for Completed Tasks

        private int taskCount = 0; //Count of to do tasks
        private int taskCountInProgress = 0; //Count of in Progress Tasks
        private int taskCountCompleted = 0; //Count of Completed Tasks
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string newTask = textBox1.Text.Trim();

            //Error handling to check if empty or full
            if (string.IsNullOrEmpty(newTask))
            {
                MessageBox.Show("Task cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (taskCount >= tasks.Length)
            {
                MessageBox.Show("Task list is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add task to array and update ListBox
                tasks[taskCount] = newTask;
                taskCount++;
                UpdateTaskList(listBox1, tasks, taskCount);
                textBox1.Clear();
            }
        }

        private void btnMarkInProgess_Click(object sender, EventArgs e)
        {
            //Error Handling
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to move In Progress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (taskCountInProgress >= tasksInProgress.Length)
            {
                MessageBox.Show("In Progress list is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Move task from To-Do to In Progress
                tasksInProgress[taskCountInProgress] = tasks[listBox1.SelectedIndex];
                taskCountInProgress++;

                //Shift tasks to in progress array
                for (int i = listBox1.SelectedIndex; i < taskCount - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                }
                taskCount--;

                //Update Listboxes
                UpdateTaskList(listBox1, tasks, taskCount);
                UpdateTaskList(listBox2, tasksInProgress, taskCountInProgress);
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            //Error Handling
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (taskCountCompleted >= tasksCompleted.Length)
            {
                MessageBox.Show("Completed list is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Move task from In progress to Completed
                tasksCompleted[taskCountCompleted] = tasksInProgress[listBox2.SelectedIndex];
                taskCountCompleted++;

                //Shift tasks in the In Progress Array
                for (int i = listBox2.SelectedIndex; i < taskCountInProgress - 1; i++)
                {
                    tasksInProgress[i] = tasksInProgress[i + 1];
                }
                taskCountInProgress--;

                //Update ListBoxes
                UpdateTaskList(listBox2, tasksInProgress, taskCountInProgress);
                UpdateTaskList(listBox3, tasksCompleted, taskCountCompleted);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            //Checks which list to remove from
            if (listBox1.SelectedIndex != -1)
            {
                RemoveTaskFromList(listBox1, tasks, ref taskCount);
            }
            else if (listBox2.SelectedIndex != -1)
            {
                RemoveTaskFromList(listBox2, tasksInProgress, ref taskCountInProgress);
            }
            else if (listBox3.SelectedIndex != -1)
            {
                RemoveTaskFromList(listBox3, tasksCompleted, ref taskCountCompleted);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveTaskFromList(ListBox listBox, string[] tasks, ref int taskCount)
        {
            int selectedIndex = listBox.SelectedIndex;

            //Shift tasks in the array to remove the selected task
            for (int i = selectedIndex; i < taskCount -1; i++)
            {
                tasks[i] = tasks[i + 1];
            }
            taskCount--;

            //Update Listboxes
            UpdateTaskList(listBox, tasks, taskCount);
        }

        private void UpdateTaskList(ListBox listBox, string[] tasks, int count)
        {
            //Updates current tasks
            listBox.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add(tasks[i]);
            }
        }
    }
}
