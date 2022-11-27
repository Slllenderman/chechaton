using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Data
{
    public static class Others
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var cur in enumerable)
            {
                action(cur);
            }
        }
    }

    class TaskManager
    {

        public ObservableCollection<Task> tasks = new ObservableCollection<Task>();
        public string path = "..//..//..//";
        public string name = "json.txt";

        public void ReadJsonFile(string jsonFile)
        {
            FileStream fs = new FileStream(path + jsonFile, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string json = sr.ReadToEnd();
            ObservableCollection<Task> JsonTasks = JsonConvert.DeserializeObject<ObservableCollection<Task>>(json);
            if (JsonTasks != null)
                JsonTasks.ForEach(element => { element.UpdateDateTime(); tasks.Add(element); });
            sr.Close();
            fs.Close();
        }

        public void WriteAll()
        {
            StreamWriter sw = new StreamWriter(path + name);
            string jsonTasks = JsonConvert.SerializeObject(tasks);
            sw.Write(jsonTasks);
            sw.Close();
        }

        public void SetPath(string newPath)
        {
            path = newPath;
            tasks.Clear();
            ReadJsonFile(name);
        }

        public TaskManager(string jsonFile)
        {
            name = jsonFile;
            ReadJsonFile(name);
        }

        public TaskManager()
        {
            name = "json.txt";
            ReadJsonFile("json.txt");
        }

        public void CreateTask(Task task)
        {
            if (tasks.Count != 0)
                task.Id = tasks[tasks.Count - 1].Id + 1;
            else
                task.Id = 1;
            tasks.Add(task);
        }

        public int IndexOfTasks (int Id)
        {
            int index = -1;
            for (int i = 0; i < tasks.Count; i++)
                if (tasks[i].Id == Id)
                    index = i;
            return index;
        }

        public Task GetTask(int Id)
        {
            int index = IndexOfTasks(Id);
            if (index != -1)
                return tasks[index];
            else
            {
                if (tasks.Count != 0)
                    return tasks[0];
                else
                {
                    Task NullTask = new Task();
                    return NullTask;
                }
            }
        }

        public void Update(int Id, Task task)
        {
            int index = IndexOfTasks(Id);
            if (index != -1)
            {
                tasks[index].Name = task.Name;
                tasks[index].EndDate = task.EndDate;
                tasks[index].EndTime = task.EndTime;
                tasks[index].Periodicity = task.Periodicity;
                tasks[index].Description = task.Description;
                tasks[index].IsFailed = task.IsFailed;
            }
        }

        public void DeleteTask(int Id)
        {
            int index = IndexOfTasks(Id);
            if (index != -1)
                tasks.RemoveAt(index);
        }

        ~TaskManager()
        {
            WriteAll();
            Console.WriteLine("destructor");
        }
    }
}
