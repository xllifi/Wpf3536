using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<string> singleAnswers = new string[4].ToList();
        
        private readonly List<string> singleAnswersCorrect = new() { "q1a1", "q2a2", "q3a2", "q4a2" };
        
        public MainWindow() {
            InitializeComponent();
        }

        private void SelectSingleAnswer(object sender, RoutedEventArgs e) {
            RadioButton radioButton = (RadioButton)sender;
            int currentIndex = int.Parse(radioButton.GroupName.Substring(radioButton.GroupName.IndexOf('_') + 1)) - 1;
            singleAnswers[currentIndex] = radioButton.Tag.ToString()!;
            
            // Console.WriteLine("answers[" + currentIndex + "] = " + answers[currentIndex]);
        }

        private void Submit(object sender, RoutedEventArgs e) {
            singleAnswers.Sort();

            if (singleAnswersCorrect.SequenceEqual(singleAnswers)) {
                MessageBox.Show("Тест пройден верно");
                return;
            }

            MessageBox.Show("Тест пройден неверно");
            return;
        }

    }
}
