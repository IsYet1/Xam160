using People.Models;
using System;
using System.Collections.ObjectModel;

namespace People
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.PersonRepo.AddNewPerson(newPerson.Text);
            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            var allPeople = App.PersonRepo.GetAllPeople();

            ObservableCollection<Person> people = new ObservableCollection<Person>(allPeople);
            peopleList.ItemsSource = people;
        }
    }
}
