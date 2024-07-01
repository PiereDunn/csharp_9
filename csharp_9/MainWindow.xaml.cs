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

namespace csharp_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка нажатия кнопки разделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Split_Click(object sender, RoutedEventArgs e)
        {
            List<string> words = new List<string>();

            words = splitFrame.Text.Split(' ').ToList<string>();

            for (int i = 0; i < words.Count; i++)
            {
                lbSplitFrame.Items.Add(words[i]);
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки замены слов местами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Shift_Click(object sender, RoutedEventArgs e)
        {
            Label label1 = new Label();
            List<string> words = shiftFrame.Text.Split(' ').ToList<string>();
            words.Reverse();
            string joinedwords = string.Join(" ", words.ToArray<string>());
            LabelShiftFrame.Content = joinedwords;
        }

        /// <summary>
        /// TExtBox разделителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// TextBox перестановки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
        }

        
    }
}
