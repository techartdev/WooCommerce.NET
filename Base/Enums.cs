using System;
using System.Collections.Generic;
using System.Text;

namespace WooCommerce.NET.Base
{
    public enum RequestMethod
    {
        Head = 1,
        Get = 2,
        Post = 3,
        Put = 4,
        Patch = 5,
        Delete = 6
    }

    public enum ApiVersion
    {
        Unknown = 0,
        Version3 = 1,
        WordPressApi = 90,
        WordPressApijwt = 91,
        ThirdPartyPlugins = 99
    }
}
