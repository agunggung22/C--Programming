
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle step 4. Grid 도입

class MainWindow : Window
{
    private int blockWidth = 0;
    private int blockHeight = 0;

    private const int COUNT = 5;

    private Grid grid;
    public void InitPanel()
    {
        // 1. Grid 생성
        grid = new Grid();
        
        // 2. Row, Col 설정
        for(int i=0; i < COUNT; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }

        // 3. MainWindow의 Content로 grid 연결
        Content = grid;
    }

    public MainWindow()
    {
        // 패널 초기화
        InitPanel();

        Uri uri = new Uri("C:\\dev\\C#\\visualStudio\\SlidingPuzzle\\totoro.jpg");

        BitmapImage bm = new BitmapImage(uri);

        blockWidth = (int)bm.Width / COUNT;    
        blockHeight = (int)bm.Height / COUNT;

        Int32Rect rc = new Int32Rect(0, 0, blockWidth, blockHeight);
        CroppedBitmap cb = new CroppedBitmap(bm, rc);

        Image img = new Image();
        img.Source = cb;

        // Content = img;

        // 생성된 image 객체를 content가 아닌 -> Grid (0,0)에 넣기
        Grid.SetRow(img, 0);
        Grid.SetColumn(img, 0);
        grid.Children.Add(img);
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