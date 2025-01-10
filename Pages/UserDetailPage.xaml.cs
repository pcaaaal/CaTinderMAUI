using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaTinder.Models;

namespace CaTinder.Pages;

    public partial class UserDetailPage : ContentPage
    {
        public UserDetailPage(User user)
        {
            InitializeComponent();
            UserFullName.Text = user.FullName;
            UserName.Text = user.Id.ToString(); // Update this with additional user details
            UserImage.Source = user.ImageName;
        }
    }