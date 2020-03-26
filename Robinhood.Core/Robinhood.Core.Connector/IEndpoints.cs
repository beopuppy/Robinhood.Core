using System;

namespace Robinhood.Core.Connector
{
    public interface IEndpoints
    {
        /// <summary>
        /// Gets the Login endpoint
        /// </summary>
        /// <returns>string login url</returns>
        string Login();

        /// <summary>
        /// Gets the Logout endpoint
        /// </summary>
        /// <returns>string logout url</returns>
        string Logout();

        /// <summary>
        /// Gets the Accounts endpoint
        /// </summary>
        /// <returns>string accounts url</returns>
        string Accounts();

        /// <summary>
        /// Gets the ACH endpoint
        /// </summary>
        /// <param name="option">Can be either "iav", "relationships", or "transfers"</param>
        /// <returns>string ACH url</returns>
        string ACH(string option);

        /// <summary>
        /// Gets the applications endpoint
        /// </summary>
        /// <returns>string applications url</returns>
        string Applications();

        /// <summary>
        /// Gets the dividends endpoint
        /// </summary>
        /// <returns>string dividends url</returns>
        string Dividends();

        /// <summary>
        /// Returns information about a specific instrument by providing its instrument id.
        /// Add extra options for additional information such as "popularity"
        /// </summary>
        /// <param name="instrumentId">string Ticker symbol or Instrument ex. "MSFT"</param>
        /// <param name="option">string optional filters</param>
        /// <returns>string instruments url</returns>
        string Instruments(string instrumentId, string option);

        /// <summary>
        /// Gets the Margin Upgrade endpoint
        /// </summary>
        /// <returns>string margin upgrde url</returns>
        string MarginUpgrades();

        /// <summary>
        /// Gets the Markets endpoint
        /// </summary>
        /// <returns>string markets url</returns>
        string Markets();

        /// <summary>
        /// Gets the Notifications endpoint
        /// </summary>
        /// <returns>string notifications url</returns>
        string Notifications();

        /// <summary>
        /// Gets the Order endpoint and a list of orders or a specific order if an order id was given.
        /// </summary>
        /// <param name="orderId">string order id token</param>
        /// <returns>string orders url</returns>
        string Orders(string orderId);

        /// <summary>
        /// Gets the password reset endpoint
        /// </summary>
        /// <returns>string password reset url</returns>
        string PasswordReset();

        /// <summary>
        /// Gets the portfolios endpoint. This endpoint returns all portfolios
        /// belonging to a user
        /// </summary>
        /// <returns>string portfolios url</returns>
        string Portfolios();

        /// <summary>
        /// Gets the positions endpoint
        /// </summary>
        /// <returns>string positions url</returns>
        string Positions();

        /// <summary>
        /// Gets the quotes endpoint. This endpoint can be used to request a quote for a specific instrument.
        /// </summary>
        /// <returns>string quotes url</returns>
        string Quotes();

        /// <summary>
        /// Gets the historicals endpoint
        /// </summary>
        /// <returns>string historicals url</returns>
        string Historicals();

        /// <summary>
        /// Gets the document requests endpoint
        /// </summary>
        /// <returns>string document requests url</returns>
        string DocumentRequests();

        /// <summary>
        /// Gets the user endpoint
        /// </summary>
        /// <returns>string user url</returns>
        string User();

        /// <summary>
        /// Gets the watchlists endpoint
        /// </summary>
        /// <returns>string watchlists url</returns>
        string Watchlists();

        /// <summary>
        /// Gets the news endpoint. The news endpoint can be used to retrieve all the news for a specific stock
        /// </summary>
        /// <param name="stock">required. stock ticker symbol</param>
        /// <returns>string news url</returns>
        string News(string stock);

        /// <summary>
        /// Gets the fundamentals endpoint for a specific stock
        /// </summary>
        /// <param name="stock">required, string</param>
        /// <returns>string fundamentals url</returns>
        string Fundamentals(string stock);

        /// <summary>
        /// Gets the tags endpoint.
        /// </summary>
        /// <param name="tag">nullable, string</param>
        /// <returns>string tags url</returns>
        string Tags(string tag);

        /// <summary>
        /// Gets the chain endpoint
        /// </summary>
        /// <param name="instrumentId">required, string, id of the instrument your are getting the chain for</param>
        /// <returns>string chain url</returns>
        string Chain(string instrumentId);

        /// <summary>
        /// Gets the options endpoint
        /// </summary>
        /// <param name="chainId">require, string</param>
        /// <param name="expirationDate">required, date/time</param>
        /// <param name="optionType">required, string</param>
        /// <returns>string options url</returns>
        string Options(string chainId, DateTime expirationDate, string optionType);
        
        /// <summary>
        /// Gets the market data endpoint for options
        /// </summary>
        /// <param name="optionId">required, string</param>
        /// <returns>string market data url</returns>
        string MarketData(string optionId);

        /// <summary>
        /// Gets the convert token endpoint
        /// </summary>
        /// <returns>string convert token url</returns>
        string ConvertToken();
    }
}