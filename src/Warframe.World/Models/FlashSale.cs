using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
	public class FlashSale
	{
		[JsonProperty]
		public string Item { get; private set; }

		[JsonProperty("expiry")]
		public DateTimeOffset ExpiresAt { get; private set; }

		[JsonProperty]
		public int Discount { get; private set; }

		[JsonProperty]
		public int PremiumOverride { get; private set; }

		[JsonProperty]
		public bool IsFeatured { get; private set; }

		[JsonProperty]
		public bool IsPopular { get; private set; }

		[JsonProperty]
		public string Id { get; private set; }

		[JsonProperty("expired")]
		public bool HasExpired { get; private set; }

		[JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
	}
}