// ***********************************************************************
// Assembly         : ChowderApp.iOS
// Author           : Bill Banks
// Created          : 07-10-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 07-12-2018
// ***********************************************************************
// <copyright file="AppDelegate.cs" company="Ourweb.net">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ChowderApp;



using Foundation;
using UIKit;

namespace ChowderApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    /// <summary>
    /// Class AppDelegate.
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Platform.iOS.FormsApplicationDelegate" />
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        /// <summary>
        /// Finisheds the launching.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="options">The options.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsMaps.Init();
            string dbname = "stores.db";
            string fpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) ,"..","Library");
            string fullpath = Path.Combine(fpath, dbname);

            LoadApplication(new App(fullpath));
            return base.FinishedLaunching(app, options);
        }
    }
}
