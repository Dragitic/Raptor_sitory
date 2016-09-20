using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PolleCalculator
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        private MainWindow _mainWindow;
        public ScoreWindow()
        {
            InitializeComponent();
        }

        private void VoteButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow = new MainWindow();
            _mainWindow.Show();
            this.Close();
        }
    }
}
