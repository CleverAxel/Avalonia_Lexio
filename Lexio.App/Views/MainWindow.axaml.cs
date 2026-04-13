using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;

namespace Lexio.App.Views;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }
    
    private async void Button_PointerEntered(object sender, PointerEventArgs e)
    {
        var button = (Button)sender;
        button.Classes.Add("shake");
        await Task.Delay(410);
        button.Classes.Remove("shake");
    }
}