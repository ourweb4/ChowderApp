// ***********************************************************************
// Assembly         : StoresApp
// Author           : Bill Banks
// Created          : 12-02-2017
//
// Last Modified By : Bill Banks
// Last Modified On : 12-02-2017
// ***********************************************************************
// <copyright file="Store.cs" company="Ourweb.net">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChowderApp.Models
{

    /// <summary>
    /// Class StoreEntity.
    /// </summary>
    public class StoreEntity
    {
        /// <summary>
        /// Gets or sets the store identifier.
        /// </summary>
        /// <value>The store identifier.</value>
        [PrimaryKey]
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets the masterid.
        /// </summary>
        /// <value>The masterid.</value>
     //   public int Masterid { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>The zip.</value>
        public string Zip { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [show website].
        /// </summary>
        /// <value><c>true</c> if [show website]; otherwise, <c>false</c>.</value>
        public bool ShowWebsite { get; set; }
        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        /// <value>The website.</value>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show email].
        /// </summary>
        /// <value><c>true</c> if [show email]; otherwise, <c>false</c>.</value>
        public bool ShowEmail { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the sun.
        /// </summary>
        /// <value>The sun.</value>
        public string Sun { get; set; }

        /// <summary>
        /// Gets or sets the mon.
        /// </summary>
        /// <value>The mon.</value>
        public string Mon { get; set; }
        /// <summary>
        /// Gets or sets the tue.
        /// </summary>
        /// <value>The tue.</value>
        public string Tue { get; set; }
        /// <summary>
        /// Gets or sets the wed.
        /// </summary>
        /// <value>The wed.</value>
        public string Wed { get; set; }
        /// <summary>
        /// Gets or sets the thu.
        /// </summary>
        /// <value>The thu.</value>
        public string Thu { get; set; }
        /// <summary>
        /// Gets or sets the fri.
        /// </summary>
        /// <value>The fri.</value>
        public string Fri { get; set; }
        /// <summary>
        /// Gets or sets the sat.
        /// </summary>
        /// <value>The sat.</value>
        public string Sat { get; set; }

        public double Lat { get; set; }
        public double Lng { get; set; }



    }
}

