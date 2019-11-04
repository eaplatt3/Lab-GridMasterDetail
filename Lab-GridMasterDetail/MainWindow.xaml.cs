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

            Actor a;

            StreamReader read = new StreamReader(fileName);

            while (!read.EndOfStream)
            {
               m = new Movie();

                m.Name = read.ReadLine();
                m.RottenTomatosScore = read.ReadLine();
                m.Review = read.ReadLine();
                m.Poster = read.ReadLine();

                for(int i = 0; i<2; i++)
                {
                    a = new Actor();
                    a.FirstName = read.ReadLine();
                    a.LastName = read.ReadLine();
                    m.Actors(a);


                }

                MasterList.Items.Add(m);
            
            }
        }

        private void MasterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie m = (Movie) e.AddedItems[0];
            ShowMovieDetails(m);
        }

        private void ShowMovieDetails(Movie m)
        {
            NameDetails.Text = m.Name;
            RottenTomatoesScoreDetails.Text = m.RottenTomatosScore;
            ReviewDetails.Text = m.Review;

            string fullPathFileName = Environment.CurrentDirectory + "\\" + m.Poster;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullPathFileName);
            bitmap.EndInit();
            ImagePoster.Source = bitmap;

            ListViewItem.Items.Clear();
            foreach(Actor a in m.Actors)
            {
                ListViewItem.Items.Add(a);
            }

        }
    }
}
