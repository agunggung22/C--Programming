
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle step 4. 생성자에 있는 Image Load 코드를 별도의 함수로 분리

class MainWindow : Window
{
    private int blockWidth = 0;
    private int blockHeight = 0;

    private const int COUNT = 5;

    private Grid grid;

    public void InitPanel()
    {
        grid = new Grid();
        
        for(int i=0; i < COUNT; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }

        Content = grid;
    }

    public void MakeGridImage()
    {
        Uri uri = new Uri("C:\\dev\\C#\\visualStudio\\SlidingPuzzle\\totoro.jpg");

        BitmapImage bm = new BitmapImage(uri);

        blockWidth = (int)bm.Width / COUNT;
        blockHeight = (int)bm.Height / COUNT;

        Int32Rect rc = new Int32Rect(0, 0, blockWidth, blockHeight);
        CroppedBitmap cb = new CroppedBitmap(bm, rc);

        Image img = new Image();
        img.Source = cb;

        Grid.SetRow(img, 0);
        Grid.SetColumn(img, 0);
        grid.Children.Add(img);
    }

    public MainWindow()
    {
        InitPanel();

        // 다른 생성자에서도 사용할 코드 중복을 피함
        MakeGridImage();
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