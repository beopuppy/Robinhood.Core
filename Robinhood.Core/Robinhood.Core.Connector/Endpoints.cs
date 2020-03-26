using System;
using System.Collections.Generic;
using System.Text;

namespace Robinhood.Core.Connector
{
    public class Endpoints : IEndpoints
    {
        private readonly string api_url = "https://api.robinhood.com";

        public Endpoints()
        {
        }

        public string Login()
        {
            return $"{api_url}/oauth/token/"; 
        }
        
        public string Logout()
        { 
            return $"{api_url}/user/investment_profile/"; 
        }

        public string Accounts()
        {
            return $"{api_url}/accounts/"; 
        }

        public string ACH(string option = "iav")
        {
            return option == "iav" ? $"{api_url}/ach/iav/auth/" : $"{api_url}/ach/{option.ToLower()}/";
        }

        public string Applications()
        {
            return $"{api_url}/applications/";
        }

        public string Dividends()
        {
            return $"{api_url}/dividends/";
        }

        public string Instruments(string instrumentId="", string option = "" )
        {

            return $"{api_url}/instruments/{instrumentId}/{option}";
        }

        public string MarginUpgrades()
        {
            return $"{api_url}/margin/upgrades/";
        }

        public string Markets()
        {
            return $"{api_url}/markets/";
        }

        public string Notifications()
        {
            return $"{api_url}/notifications/";
        }

        public string Orders(string orderId = "")
        {
            return $"{api_url}/orders/{orderId}";
        }

        public string PasswordReset()
        {
            return $"{api_url}/password_reset/request/";
        }

        public string Portfolios()
        {
            return $"{api_url}/portfolios/";
        }

        public string Positions()
        {
            return $"{api_url}/positions/";
        }

        public string Quotes()
        {
            return $"{api_url}/quotes/";
        }

        public string Historicals()
        {
            return $"{api_url}/historicals/";
        }

        public string DocumentRequests()
        {
            return $"{api_url}/document_requests/";
        }

        public string User()
        {
            return $"{api_url}/user/";
        }

        public string Watchlists()
        {
            return $"{api_url}/watchlists/";
        }

        public string News(string stock)
        {
            return $"{api_url}/midlands/news/{stock}";
        }

        public string Fundamentals(string stock)
        {
            return $"{api_url}/fundamentals/{stock}";
        }

        public string Tags(string tag="")
        {
            return $"{api_url}/midlands/tags/tag/{tag}";
        }

        public string Chain(string instrumentId)
        {
            return $"{api_url}/options/chains?equity_instrument_ids={instrumentId}";
        }

        public string Options(string chainId, DateTime expirationDate, string optionType)
        {
            return $"{api_url}/options/instruments/?chain_id={chainId}&expiration_dates={expirationDate.ToString()}&state=active&tradability=tradable&type={optionType}";
        }

        public string MarketData(string optionId)
        {
            return $"{api_url}/marketdata/options/{optionId}/";
        }

        public string ConvertToken()
        {
            return $"{api_url}/oauth2/migrate_token/";
        }
    }
}

