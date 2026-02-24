using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



//class UIElement { }
//class Button : UIElement { }
//class Slider : UIElement { }

//// StackPanel은 이렇게 생김 
//class StackPanel 
//{
//    // 여러개의 컨트롤을 관리해야 합니다.
//    public List<?> Children = new List<?>();
//    // ?에는 버튼도 올 수 있고, slider도 올 수 있음
//    // ?는 공통의 기반 클래스인 UIElement임

//}







class MainWindow : Window
{
    public MainWindow()
    {
        Title = "Hello";

        StackPanel sp = new StackPanel();

        Content = sp;
        Button b1 = new Button { Content = "버튼1", FontSize = 32 };

        sp.Children.Add(b1);

        Slider slider = new Slider();
        sp.Children.Add(slider);      // Add 메소드의 매개변수 타입도 UIEliment임 (마우스 올려서 확인 가능)

        RadioButton radio = new RadioButton();
        sp.Children.Add(radio);
        sp.Children.Add(new Button { Content = "버튼2" });
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