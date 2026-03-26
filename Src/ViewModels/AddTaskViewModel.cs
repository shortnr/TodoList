using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Src.Models;
using TodoList.Src.Commands;

namespace TodoList.Src.ViewModels
{
    public class AddTaskViewModel : ViewModelBase
    {

        public AddTaskViewModel(Action<TaskItemModel> onTaskAdded, Action onCanceled)
        {
            AddTaskCommand = new RelayCommand(() =>
            {
                var task = new TaskItemModel
                {
                    TaskName = TaskName ?? string.Empty,
                    DueDate = DueDate,
                    Priority = Priority ?? "Low"
                };
                onTaskAdded(task);
            });

            CancelCommand = new RelayCommand(() => onCanceled());
        }
    
        public string? TaskName { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public string? Priority { get; set; }
        public RelayCommand AddTaskCommand { get; }
        public RelayCommand CancelCommand { get; }

        private void Cancel()
        {

        }
    }
}
