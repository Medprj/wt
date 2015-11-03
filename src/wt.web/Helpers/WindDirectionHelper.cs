namespace wt.web.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class WindDirectionHelper
    {
        private static readonly List<CardinalDirection> CardinalDirection = new List<CardinalDirection>()
        {
            new CardinalDirection {Name =  "North", ShortName = "n", RuName = "Северный"},
            new CardinalDirection {Name =  "North Northeast", ShortName = "nne", RuName = "Cеверо-Cеверо-восточный"},
            new CardinalDirection {Name =  "Northeast", ShortName = "ne", RuName = "Северо-восточный"},
            new CardinalDirection {Name =  "East Northeast", ShortName = "ene", RuName = "Востоко-северо-восточный"},
            new CardinalDirection {Name =  "East", ShortName = "e", RuName = "Восточный"},
            new CardinalDirection {Name =  "East Southeast", ShortName = "ese", RuName = "Востоко-юго-восточный"},
            new CardinalDirection {Name =  "Southeast", ShortName = "se", RuName = "Югово-сточный"},
            new CardinalDirection {Name =  "South Southeast", ShortName = "sse", RuName = "Юго-юго-восточный"},
            new CardinalDirection {Name =  "South", ShortName = "s", RuName = "Южный"},
            new CardinalDirection {Name =  "South Southwest", ShortName = "ssw", RuName = "Юго-юго-западный"},
            new CardinalDirection {Name =  "Southwest", ShortName = "sw", RuName = "Юго-западный"},
            new CardinalDirection {Name =  "West Southwest", ShortName = "wsw", RuName = "Западо-юго-запад"},
            new CardinalDirection {Name =  "West", ShortName = "w", RuName = "Западный"},
            new CardinalDirection {Name =  "West Northwest", ShortName = "wnw", RuName = "Западо-северо-западный"},
            new CardinalDirection {Name =  "Northwest", ShortName = "nw", RuName = "Северо-западный"},
            new CardinalDirection {Name =  "North Northwest", ShortName = "nnw", RuName = "Северо-северо-западный"},
        };

        public static string GetDirection(float deg)
        {
            var compass = (int)Math.Round((deg - 11.25) / 22.5);
            return CardinalDirection[compass].RuName;
        }

        public static string GetDirection(string reduction)
        {
            var direction = CardinalDirection.FirstOrDefault(x => x.ShortName.ToUpper() == reduction.ToUpper());

            return direction != null 
                ? direction.RuName 
                : string.Empty;
        }
    }
}