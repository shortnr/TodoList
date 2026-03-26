using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Src.Commands;
using TodoList.Src.Models;

namespace TodoList.Src.ViewModels
{
    public class TodoListViewModel
    {
        public RelayCommand RemoveTaskCommand { get; }

        public TodoListViewModel()
        {
            RemoveTaskCommand = new RelayCommand(() => RemoveTask(null!));
        }

        public ObservableCollection<TaskItemViewModel> TaskItemList { get; } = [];

        public void AddTask(TaskItemModel newModel)
        {
            TaskItemList.Add(new TaskItemViewModel(newModel));
        }

        private void RemoveTask(TaskItemViewModel taskItem)
        {
            TaskItemList.Remove(taskItem);
        }
    }
}
