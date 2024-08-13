using To_Do_List.ViewModels;

namespace To_Do_List;
public partial class MainPage : ContentPage
{       
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    
}
