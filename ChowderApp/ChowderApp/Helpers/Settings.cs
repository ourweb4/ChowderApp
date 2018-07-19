// ***********************************************************************
// Assembly         : ChowderApp
// Author           : Bill Banks
// Created          : 07-14-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 07-15-2018
// ***********************************************************************
// <copyright file="Settings.cs" company="ChowderApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ChowderApp.Helpers
{
    /// <summary>
    /// Class Settings.
    /// </summary>
    public class Settings
    {
        // Valeus
        /// <summary>
        /// The userzip
        /// </summary>
        public string Userzip = "";
        /// <summary>
        /// The distance
        /// </summary>
        public int Distance = 5;
        /// <summary>
        /// The automatic load
        /// </summary>
        public bool AutoLoad = true;
        public int Lincenseno = 0;

        // Keys
        /// <summary>
        /// The keyuserzip
        /// </summary>
        private const string KEYUSERZIP = "userzip";
        /// <summary>
        /// The keydistance
        /// </summary>
        private const string KEYDISTANCE = "distance";
        /// <summary>
        /// The keyautoload
        /// </summary>
        private const string KEYAUTOLOAD = "autoload";
        private const string KEYLICENSENO = "licenseno";
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        public Settings()
        {
            Read();
        }


        /// <summary>
        /// Reads this instance.
        /// </summary>
        public void Read()
        {
            if (Application.Current.Properties.ContainsKey(KEYUSERZIP))
                Userzip = Application.Current.Properties[KEYUSERZIP].ToString();
            if (Application.Current.Properties.ContainsKey(KEYDISTANCE))
                Distance = (int)Application.Current.Properties[KEYDISTANCE];
            if (Application.Current.Properties.ContainsKey(KEYAUTOLOAD))
                AutoLoad = (bool)Application.Current.Properties[KEYAUTOLOAD];
            if (Application.Current.Properties.ContainsKey(KEYLICENSENO))
                Lincenseno = (int)Application.Current.Properties[KEYLICENSENO];
        }

        /// <summary>
        /// Writes this instance.
        /// </summary>
        public void Write()
        {
            Application.Current.Properties[KEYUSERZIP] = Userzip;
            Application.Current.Properties[KEYDISTANCE] = Distance;
            Application.Current.Properties[KEYAUTOLOAD] = AutoLoad;
            Application.Current.Properties[KEYLICENSENO] = Lincenseno;

            Application.Current.SavePropertiesAsync();
        }
    }
}
