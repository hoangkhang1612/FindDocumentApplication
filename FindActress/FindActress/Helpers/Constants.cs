using System;
using System.Collections.Generic;
using System.Text;

namespace FindActress.Helpers
{
    public class Constants
    {
        #region API details

        public const string BaseUrl = "https://jav-rest-api-htpvmrzjet.now.sh/api/";

        public const string LinkActressPath = "actress?name=";

        public const string LinkMoviesPath = "videos";

        #endregion

        public class IconNavigation
        {
            public const string IconRight = "ic_collapse";
            public const string IconDown = "ic_expand";
        }
    }
}
