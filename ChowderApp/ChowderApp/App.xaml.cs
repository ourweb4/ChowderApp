// ***********************************************************************
// Assembly         : ChowderApp
// Author           : Bill Banks
// Created          : 07-10-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 07-12-2018
// ***********************************************************************
// <copyright file="App.xaml.cs" company="ChowderApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ChowderApp
{
    /// <summary>
    /// Class App.
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Application" />
    public partial class App : Application
	{
        /// <summary>
        /// The database location
        /// </summary>
        public static string DbLocation = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(  new MainPage());
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <param name="dblocation">The dblocation.</param>
        public App( string dblocation)
        {
            InitializeComponent();
            DbLocation = dblocation;
            MainPage = new NavigationPage(new MainPage());

        }



        /// <summary>
        /// Application developers override this method to perform actions when the application starts.
        /// </summary>
        /// <remarks>To be added.</remarks>
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

        /// <summary>
        /// Application developers override this method to perform actions when the application enters the sleeping state.
        /// </summary>
        /// <remarks>To be added.</remarks>
        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

        /// <summary>
        /// Application developers override this method to perform actions when the application resumes from a sleeping state.
        /// </summary>
        /// <remarks>To be added.</remarks>
        protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
