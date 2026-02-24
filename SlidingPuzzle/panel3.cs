
// pane3.cs
// 핵심. dockPanel
using System.Windows;
using System.Windows.Controls;

class MainWindow : Window
{
    public MainWindow()
    {
        // dockpanel은 top,bottom,left,right로 부착
        DockPanel dp = new();
        Content = dp;

        // dockpanel의 나머지 전체는 마지막 child가 차지함
        dp.LastChildFill = false; // Panel 설정 변경

        Button b1 = new Button() { Content = "버튼1" };
        Button b2 = new Button() { Content = "버튼2" };
        Button b3 = new Button() { Content = "버튼3" };
        Button b4 = new Button() { Content = "버튼4" };

        // 1. 각 버튼이 dockPanel 어디에 놓일지 설정
        DockPanel.SetDock(b1, Dock.Top);        // static method
        DockPanel.SetDock(b2, Dock.Bottom);
        DockPanel.SetDock(b3, Dock.Left);
        DockPanel.SetDock(b4 , Dock.Left);

        // 2. 각 버튼을 DockPanel에 부착
        dp.Children.Add(b1);
        dp.Children.Add(b2);
        dp.Children.Add(b3);
        dp.Children.Add(b4);



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
