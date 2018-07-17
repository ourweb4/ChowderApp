// ***********************************************************************
// Assembly         : ChowderApp
// Author           : Bill Banks
// Created          : 07-13-2018
//
// Last Modified By : Bill Banks
// Last Modified On : 07-14-2018
// ***********************************************************************
// <copyright file="Database.cs" company="ChowderApp">
//     Copyright (c) Ourweb.net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ChowderApp.Models;
using SQLite;

namespace ChowderApp.Helpers
{
    /// <summary>
    /// Class Database.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The connection
        /// </summary>
        private SQLiteConnection conn;
        /// <summary>
        /// The record total
        /// </summary>
        public int RecTotal = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
        {
            conn = new SQLiteConnection(App.DbLocation);
            conn.CreateTable<StoreEntity>();
        }

        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns>ObservableCollection&lt;StoreEntity&gt;.</returns>
        public ObservableCollection<StoreEntity> Read()
        {
            var temp = conn.Table<StoreEntity>().ToList();
            RecTotal = temp.Count();
            ObservableCollection<StoreEntity> stores = new ObservableCollection<StoreEntity>();
            foreach (var rec in temp)
            {
                stores.Add(rec);
            }
            return stores; 
        }
        /// <summary>
        /// Emptyrecses this instance.
        /// </summary>
        public void Emptyrecs()
        {
            var recs = Read();
            if (RecTotal > 0)
            {
                foreach (var rec in recs)
                {
                    conn.Delete<StoreEntity>(rec.StoreId); 
                }

                RecTotal = 0;
            }
        }

        /// <summary>
        /// Writes the specified thelist.
        /// </summary>
        /// <param name="thelist">The thelist.</param>
        /// <returns>System.Int32.</returns>
        public int Write(ObservableCollection<StoreEntity> thelist)
        {
            int recs = 0;
            Emptyrecs();

            foreach (var rec in thelist)
            {
                conn.Insert(rec);

                recs++;
            }
            RecTotal = recs;
            return recs;
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Database"/> class.
        /// </summary>
        ~Database()

        {
            conn.Close();
        }
    }
}
