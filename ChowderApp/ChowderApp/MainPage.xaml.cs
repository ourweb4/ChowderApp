using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ChowderApp.Helpers;
using ChowderApp.Pages;

namespace ChowderApp
{
	public partial class MainPage : ContentPage
	{
        string Version;
		public MainPage()
		{
			InitializeComponent();
            Version = "Version " + Constants.VERSIONNO;
            vers.Text = Version;
		}

        private async void Start_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomPage());
        }
    }
}
