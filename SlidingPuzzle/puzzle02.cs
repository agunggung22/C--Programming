
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle step 2. 그림의 전체가 아닌 일부분을 출력 

class MainWindow : Window
{
    public MainWindow()
    {
        Uri uri = new Uri("C:\\dev\\C#\\visualStudio\\SlidingPuzzle\\totoro.jpg"); 

        BitmapImage bm = new BitmapImage(uri);

        // Load된 비트맵에서 일부를 crop
        Int32Rect rc = new Int32Rect(0, 0, 100, 100); // int32 타입으로 관리하는 사각형
        CroppedBitmap cb = new CroppedBitmap(bm, rc); // bm을 rc크기로 자름

        Image img = new Image();
        // img.Source = bm;     // 전체 bitmap을 image 객체로 
        img.Source = cb;        // 일부 bitmap을 image 객체로

        const.
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