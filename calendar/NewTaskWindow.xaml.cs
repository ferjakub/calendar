﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace calendar
{
    /// <summary>
    /// Interaction logic for NewTaskWindow.xaml
    /// </summary>
    public partial class NewTaskWindow : Window
    {
        public int Day { get; } = 0;

        public NewTaskWindow(int day)
        {
            Day = day;

            InitializeComponent();
            DataContext = this;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.CurrentMonth.DayCells[0].Tasks.Add(new Task(NewTaskNameTB.Text));
            this.Close();
        }
    }
}
