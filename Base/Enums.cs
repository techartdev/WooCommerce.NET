using System;
using System.Collections.Generic;
using System.Text;

namespace WooCommerce.NET.Base
{
    public enum RequestMethod
    {
        HEAD = 1,
        GET = 2,
        POST = 3,
        PUT = 4,
        PATCH = 5,
        DELETE = 6
    }

    public enum ApiVersion
    {
        Unknown = 0,
        Legacy = 1,
        Version1 = 2,
        Version2 = 3,
        Version3 = 4,
        WordPressAPI = 90,
        WordPressAPIJWT = 91,
        ThirdPartyPlugins = 99
    }
}
