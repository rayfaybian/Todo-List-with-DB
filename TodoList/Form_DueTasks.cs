using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoListLogic;

namespace TodoList

{
    public partial class Form_DueTasks : Form
    {
        TodoController controller;
        int taskId;
        public Form_DueTasks(DateTime date, string task, int id)
        {
            InitializeComponent();
            dateBox.Value = date;
            textBox.Text = task;
            taskId = id;

            controller = new TodoController();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cbDone.Checked)
            {
                controller.MarkTaskDone(taskId);
            }
            else if (cbRemindLater.Checked)
            {
                controller.PauseReminder(taskId);
                MessageBox.Show("Ich erinnere dich in einer Stunde nochmal");
            }
            this.Close();
        }

        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbRemindLater.Checked = false;
        }

        private void cbRemindLater_CheckedChanged(object sender, EventArgs e)
        {
            cbDone.Checked = false;
        }

        private void Form_DueTasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cbDone.Checked)
            {
                controller.PauseReminder(taskId);
                MessageBox.Show("Ich erinnere dich in einer Stunde nochmal");
            }
        }
    }
}
