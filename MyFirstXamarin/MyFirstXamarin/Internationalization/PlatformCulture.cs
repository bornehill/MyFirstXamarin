using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Internationalization
{
    public class PlatformCulture
    {
        public string PlatformStr { get; private set; }
        public string LanguageCode { get; private set; }
        public string LocaleCode { get; private set; }

        public PlatformCulture(string platfomCultureStr)
        {
            if (String.IsNullOrEmpty(platfomCultureStr))
                throw new ArgumentException("Expected culture identifier", "platform culture");

            PlatformStr = platfomCultureStr.Replace("_", "-");
            var dashIndex = PlatformStr.IndexOf("-", StringComparison.Ordinal);
            if (dashIndex > 0)
            {
                var parts = PlatformStr.Split('-');
                LanguageCode = parts[0];
                LocaleCode = parts[1];
            }
            else {
                LanguageCode = PlatformStr;
                LocaleCode = "";
            }

        }

        public override string ToString()
        {
            return PlatformStr;
        }
    }
}
