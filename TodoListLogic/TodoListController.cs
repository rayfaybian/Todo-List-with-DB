using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Timers;


namespace TodoListLogic
{
    public class TodoController
    {
        TodolistEntities entity;
        Dictionary<int, DateTime> paused;
        public TodoController()
        {
            entity = new TodolistEntities();
            paused = new Dictionary<int, DateTime>();
        }

        public void AddTodo(DateTime date, string newTodo)
        {
            todos todo = new todos() { todo = newTodo, datetime = date, done = false };
            entity.todos.Add(todo);
            entity.SaveChanges();
        }

        public List<todos> DisplayTodos()
        {
            var todoQuery = from tasks in entity.todos
                            select tasks;

            List<todos> todos = todoQuery.ToList();

            return todos;
        }

        public List<todos> ShowDueTasks()
        {
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddHours(1);

            var dueTasksQuery = from tasks in entity.todos
                                where tasks.datetime >= startDate
                                && tasks.datetime <= endDate
                                && tasks.done == false
                                select tasks;

            List<todos> dueTasks = new List<todos>();

            foreach (var task in dueTasksQuery)
            {
                dueTasks.Add(task);
            }
            return dueTasks;
        }

        public void MarkTaskDone(int TaskId)
        {
            todos todo = entity.todos.Find(TaskId);
            todo.done = true;
            entity.todos.Add(todo);
            entity.SaveChanges();
        }

        public void PauseReminder(int taskId)
        {
            paused.Add(taskId, DateTime.Now.AddHours(1));
        }

        public bool CheckIfPaused(int taskId)
        {
            if (paused.ContainsKey(taskId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime CheckDateTime(int taskId)
        {
            return paused[taskId];
        }
    }
}
