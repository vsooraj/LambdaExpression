﻿using System.Windows;


namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClickMeButton.Click +=
                (s, e) =>
                {
                    MessageBox.Show("Hellow World");
                };
        }

    }
}
