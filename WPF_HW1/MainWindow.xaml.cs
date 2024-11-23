using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_HW1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateArea(object sender, RoutedEventArgs e)
        {
            LabelWidht.ClearValue(ForegroundProperty);
            LabelHeight.ClearValue(ForegroundProperty);

            bool isWidthValid = double.TryParse(WidthTextBox.Text, out double width);
            bool isHeightValid = double.TryParse(HeightTextBox.Text, out double height);

            if (!isWidthValid || width <= 0)
            {
                LabelWidht.Foreground = Brushes.Red;
            }

            if (!isHeightValid || height <= 0)
            {
                LabelHeight.Foreground = Brushes.Red;
            }


            if (!isWidthValid || !isHeightValid || width <= 0 || height <= 0)
            {
                ResultLabel.Content = "Invalid input!";
                return;
            }

            double area = width * height;
            ResultLabel.Content = $"Area: {area}";
        }
    }
}