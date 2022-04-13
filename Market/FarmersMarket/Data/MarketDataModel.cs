using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FarmersMarket.Data
{
    public class MarketDataModel
    {
        public List<Vector2> ShopLocations { get; set; }
        public Dictionary<string, string> ShopOwners { get; set; }
    }
}