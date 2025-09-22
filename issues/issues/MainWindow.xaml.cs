using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Umwandeln des Label-Inhalts in eine Ganzzahl
            int currentValue = int.Parse(myLabel.Content.ToString());

            // Den Wert um 7 verringern
            currentValue -= 7;
            if (currentValue < 0) { currentValue = 1000; }
            // Den neuen Wert ins Label setzen
            myLabel.Content = currentValue.ToString();
        }
    }
}
//btw here is a lot of mistakes xD