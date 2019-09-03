using System.Windows;

namespace wpf_demo_databinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
