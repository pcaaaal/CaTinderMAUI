using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaTinder.Pages;

public partial class BrowseView : ContentPage
{
    
    private async void OnSearchClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchPage());
    }
    
    public BrowseView()
    {
        InitializeComponent();
    }
}