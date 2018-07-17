// ***********************************************************************
// Assembly         : LicenseWebApi
// Author           : Bill Banks
// Created          : 03-23-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 03-27-2018
// ***********************************************************************
// <copyright file="License.cs" company="Ourweb.net">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ChowderApp.Models
{
    /// <summary>
    /// Class License.
    /// </summary>
    public class License
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        

        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the first.
        /// </summary>
        /// <value>The first.</value>
        
        public string First { get; set; }
        /// <summary>
        /// Gets or sets the last.
        /// </summary>
        /// <value>The last.</value>
        
        public string Last { get; set; }
        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        public string Company { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
         
        public string Email { get; set; }
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
        /// Gets or sets the coutry.
        /// </summary>
        /// <value>The coutry.</value>
        public string Coutry { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        public int ProductId { get; set; }
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get; set; }

    }
}