using Avalonia.Controls;

namespace AvaloniaApplication1.Views;

[ReactiveUI.SourceGenerators.IViewFor<ViewModels.MainViewModel>]
public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
}
