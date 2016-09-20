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
    /// Interaction logic for VotingWindow.xaml
    /// </summary>
    public partial class VotingWindow : Window
    {
        private ScoreWindow _scoreWindow;
        public VotingWindow()
        {
            InitializeComponent();
        }

        private void VoteButton_Click(object sender, RoutedEventArgs e)
        {
            _scoreWindow = new ScoreWindow();
            _scoreWindow.Show();
            this.Close();
        }
    }
}
