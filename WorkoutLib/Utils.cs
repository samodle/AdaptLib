using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public static class Utils
    {
        public const double LBsPerKG = 2.20462; //2.20462
    }

    public class PriceCheck
    {
        public DateTime LastUpdate { get; set; }
        public AdaptText URL { get; set; } = new AdaptText();
        public double PriceUSD { get; set; } = -1;

        public PriceCheck(DateTime t, string url, double price)
        {
            LastUpdate = t;
            URL = url;
            PriceUSD = price;
        }
    }


    public class AdaptText
    {
        /* TO DO: WRITE GETTER AND SETTER FUNCTIONS HERE */
        public void Add(string s, MisIdiomas i)
        {
            AString.Add(i, s);
        }

        public string EN{ get {return Get(MisIdiomas.english); }}

        public string Get(MisIdiomas lang)
        {
            string r = "";
            AString.TryGetValue(lang, out r);
            return r;
        }

        public Dictionary<MisIdiomas, string> AString = new Dictionary<MisIdiomas, string>();

        #region Constructors
        public AdaptText(string s, MisIdiomas lang)
        {
            AString.Add(lang, s);
        }
        public AdaptText()
        {

        }
        #endregion
    }

}
