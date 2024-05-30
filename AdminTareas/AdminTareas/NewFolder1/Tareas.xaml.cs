using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static AdminTareas.TareasModel;

namespace AdminTareas.NewFolder1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tareas : ContentPage
    {

        private TareasModel model;
        public Tareas()
        {
            InitializeComponent();
            model = new TareasModel();
            BindingContext = model;
        }

        private async void Iniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tareas());
        }

        

        private void OnAddTaskClicked(object sender, System.EventArgs e)
        {

            string taskDescription = TaskInput.Text;
            model.AddTask(taskDescription);
            TaskInput.Text = string.Empty;
        }

        private void OnDeleteTaskClicked(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            var taskItem = button?.BindingContext as TaskItem;
            model.DeleteTask(taskItem);
        }

        private async void OnEditTaskClicked(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            var taskItem = button?.BindingContext as TaskItem;
            if (taskItem != null)
            {
                string newDescription = await DisplayPromptAsync("Editar Tarea", "Nueva descripción:", initialValue: taskItem.Description);
                if (!string.IsNullOrWhiteSpace(newDescription))
                {
                    model.UpdateTask(taskItem, newDescription);
                }
            }
        }


    }
}
