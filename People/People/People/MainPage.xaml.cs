using People.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace People
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            await App.PersonRepo.AddNewPerson(newPerson.Text);
            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            var allPeople = await App.PersonRepo.GetAllPeople();

            ObservableCollection<Person> people = new ObservableCollection<Person>(allPeople);
            peopleList.ItemsSource = people;
        }
    }
}
