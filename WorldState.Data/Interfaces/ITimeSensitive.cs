using System;

namespace WorldState.Data.Interfaces
{
    /// <summary>
    /// Models implementing this interface has time-sensitive data that may change as real-world (wall-clock) time passes.
    /// Consumers should check the <see cref="ExpiresAt"/> property frequently and obtain updated models when available.
    /// </summary>
    public interface ITimeSensitive
    {
        DateTimeOffset ActivatedAt { get; }
        DateTimeOffset ExpiresAt   { get; }
    }

    public static class TimeSensitiveModelExtensions
    {
        public static bool IsActive(this ITimeSensitive model)
        {
            var now = DateTimeOffset.Now;
            return now >= model.ActivatedAt && now < model.ExpiresAt;
        }

        public static bool HasExpired(this ITimeSensitive model)
        {
            return DateTimeOffset.Now >= model.ExpiresAt;
        }

        public static TimeSpan GetTimeRemaining(this ITimeSensitive model)
        {
            return model.ExpiresAt - DateTimeOffset.Now;
        }
    }
}
