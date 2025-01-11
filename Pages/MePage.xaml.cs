using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace CaTinder.Pages
{
    public partial class MePage : ContentPage
    {
        public MePage()
        {
            InitializeComponent();
            CatPhotoPreview.SizeChanged += OnCatPhotoSizeChanged;

        }
        

        
        private void OnEntryFocused(object sender, FocusEventArgs e)
        {
            var frame = (sender as Entry).Parent as Frame;
            frame.BorderColor = Colors.Blue;
        }

        private void OnEntryUnfocused(object sender, FocusEventArgs e)
        {
            var frame = (sender as Entry).Parent as Frame;
            frame.BorderColor = Colors.LightGray;
        }

        private void OnPickerFocused(object sender, FocusEventArgs e)
        {
            var frame = (sender as Picker).Parent as Frame;
            frame.BorderColor = Colors.Blue;
        }

        private void OnPickerUnfocused(object sender, FocusEventArgs e)
        {
            var frame = (sender as Picker).Parent as Frame;
            frame.BorderColor = Colors.LightGray;
        }
        
        private void OnDatePickerFocused(object sender, FocusEventArgs e)
        {
            var frame = (sender as DatePicker).Parent as Frame;
            frame.BorderColor = Colors.Blue;
        }

        private void OnDatePickerUnfocused(object sender, FocusEventArgs e)
        {
            var frame = (sender as DatePicker).Parent as Frame;
            frame.BorderColor = Colors.LightGray;
        }

        private async void OnPickCatPhotoClicked(object sender, EventArgs e)
        {
            try
            {
                var result = await MediaPicker.PickPhotoAsync();
                if (result != null)
                {
                    var stream = await result.OpenReadAsync();
                    CatPhotoPreview.Source = ImageSource.FromStream(() => stream);
                    CatPhotoPreview.IsVisible = true;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Unable to pick a photo: {ex.Message}", "OK");
            }
        }
        
        
        private void OnCatPhotoSizeChanged(object sender, EventArgs e)
        {
            if (CatPhotoPreview.Width > 0 && CatPhotoPreview.Height > 0)
            {
                CatPhotoPreview.Clip = new RoundRectangleGeometry
                {
                    Rect = new Rect(0, 0, CatPhotoPreview.Width, CatPhotoPreview.Height),
                    CornerRadius = 10
                };
            }
        }
        
        

        private void OnSaveClicked(object sender, EventArgs e)
{
    bool isValid = true;

    // Reset error messages
    FullNameError.IsVisible = false;
    GenderError.IsVisible = false;
    UsernameError.IsVisible = false;
    CatNameError.IsVisible = false;
    CatAgeError.IsVisible = false;
    CatGenderError.IsVisible = false;
    CatPhotoError.IsVisible = false;

    if (string.IsNullOrEmpty(FullNameEntry.Text))
    {
        FullNameError.Text = "Full Name is required";
        FullNameError.IsVisible = true;
        isValid = false;
    }

    if (GenderPicker.SelectedIndex == -1)
    {
        GenderError.Text = "Gender is required";
        GenderError.IsVisible = true;
        isValid = false;
    }

    if (string.IsNullOrEmpty(UsernameEntry.Text))
    {
        UsernameError.Text = "Username is required";
        UsernameError.IsVisible = true;
        isValid = false;
    }

    if (string.IsNullOrEmpty(CatNameEntry.Text))
    {
        CatNameError.Text = "Cat's Name is required";
        CatNameError.IsVisible = true;
        isValid = false;
    }

    if (CatAgePicker.Date > DateTime.Now)
    {
        CatAgeError.Text = "Cat's age cannot be in the future";
        CatAgeError.IsVisible = true;
        isValid = false;
    }

    if (CatGenderPicker.SelectedIndex == -1)
    {
        CatGenderError.Text = "Cat's Gender is required";
        CatGenderError.IsVisible = true;
        isValid = false;
    }

    if (CatPhotoPreview.Source == null || !CatPhotoPreview.IsVisible)
    {
        CatPhotoError.Text = "Cat's photo is required";
        CatPhotoError.IsVisible = true;
        isValid = false;
    }

    if (isValid)
    {
        SharedData.Instance.FullName = FullNameEntry.Text;
        DisplayAlert("Success", "Your details have been saved successfully!", "OK");
    }
}

    }
}
