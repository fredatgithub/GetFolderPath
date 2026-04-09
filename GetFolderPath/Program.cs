using System;

namespace GetFolderPath
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
      string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      string userName = Environment.UserName;
      string picturesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
      string videosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);


      Display($"User profile: {userPath}");
      Display($"Desktop: {desktopPath}");
      Display($"Documents: {documentsPath}");
      Display($"Application Data: {appDataPath}");
      Display($"Local Application Data: {localAppDataPath}");
      Display($"User Name: {userName}");
      Display("Images: " + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
      Display("Videos: " + Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));

      Display("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
