﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SimpleCRM.Data.Extensions {

  static class HelpExtensions {
    static readonly CultureInfo frBECulture = new CultureInfo( 2060 ); // fr-BE

    internal static DateTime ToDateTime(this string stringDate) => DateTime.Parse( stringDate, frBECulture );
  }
}