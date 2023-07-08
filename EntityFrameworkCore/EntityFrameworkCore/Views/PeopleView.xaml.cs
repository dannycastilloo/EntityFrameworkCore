using EntityFrameworkCore.Services;
using EntityFrameworkCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntityFrameworkCore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : ContentPage
    {
        public PeopleView()
        {
            InitializeComponent();
            this.BindingContext = new PeopleViewModel();
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            lvPeople.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            lvPeople.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}