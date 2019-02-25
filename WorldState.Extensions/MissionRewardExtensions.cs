using System.Drawing;

using WorldState.Data.Models;

namespace WorldState.Extensions
{
    public static class MissionRewardExtensions
    {
        public static Color GetColorAsFrameworkType(this MissionReward model)
        {
            return Color.FromArgb(model.Color);
        }
    }
}
