using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab_GridMasterDetail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string fileName;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fileName = "TestData.txt";

            Movie m; 

            StreamReader read = new StreamReader(fileName);

            while (!read.EndOfStream)
            {
               m = new Movie();

                m.Name = read.ReadLine();
                m.RottenTomatosScore = read.ReadLine();
                m.Review = read.ReadLine();

                MasterList.Items.Add(m.ToString());
            
            }
        }
    }
}
