using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EntityFrameworkCore.ViewModels
{
    public class PeopleInsertViewModel : BaseViewModel
    {
        private string name;
        public string Name
        { 
            get { return this.name; }
            set {  SetValue(ref this.name, value); } 
        }

        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { SetValue(ref this.lastName, value); }
        }

        public ICommand InsertCommand { get; set; }

        public PeopleInsertViewModel() 
        {
            InsertCommand = new Command(() =>
            {

            });
        }
    }
}
