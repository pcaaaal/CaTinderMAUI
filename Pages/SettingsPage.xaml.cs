using Microsoft.Maui.Controls;

namespace CaTinder.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            
            var generalSettings = new List<SettingItem>
            {
                new SettingItem { Title = "Enable Location", IsToggled = true },
                new SettingItem { Title = "Use Lightmode", IsToggled = false },
                new SettingItem { Title = "Enable Icloud Sync", IsToggled = true },
            };
            
            var privacySettings = new List<SettingItem>
            {
                new SettingItem { Title = "Allow Profile visibility", IsToggled = true },
                new SettingItem { Title = "Allow Search by Others", IsToggled = false },
                new SettingItem { Title = "Track User Activity", IsToggled = true },
                new SettingItem { Title = "Enable Two-Factor Authentication", IsToggled = true },
            };
            
            var notificationSettings = new List<SettingItem>
            {
                new SettingItem { Title = "Enable Push Notifications", IsToggled = true },
                new SettingItem { Title = "Receive Email Offers", IsToggled = false },
            };
            
            

            GeneralSettingsList.ItemsSource = generalSettings;
            PrivacySettingsList.ItemsSource = privacySettings;
            NotificationSettingsList.ItemsSource = notificationSettings;

        }
        
        public class SettingItem
        {
            public string Title { get; set; }
            public bool IsToggled { get; set; }
        }


        // Navigate to FAQ page
        private async void OnFAQClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FAQPage());
        }

        private async void OnAppInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }
    }
}