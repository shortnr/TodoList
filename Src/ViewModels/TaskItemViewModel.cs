using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Input;
using TodoList.Src.Models;
using TodoList.Src.Commands;

namespace TodoList.Src.ViewModels
{
    public class TaskItemViewModel : ViewModelBase
    {
        private readonly TaskItemModel _taskItem;

        public TaskItemViewModel(TaskItemModel taskItem)
        {
            _taskItem = taskItem;
            DeleteCommand = new RelayCommand(() => { });
        }

        public string? TaskName => _taskItem.TaskName;
        public string? Priority => _taskItem.Priority;

        public string DueDate => _taskItem.DueDate.ToString("MM/dd/yyyy");
        
        public bool Completed
        {
            get => _taskItem.Completed;
            set
            {
                if (_taskItem.Completed != value)
                {
                    _taskItem.Completed = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand DeleteCommand { get; }
    }
}
