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

namespace WpfTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSemibold_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox.Selection != null)
            {
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox.Selection != null)
            {
                richTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
            }
        }
    }
}