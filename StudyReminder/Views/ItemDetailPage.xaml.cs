using System.ComponentModel;
using StudyReminder.ViewModels;
using Xamarin.Forms;

namespace StudyReminder.Views
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