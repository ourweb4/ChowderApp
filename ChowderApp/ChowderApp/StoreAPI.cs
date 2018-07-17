// ***********************************************************************
// Assembly         : StoresApp
// Author           : Bill Banks
// Created          : 12-02-2017
//
// Last Modified By : Bill Banks
// Last Modified On : 06-26-2018
// ***********************************************************************
// <copyright file="StoreAPI.cs" company="Ourweb.net">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using ChowderApp.Models;

namespace ChowderApp
{
    /// <summary>
    /// Class StoreAPI.
    /// </summary>
    class StoreAPI
    {
        /// <summary>
        /// The endpoint
        /// </summary>
        private const string ENDPOINT = "/api/stores/";
        /// <summary>
        /// The zipendpoint
        /// </summary>
        private const string ZIPENDPOINT = "/api/zip?zip=";
        /// <summary>
        /// The placesendpoint
        /// </summary>
        private const string PLACESENDPOINT = "/api/places?zip=";

        /// <summary>
        /// The zipradiusendpoint
        /// </summary>
        private const string ZIPRADIUSENDPOINT = "/api/zipradius?zip=";

        //        public List<StoreEntity> stlist;

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
        public StoreAPI(string purl)
        {
            surl = purl;
            client = new HttpClient();
            client.BaseAddress = new Uri(surl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }

        /// <summary>
        /// Reads all.
        /// </summary>
        /// <returns>Task&lt;List&lt;StoreEntity&gt;&gt;.</returns>
        public async Task< IList<StoreEntity>> ReadAll()
        {
            IList<StoreEntity> stores = new List<StoreEntity>();
          string response = await client.GetStringAsync(ENDPOINT);

            stores = JsonConvert.DeserializeObject<IList<StoreEntity>>(response);
             
             
                return stores;
            
        }


        /// <summary>
        /// Reads the zip all.
        /// </summary>
        /// <param name="zip">The zip.</param>
        /// <returns>Task&lt;List&lt;StoreEntity&gt;&gt;.</returns>
        public async Task<IList<StoreEntity>> ReadZipAll(string zip)
        {
            IList<StoreEntity> stores = new List<StoreEntity>();
            string response = await client.GetStringAsync(ZIPENDPOINT + zip);

            stores = JsonConvert.DeserializeObject<IList<StoreEntity>>(response);

            return stores;

        }

        /// <summary>
        /// Reads the zips radius.
        /// </summary>
        /// <param name="zip">The zip.</param>
        /// <param name="Distance">The distance.</param>
        /// <returns>Task&lt;List&lt;ZipCodes&gt;&gt;.</returns>
        public async Task<List<ZipCodes>> ReadZipsRadius(string zip, int Distance = 5)
        {
            List<ZipCodes> zips = new List<ZipCodes>();
            string response = await client.GetStringAsync(ZIPRADIUSENDPOINT + zip + "&Distance=" + Distance);

            zips = JsonConvert.DeserializeObject<List<ZipCodes>>(response);

            return zips;

        }

        /// <summary>
        /// Reads the place.
        /// </summary>
        /// <param name="zip">The zip.</param>
        /// <returns>Task&lt;Places&gt;.</returns>
        public async Task< Places> ReadPlace(string zip)
        {
            Places place = new Places();
            string response = await client.GetStringAsync(PLACESENDPOINT + zip);
            place = JsonConvert.DeserializeObject<Places>(response);
 
            return place;

        }



    }
}
