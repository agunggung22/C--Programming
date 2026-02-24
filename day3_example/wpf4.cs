using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


class MainWindow : Window
{
   
    public MainWindow() 
    {
        Title = "Hello";

        // Window에서 가장 중요한 Property는 Content
        // 윈도우에 나타낼 한개의 컨텐츠를 연결 가능
        //Content = "ABCD";
        //Content = new Button { };

        // 핵심. 컨텐트에는 한 개만 연결 가능
        // => 여러 개를 만들려면 Panel 도구 사용

        // 스택 패널은 content를 horizontal방향으로 배치 
        StackPanel sp = new StackPanel();
        Content=sp;                          // 윈도우 위에 StakPanel을 붙임. Panel은 투명해서 보이지 않음

        // 이제 다양한 컨트롤을 panel에 붙이면 됨
        Button b1 = new Button { Content = "버튼1" };
        sp.Children.Add(b1);

        Slider slider = new Slider();   
        sp.Children.Add(slider);

        RadioButton radio = new RadioButton();
        sp.Children.Add(radio);
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