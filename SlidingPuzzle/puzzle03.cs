
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle step 3. 정확한 크기 계산

class MainWindow : Window
{
    private int blockWidth = 0;
    private int blockHeight = 0;

    // 블럭의 개수도 하드코딩하자 말아라 
    // 5가 아닌 다른 값으로 변경도 가능하도록 
    private const int COUNT = 5; // 상수

    public MainWindow()
    {
        Uri uri = new Uri("C:\\dev\\C#\\visualStudio\\SlidingPuzzle\\totoro.jpg"); 

        BitmapImage bm = new BitmapImage(uri);

        // bitmap의 너비와 높이를 계산
        blockWidth = (int)bm.Width / COUNT;     // 타입 캐스팅
        blockHeight = (int)bm.Height / COUNT;

        Int32Rect rc = new Int32Rect(0, 0, blockWidth, blockHeight);  // 인자는 (x,y,w,h) 의미 
        CroppedBitmap cb = new CroppedBitmap(bm, rc); 

        Image img = new Image(); 
        img.Source = cb;        

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