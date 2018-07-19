// ***********************************************************************
// Assembly         : ChowderApp
// Author           : Bill Banks
// Created          : 07-17-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 07-18-2018
// ***********************************************************************
// <copyright file="RegistarPage.xaml.cs" company="ChowderApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ChowderApp.Models;
using ChowderApp.Helpers;

namespace ChowderApp.Pages
{
    /// <summary>
    /// Class RegistarPage.
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistarPage : ContentPage
	{
        /// <summary>
        /// The license API
        /// </summary>
        public LicenseAPI LicenseApi=new LicenseAPI(Constants.LICENSEURL);
        /// <summary>
        /// The license
        /// </summary>
        public License license = new License();
        /// <summary>
        /// The settings
        /// </summary>
        public Settings Settings = new Settings();
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistarPage"/> class.
        /// </summary>
        public RegistarPage ()
		{
			InitializeComponent ();
		}

        /// <summary>
        /// When overridden, allows application developers to customize behavior immediately prior to the <see cref="T:Xamarin.Forms.Page" /> becoming visible.
        /// </summary>
        /// <remarks>To be added.</remarks>
        protected override async void OnAppearing()
	    {
	        base.OnAppearing();
            Settings.Read();
	        if (Settings.Lincenseno != 0)
	        {
	            license = await LicenseApi.Read(Settings.Lincenseno);
	            Loaddata();
	        }
	    }

        /// <summary>
        /// Handles the Clicked event of the Registar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void Registar_Clicked(object sender, EventArgs e)
        {
            Savedata();
            if (Settings.Lincenseno == 0)
            {
                license.ProductId = Constants.PRODUCTID;
                license = await LicenseApi.Write(license);
                Settings.Lincenseno = license.Id;
                Settings.Write();


            }
            else
            {
              await   LicenseApi.Update(license);
            }

        }

        /// <summary>
        /// Savedatas this instance.
        /// </summary>
        private void Savedata()
        {
            license.First = efname.Text;
            license.Last = elname.Text;
            license.Email = eemail.Text;
            license.Company = ecompany.Text;
            license.Address = eaddress.Text;
            license.City = ecity.Text;
            license.State = estate.Text;
            license.Zip = ezip.Text;
            license.Phone = ephone.Text;
        }
        /// <summary>
        /// Loaddatas this instance.
        /// </summary>
        private void Loaddata()
        {
            efname.Text = license.First;
            elname.Text = license.Last;
            ecompany.Text = license.Company;
            eemail.Text = license.Email;
            eaddress.Text = license.Address;
            ecity.Text = license.City;
            estate.Text = license.State;
            ezip.Text = license.Zip;
            ephone.Text = license.Phone;
        }
    }
}