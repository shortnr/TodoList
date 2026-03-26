using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TodoList.Src.Commands;
using TodoList.Src.Models;

namespace TodoList.Src.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private object _currentView;
        private readonly TodoListViewModel _todoListViewModel = new();

        public ICommand NavToAddTaskCommand { get; }

        public ObservableCollection<TaskItemViewModel> TaskItemList { get; } = [];

        public MainViewModel()
        {
            _currentView = new TodoListViewModel();

            NavToAddTaskCommand = new RelayCommand(() =>
            {
                CurrentView = new AddTaskViewModel(
                    onTaskAdded: task =>
                    {
                        _todoListViewModel.AddTask(task);
                        CurrentView = _todoListViewModel;
                    },
                onCanceled: () => CurrentView = _todoListViewModel);
            });
        }
        
        public object CurrentView
        {
            get => _currentView;
            set
            {
                if (_currentView == value) return;
                _currentView = value;
                OnPropertyChanged();
            }
        }
    }
}
