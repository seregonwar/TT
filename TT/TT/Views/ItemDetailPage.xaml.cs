using System.ComponentModel;
using Xamarin.Forms;
using TT.ViewModels;

namespace TT.Views
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