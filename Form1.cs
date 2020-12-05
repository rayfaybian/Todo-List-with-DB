using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo_ListLogic;

namespace Todo_List
{
    public partial class Form1 : Form
    {
        TodoController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new TodoController();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {   
            var date = dTP.Value;
            var todoText = rTP.Text;

            controller.addTodo(date, todoText);
        }
    }
}
