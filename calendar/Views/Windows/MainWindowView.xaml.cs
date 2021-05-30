﻿using calendar.Utilities;
using System.ComponentModel;
using System.Windows;

namespace calendar.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (FileManager.CurrentFileModified == true)
            {
                MessageBoxResult dialogResult = MessageBox.Show("Máte neuložené změny. Chcete je uložit?", "Neuložené změny", MessageBoxButton.YesNoCancel);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    FileManager.SaveFile(FileManager.CurrentFileName);
                }
                else if (dialogResult == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            base.OnClosing(e);
        }
    }
}
