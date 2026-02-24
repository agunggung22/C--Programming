using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Input;

//// C# WPF 라이브러리에 아래 코드가 있음
//class Window
//{
//    // 다양한 필드, property 등 

//    // 윈도우 위에서 어떤 이벤트가 발생되면 자동으로 호출되는 약속된 메소드
//    virtual void OnMouseLeftButtonDown(...) { }
//    virtual void OnMouseRightButtonDown(...) { }
//    // 수십개의 virtual 메소드들 -> 재정의 가능하다고
//}

// 일반적인 WPF 라이브러리 사용 관례
// window 클래스를 직접 사용하는 것이 아니라, Window의 자식 클래스를 만들어서 사용 
class MainWindow : Window
{
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        // 파생 클래스의 추가 함수를 실행
        MessageBox.Show("LBUTTONDOWN");

        // base: 기반 클래스를 의미 (아마 java의 super??)
        // 기반 클래스의 함수도 실행되도록 자동 생성된 코드 
        base.OnMouseLeftButtonDown(e);
    }


    protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
    {
        MessageBox.Show("RBUTTONDOWN");
        base.OnMouseRightButtonDown(e);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        MessageBox.Show("KeyDown");
        base.OnKeyDown(e);
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