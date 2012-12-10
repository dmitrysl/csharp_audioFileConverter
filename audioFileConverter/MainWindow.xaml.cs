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
using Microsoft.Win32;

namespace audioFileConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenAudioFile(object sender, RoutedEventArgs e)
        {

            var openFileDialog1 = new OpenFileDialog
                {
                    Filter = "Audio Files|*.mp3",
                    Title = "Select audio file"
                };
            if (openFileDialog1.ShowDialog() == true)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
//                openFileDialog1.OpenFile()
                MessageBox.Show(openFileDialog1.FileName);
            }
//              MenuItem obMenuItem = e.OriginalSource as MenuItem;
//            MessageBox.Show(String.Format("{0} just said Hi!", obMenuItem.Header));
//            throw new NotImplementedException();
        }

        private void OpenFileDialog(object sender, RoutedEventArgs e)
        {
        }
    }
}
