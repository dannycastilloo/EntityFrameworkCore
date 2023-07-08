using EntityFrameworkCore.Models;
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
    public partial class PeopleInsert : ContentPage
    {
        public PeopleInsert()
        {
            InitializeComponent();
            this.BindingContext = new PeopleInsertViewModel();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            List<Person> people = new List<Person>();

            for (int i = 0; i < 1; i++)
                people.Add(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(people);


        }

        private async void Go_Listado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PeopleView());
        }

        
    }
}