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
using Data;

namespace TodoList
{
    public partial class Form1 : Form
    {
        TodoController controller;
        List<int> active;

        List<string> doneTodos;
        List<string> openTodos;

        public Form1()
        {
            InitializeComponent();
            controller = new TodoController();

            active = new List<int>();

            openTodos = new List<string>();
            doneTodos = new List<string>();

            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            UpdateTodoList();
        }

        private void UpdateTodoList()
        {
            lbTodos.DataSource = null;
            lbDone.DataSource = null;

            List<todos> todos = controller.DisplayTodos();

            openTodos.Clear();
            doneTodos.Clear();
            ;

            foreach (var todo in todos)
            {
                if (todo.done.Equals(false))
                {
                    openTodos.Add(todo.todo);
                }
                else { doneTodos.Add(todo.todo); }
            }
            lbTodos.DataSource = openTodos;
            lbDone.DataSource = doneTodos;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var date = datePicker.Value;
            var text = textBox.Text;

            if (!string.IsNullOrEmpty(text))
            {
                controller.AddTodo(date, text);

                datePicker.Value = DateTime.Now;
            }
            textBox.Text = null;
            UpdateTodoList();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<todos> dueTasks = controller.ShowDueTasks();


            foreach (var task in dueTasks)
            {
                if (!active.Contains(task.id))
                {
                    active.Add(task.id);
                    var form = new Form_DueTasks(task.datetime, task.todo, task.id);
                    form.ShowDialog();
                }

                else if (controller.CheckIfPaused(task.id))
                {
                    if (controller.CheckDateTime(task.id) >= DateTime.Now)
                    {
                        active.Remove(task.id);
                    }
                }
            }
            UpdateTodoList();
        }
    }
}
