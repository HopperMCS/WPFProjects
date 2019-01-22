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

namespace StatesAndCapitals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InstructionLabel.Content = "To see a state's name, click one of the images on the left." + System.Environment.NewLine + "To see a trivia fact about the United States of America, " + System.Environment.NewLine + "click any one";
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Indiana_Click(object sender, MouseButtonEventArgs e)
        {
            StateInformationLabel.Content = "State - Indiana" + System.Environment.NewLine + "Capital - Indianapolis" + System.Environment.NewLine + "Abbreviation - IN";
        }

        private void Iowa_Click(object sender, MouseButtonEventArgs e)
        {
            StateInformationLabel.Content = "State - Iowa" + System.Environment.NewLine + "Capital - Des Moines" + System.Environment.NewLine + "Abbreviation - IA";
        }

        private void Kentucky_Click(object sender, MouseButtonEventArgs e)
        {
            StateInformationLabel.Content = "State - Kentucky" + System.Environment.NewLine + "Capital - Frankfort" + System.Environment.NewLine + "Abbreviation - KY";
        }

        private void Montana_Click(object sender, MouseButtonEventArgs e)
        {
            StateInformationLabel.Content = "State - Montana" + System.Environment.NewLine + "Capital - Helena" + System.Environment.NewLine + "Abbreviation - MT";
        }

        private void Vermont_Click(object sender, MouseButtonEventArgs e)
        {
            StateInformationLabel.Content = "State - Vermont" + System.Environment.NewLine + "Capital - Montpelier" + System.Environment.NewLine + "Abbreviation - VT";
        }

        private void TriviaButton1_Click(object sender, RoutedEventArgs e)
        {
            string TriviaButton1Message = "Current US population: ~326 million!";
            MessageBoxResult result = MessageBox.Show(TriviaButton1Message);
        }

        private void TriviaButton2_Click(object sender, RoutedEventArgs e)
        {
            string TriviaButton2Message = "Mount McKinley is the tallest mountain in the US";
            MessageBoxResult result = MessageBox.Show(TriviaButton2Message);
        }

        private void TriviaButton3_Click(object sender, RoutedEventArgs e)
        {
            string TriviaButton3Message = "Rhode Island is the smallest state but has the longest official name";
            MessageBoxResult result = MessageBox.Show(TriviaButton3Message);
        }

        private void TriviaButton4_Click(object sender, RoutedEventArgs e)
        {
            string TriviaButton4Message = "The Missouri River is the longest river in the US";
            MessageBoxResult result = MessageBox.Show(TriviaButton4Message);
        }

        private void TriviaButton5_Click(object sender, RoutedEventArgs e)
        {
            string TriviaButton5Message = "Alaksa's nickname is: The Last Frontier";
            MessageBoxResult result = MessageBox.Show(TriviaButton5Message);
        }

        private void TriviaButton6_Click(object sender, RoutedEventArgs e)
        {
            string TriviaButton6Message = "The most visited National Park in the US is Great Smoky Mountains";
            MessageBoxResult result = MessageBox.Show(TriviaButton6Message);
        }
    }
}
