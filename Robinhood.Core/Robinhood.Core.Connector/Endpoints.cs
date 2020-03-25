using System;
using System.Collections.Generic;
using System.Text;

namespace Robinhood.Core.Connector
{
    public class Endpoints
    {
        private string api_url = "https://api.robinhood.com";
        
        /// <summary>
        /// Gets the Login endpoint
        /// </summary>
        /// <returns>string login url</returns>
        public string Login()
        {
            return $"{api_url}/oauth/token/"; 
        }

        /// <summary>
        /// Gets the Logout endpoint
        /// </summary>
        /// <returns>string logout url</returns>
        public string Logout()
        { 
            return $"{api_url}/user/investment_profile/"; 
        }

        /// <summary>
        /// Gets the Accounts endpoint
        /// </summary>
        /// <returns>string accounts url</returns>
        public string Accounts()
        {
            return $"{api_url}/accounts/"; 
        }

        /// <summary>
        /// Gets the ACH endpoint
        /// </summary>
        /// <param name="option">Can be either "iav", "relationships", or "transfers"</param>
        /// <returns>string ACH url</returns>
        public string ACH(string option = "iav")
        {
            return option == "iav" ? $"{api_url}/ach/iav/auth/" : $"{api_url}/ach/{option.ToLower()}/";
        }

        /// <summary>
        /// Gets the applications endpoint
        /// </summary>
        /// <returns>string applications url</returns>
        public string Applications()
        {
            return $"{api_url}/applications/";
        }

        /// <summary>
        /// Gets the dividends endpoint
        /// </summary>
        /// <returns>string dividends url</returns>
        public string Dividends()
        {
            return $"{api_url}/dividends/";
        }

        /// <summary>
        /// Returns information about a specific instrument by providing its instrument id.
        /// Add extra options for additional information such as "popularity"
        /// </summary>
        /// <param name="instrumentId">string Ticker symbol or Instrument ex. "MSFT"</param>
        /// <param name="option">string optional filters</param>
        /// <returns>string instruments url</returns>
        public string Instruments(string instrumentId="", string option = "" )
        {

            return $"{api_url}/instruments/{instrumentId}/{option}";
        }

        /// <summary>
        /// Gets the Margin Upgrade endpoint
        /// </summary>
        /// <returns>string margin upgrde url</returns>
        public string MarginUpgrades()
        {
            return $"{api_url}/margin/upgrades/";
        }

        /// <summary>
        /// Gets the Markets endpoint
        /// </summary>
        /// <returns>string markets url</returns>
        public string Markets()
        {
            return $"{api_url}/markets/";
        }

        /// <summary>
        /// Gets the Notifications endpoint
        /// </summary>
        /// <returns>string notifications url</returns>
        public string Notifications()
        {
            return $"{api_url}/notifications/";
        }

        /// <summary>
        /// Gets the Order endpoint and a list of orders or a specific order if an order id was given.
        /// </summary>
        /// <param name="orderId">string order id token</param>
        /// <returns>string orders url</returns>
        public string Orders(string orderId = "")
        {
            return $"{api_url}/orders/{orderId}";
        }

        /// <summary>
        /// Gets the password reset endpoint
        /// </summary>
        /// <returns>string password reset url</returns>
        public string PasswordReset()
        {
            return $"{api_url}/password_reset/request/";
        }

        /// <summary>
        /// Gets the portfolios endpoint. This endpoint returns all portfolios
        /// belonging to a user
        /// </summary>
        /// <returns>string portfolios url</returns>
        public string Portfolios()
        {
            return $"{api_url}/portfolios/";
        }

        /// <summary>
        /// Gets the positions endpoint
        /// </summary>
        /// <returns>string positions url</returns>
        public string Positions()
        {
            return $"{api_url}/positions/";
        }

        /// <summary>
        /// Gets the quotes endpoint. This endpoint can be used to request a quote for a specific instrument.
        /// </summary>
        /// <returns>string quotes url</returns>
        public string Quotes()
        {
            return $"{api_url}/quotes/";
        }

        /// <summary>
        /// Gets the historicals endpoint
        /// </summary>
        /// <returns>string historicals url</returns>
        public string Historicals()
        {
            return $"{api_url}/historicals/";
        }

        /// <summary>
        /// Gets the document requests endpoint
        /// </summary>
        /// <returns>string document requests url</returns>
        public string DocumentRequests()
        {
            return $"{api_url}/document_requests/";
        }

        /// <summary>
        /// Gets the user endpoint
        /// </summary>
        /// <returns>string user url</returns>
        public string User()
        {
            return $"{api_url}/user/";
        }

        /// <summary>
        /// Gets the watchlists endpoint
        /// </summary>
        /// <returns>string watchlists url</returns>
        public string Watchlists()
        {
            return $"{api_url}/watchlists/";
        }

        /// <summary>
        /// Gets the news endpoint. The news endpoint can be used to retrieve all the news for a specific stock
        /// </summary>
        /// <param name="stock">required. stock ticker symbol</param>
        /// <returns>string news url</returns>
        public string News(string stock)
        {
            return $"{api_url}/midlands/news/{stock}";
        }


        /// <summary>
        /// Gets the fundamentals endpoint for a specific stock
        /// </summary>
        /// <param name="stock">required, string</param>
        /// <returns>string fundamentals url</returns>
        public string Fundamentals(string stock)
        {
            return $"{api_url}/fundamentals/{stock}";
        }

        /// <summary>
        /// Gets the tags endpoint.
        /// </summary>
        /// <param name="tag">nullable, string</param>
        /// <returns>string tags url</returns>
        public string Tags(string tag="")
        {
            return $"{api_url}/midlands/tags/tag/{tag}";
        }

        /// <summary>
        /// Gets the chain endpoint
        /// </summary>
        /// <param name="instrumentId">required, string, id of the instrument your are getting the chain for</param>
        /// <returns>string chain url</returns>
        public string Chain(string instrumentId)
        {
            return $"{api_url}/options/chains?equity_instrument_ids={instrumentId}";
        }

        /// <summary>
        /// Gets the options endpoint
        /// </summary>
        /// <param name="chainId">require, string</param>
        /// <param name="expirationDate">required, date/time</param>
        /// <param name="optionType">required, string</param>
        /// <returns>string options url</returns>
        public string Options(string chainId, DateTime expirationDate, string optionType)
        {
            return $"{api_url}/options/instruments/?chain_id={chainId}&expiration_dates={expirationDate.ToString()}&state=active&tradability=tradable&type={optionType}";
        }

        /// <summary>
        /// Gets the market data endpoint for options
        /// </summary>
        /// <param name="optionId">required, string</param>
        /// <returns>string market data url</returns>
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

