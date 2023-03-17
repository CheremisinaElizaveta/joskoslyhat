using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using static System.Net.WebRequestMethods;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace AudioPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string musicPath;
        private int musicIndex;
        public MainWindow()
        {
            InitializeComponent();

            media.Source = new Uri("D:\\аудиоплеер\\AudioPlayer\\AudioPlayer\\music\\");
            media.Volume = 0.7;
        }

        private void Shuffle(string[] a)
        {
            Random rand = new Random();
            for (int i = a.Length - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                string tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }
        }

        private string[] GetFiles() => Directory.GetFiles(musicPath);

        private void AddMusicToListBox(string[] files)
        {
            foreach (string file in files)
            {
                string[] splitedFile = file.Split(@"\");

                ListMusic.Items.Add(splitedFile[splitedFile.Length - 1]);
            }
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            audioSlider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
            new Thread(() =>
            {
                while (true)
                {
                    Dispatcher.Invoke(() => audioSlider.Value = media.Position.TotalSeconds);
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        private void audioSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Debug.WriteLine(sender);
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            media.Play();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog { IsFolderPicker = true };
            dialog.InitialDirectory = @"D:\аудиоплеер\AudioPlayer\AudioPlayer\music\";
            var result = dialog.ShowDialog();

            if (result == CommonFileDialogResult.Ok)
            {
                musicPath = dialog.FileName;
                ListMusic.Items.Clear();
                string[] files = GetFiles();
                AddMusicToListBox(files);
                media.Source = new Uri(files[0]);
                media.Play();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListMusic.Items.Clear();
            string[] files = GetFiles();
            Shuffle(files);
            AddMusicToListBox(files);
        }

        private void ListMusic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            musicIndex = ListMusic.SelectedIndex;
            media.Source = new Uri("D:\\аудиоплеер\\AudioPlayer\\AudioPlayer\\music\\" + ListMusic.SelectedItem);
        }

        private void nextMusic_Click(object sender, RoutedEventArgs e)
        {
            musicIndex++;
            if (musicIndex == ListMusic.Items.Count)
                musicIndex = 0;
            media.Source = new Uri("D:\\аудиоплеер\\AudioPlayer\\AudioPlayer\\music\\" + ListMusic.Items[musicIndex]);
        }

        private void previousMusic_Click(object sender, RoutedEventArgs e)
        {
            musicIndex--;
            if (musicIndex == -1)
            {
                musicIndex = ListMusic.Items.Count - 1;

            }
            media.Source = new Uri("D:\\аудиоплеер\\AudioPlayer\\AudioPlayer\\music\\" + ListMusic.Items[musicIndex]);
        }

        private void audioSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            media.Position = new TimeSpan(0, 0, Convert.ToInt32(audioSlider.Value));
        }
    }
}
