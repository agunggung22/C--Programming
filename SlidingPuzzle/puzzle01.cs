
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle step 1. 그림 Load해서 윈도우에 연결

class MainWindow : Window
{
    public MainWindow()
    {
        // 1. 자원의 경로를 관리하는 객체 생성
        Uri uri = new Uri("C:\\dev\\C#\\visualStudio\\SlidingPuzzle\\totoro.jpg"); // 이미지 경로

        // 2. Bitmap을 메모리로 Load 하는 객체 생성
        BitmapImage bm = new BitmapImage(uri);

        // 3. Load된 이미지 데이터 객체를 Content로 연결하려면 UIEliment 객체 필요
        Image img = new Image();
        img.Source = bm;

        // 4. Content에 연결
        Content = img;
    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}