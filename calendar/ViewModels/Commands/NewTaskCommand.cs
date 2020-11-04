﻿using calendar.Models;
using calendar.Utilities;
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace calendar.ViewModels.Commands
{
    public class NewTaskCommand : ICommand
    {
        private NewTaskViewModel _newTaskViewModel;

        public event EventHandler CanExecuteChanged;

        public NewTaskCommand(NewTaskViewModel newTaskViewModel)
        {
            _newTaskViewModel = newTaskViewModel;
        }

        public bool CanExecute(object parameter)
        {
            // TODO: return false when new task name is empty
            if (_newTaskViewModel.NewTaskName == "")
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            Trace.WriteLine($"task created ({ _newTaskViewModel.NewTaskName }, { _newTaskViewModel.NewTaskDetails }, { _newTaskViewModel.NewTaskDate })");
            TaskManager.Tasks.Add(new TaskModel()
            {
                Name = _newTaskViewModel.NewTaskName,
                Details = _newTaskViewModel.NewTaskDetails,
                DateAndTime = _newTaskViewModel.NewTaskDate,
            });
        }
    }
}
