using CampaignManager.Infrastructure.Models.ConfigModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CampaignManager.Infrastructure.Common.Enums.CampaignManagerEnums;

namespace CampaignManager.Data.Core
{
    public class DBAccess : IDBAccess
    {
        private readonly ConnectionStrings _connectionStrings;

        public DBAccess(ConnectionStrings options)
        {
            _connectionStrings = options;
        }

        /// <summary>
        /// Common m
        /// </summary>
        /// <param name="databaseOption"></param>
        /// <param name="returnString"></param>
        /// <returns></returns>
        public string GetDatabaseConnection(DatabaseOptions databaseOption)
        {
            string returnString = "";
            //returnString = @"server=DESKTOP-31OK4EE\SQLEXPRESS;Database=TroonNFT;Integrated Security=true";
            switch (databaseOption)
            {
                case DatabaseOptions.Default:
                    returnString = _connectionStrings.DefaultConnection;
                    break;

                default:
                    returnString = _connectionStrings.DefaultConnection;
                    break;
            }

            return returnString;
        }
    }
}
