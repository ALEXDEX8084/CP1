//using static Android.Net.Wifi.WifiEnterpriseConfig;

namespace XamlApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new EmployeeModel
        {
            FIO = "Прохоров Валерий Сергеевич",
            Stuff = "Инжинер",
            Salary = 52000,
            Exp = 10,
            Factor = 1.1
        };
    }
}


