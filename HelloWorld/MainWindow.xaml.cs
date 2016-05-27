using System.Windows;


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
                delegate(object sender, RoutedEventArgs e)
                {
                    MessageBox.Show("Hellow World");
                };
        }

    }
}
