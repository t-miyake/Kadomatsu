using System.Windows;

namespace Kadomatsu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MouseLeftButtonDown += (o, e) => DragMove();
        }
    }
}