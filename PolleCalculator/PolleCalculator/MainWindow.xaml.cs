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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Login;

namespace PolleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VotingWindow _votingWindow;
        private IVoterValidator _voterValidator;
        private IVoterDataBaseDispatcher _voterDataBaseDispatcher;
        public MainWindow()
        {
            InitializeComponent();
            _voterDataBaseDispatcher = new VoterDataBaseDispatcher();
            _voterValidator = new VoterValidator();
        }

        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            _voterValidator.CheckIfUserCanVote();
            _voterDataBaseDispatcher.SaveVoterInDataBase();

            _votingWindow = new VotingWindow();
            _votingWindow.Show();
            this.Close();
        }
    }
}
