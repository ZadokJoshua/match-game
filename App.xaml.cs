using System;
using System.IO;
using System.Windows;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public readonly static string databaseName = "MatchGame.db";
        public readonly static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public readonly static string databasePath = Path.Combine(folderPath, databaseName);
    }
}
