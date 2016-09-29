﻿namespace Microsoft.AspNet.OutputCache {
  
    static class CacheDirectives {
        public const string NoCache = "no-cache";
        public const string NoStore = "no-store";
        public const string MaxAge = "max-age=";
        public const string MinFresh = "min-fresh=";
        public const string CacheControl = "Cache-Control";
        public const string Pragma = "Pragma";
        public const string Range = "Range";
    }
}