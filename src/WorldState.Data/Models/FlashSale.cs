using Newtonsoft.Json;
using System;

namespace WorldState.Data.Models
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
		private bool HasExpired { get; set; }

        [JsonIgnore]
        public bool IsActive => !HasExpired;

		[JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
	}
}