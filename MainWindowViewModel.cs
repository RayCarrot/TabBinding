using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TabBinding;

public partial class MainWindowViewModel : ObservableObject
{
    public MainWindowViewModel()
    {
        Pages = new ObservableCollection<BasePageViewModel>
        {
            new Page1ViewModel(),
            new Page2ViewModel(),
        };
        _selectedPage = Pages.First();
    }

    public ObservableCollection<BasePageViewModel> Pages { get; }

    [ObservableProperty]
    private BasePageViewModel _selectedPage;
}

public abstract class BasePageViewModel : ObservableObject
{
    public abstract string Title { get; }
}

public class Page1ViewModel : BasePageViewModel
{
    public override string Title => "Page 1";
}

public class Page2ViewModel : BasePageViewModel
{
    public override string Title => "Page 2";
}