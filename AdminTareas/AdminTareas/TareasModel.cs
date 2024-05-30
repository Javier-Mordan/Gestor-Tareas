using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace AdminTareas
{
    public class TareasModel : ContentPage
    {
        private string _taskDescription;
        public string TaskDescription
        {
            get => _taskDescription;
            set
            {
                _taskDescription = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TaskItem> Tasks { get; set; }

        public TareasModel()
        {
            Tasks = new ObservableCollection<TaskItem>();
        }

        public void AddTask(string taskDescription)
        {
            if (!string.IsNullOrWhiteSpace(taskDescription))
            {
                Tasks.Add(new TaskItem { Description = taskDescription });
            }
        }

        public void DeleteTask(TaskItem task)
        {
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }
        public void UpdateTask(TaskItem task,string newDescription)
        {
            if (task != null && !string.IsNullOrWhiteSpace(newDescription))
            {
                task.Description = newDescription;
                OnPropertyChanged(nameof(Tasks));
            }
        }
    }

    public class TaskItem : BindableObject
    {
        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
    }


}
  