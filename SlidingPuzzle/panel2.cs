// panel1.cs
using System.Windows;
using System.Windows.Controls;

// 프로그래밍을 배우는 것은?
// 1. 프로그래밍 언어(C#, C++, Java, Python)
// 2. 해당 언어로 만들어진 라이브러리 사용법

// 라이브러리 사용시 대부분의 언어에서 지켜야 하는 공통 규칙 => FrameWork라고 한다
// 프레임워크는 자신만의 규칙이 있음

// WPF: Window Presentation Framework : 윈도우 UI를 짜는 규칙
// 규칙 1. 윈도우에 여러개의 자식컨트롤을 놓으려면 Panel을 사용해야 한다. 

class MainWindow : Window
{
    public MainWindow()
    {
        StackPanel sp = new();

        // 1. 윈도우의 Content에 StackPanel을 부착
        Content = sp;

        sp.Orientation = Orientation.Horizontal;

        // 2. 이제 패턴에 자식 컨트롤을 부착
        sp.Children.Add(new Button());
        sp.Children.Add(new Label());
        sp.Children.Add(new Button());
        sp.Children.Add(new ProgressBar { Value = 50, Height = 20 });

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
