using Hello.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Hello.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}