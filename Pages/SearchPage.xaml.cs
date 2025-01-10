using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;
using CaTinder.Models;

namespace CaTinder.Pages
{
    public partial class SearchPage : ContentPage
    {
        ObservableCollection<User> allUsers = new ObservableCollection<User>();
        ObservableCollection<User> filteredUsers = new ObservableCollection<User>();

        public SearchPage()
        {
            InitializeComponent();

            allUsers.Add(new User() { FullName = "Emma Meier", ImageName = "pp1.jpeg" });
            allUsers.Add(new User() { FullName = "Max Keller", ImageName = "pp2.jpeg" });
            allUsers.Add(new User() { FullName = "Sophia Wagner", ImageName = "pp3.jpeg" });
            allUsers.Add(new User() { FullName = "Anna Fischer", ImageName = "pp4.jpeg" });
            allUsers.Add(new User() { FullName = "Laura Vogel", ImageName = "pp5.jpeg" });
            allUsers.Add(new User() { FullName = "Mia Müller", ImageName = "pp6.jpeg" });
            allUsers.Add(new User() { FullName = "Lena Weber", ImageName = "pp7.jpeg" });
            allUsers.Add(new User() { FullName = "Clara Walter", ImageName = "pp8.jpeg" });
            allUsers.Add(new User() { FullName = "Lea Klein", ImageName = "pp9.jpeg" });
            allUsers.Add(new User() { FullName = "Lukas Bauer", ImageName = "pp10.jpeg" });
            allUsers.Add(new User() { FullName = "Jonas Hofmann", ImageName = "pp11.jpeg" }); 
            allUsers.Add(new User() { FullName = "Marie Schuster", ImageName = "pp12.jpeg" });
            allUsers.Add(new User() { FullName = "Daniel Braun", ImageName = "pp13.jpeg" });
            allUsers.Add(new User() { FullName = "Sophia Krüger", ImageName = "pp14.jpeg" });
            allUsers.Add(new User() { FullName = "Tom Richter", ImageName = "pp15.jpeg" });
            allUsers.Add(new User() { FullName = "Nina Fischer", ImageName = "pp16.jpeg" });


            
            foreach (var user in allUsers)
                filteredUsers.Add(user);

            list.ItemsSource = filteredUsers;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue?.ToLower() ?? string.Empty;

            filteredUsers.Clear();
            foreach (var user in allUsers.Where(u => u.FullName.ToLower().Contains(searchText)))
            {
                filteredUsers.Add(user);
            }
        }
    }
}