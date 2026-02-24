using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Input;


class MainWindow : Window
{
    // 생성자: 객체가 생성될 때 자동으로 호출되는 함수 
    //      여기서 윈도우 GUI관련 초기화 코드를 작성하면 됨

    public MainWindow() 
    {
        // 아래의 모든 필드는 부모 클래스인 Window로부터 상속 받은 필드들
        Title = "Hello";
        Width = 500;
        Height = 500;
        Content = "ABCD";

        Topmost = true; // 항상 다른 윈도우 위쪽에 놓임
    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}