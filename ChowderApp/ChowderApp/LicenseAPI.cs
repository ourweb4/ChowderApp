// ***********************************************************************
// Assembly         : ChowderApp
// Author           : Bill Banks
// Created          : 07-16-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 07-16-2018
// ***********************************************************************
// <copyright file="LicenseAPI.cs" company="ChowderApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using ChowderApp.Models;
using System.Threading.Tasks;

namespace ChowderApp
{
    /// <summary>
    /// Class LicenseAPI.
    /// </summary>
    public class LicenseAPI
    {
        /// <summary>
        /// The endpoint
        /// </summary>
        private const string ENDPOINT = "/api/licenses/";

        /// <summary>
        /// The surl
        /// </summary>
        public string surl;
        /// <summary>
        /// The client
        /// </summary>
        public HttpClient client;
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAPI" /> class.
        /// </summary>
        /// <param name="purl">The purl.</param>
        public LicenseAPI(string purl)
        {
            surl = purl;
            client = new HttpClient();
            client.BaseAddress = new Uri(surl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Reads the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;License&gt;.</returns>
        public async Task<License> Read(int  id)
        {
            License license = new License();
            string response = await client.GetStringAsync(ENDPOINT + id.ToString());
            license = JsonConvert.DeserializeObject<License>(response);

            return license;
        }

        /// <summary>
        /// Writes the specified license.
        /// </summary>
        /// <param name="license">The license.</param>
        /// <returns>Task&lt;License&gt;.</returns>
        public async Task<License> Write(License license)
        {
            var json = JsonConvert.SerializeObject(license);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            var response = await client.PostAsync(ENDPOINT, content);

            var lic = JsonConvert.DeserializeObject<License>(await  response.Content.ReadAsStringAsync());
            return lic;
        }

        /// <summary>
        /// Updates the specified license.
        /// </summary>
        /// <param name="license">The license.</param>
        /// <returns>Task.</returns>
        public async Task Update(License license)
        {
            var json = JsonConvert.SerializeObject(license);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            var response = await client.PutAsync(ENDPOINT+license.Id.ToString(), content);

        }
    }
}
