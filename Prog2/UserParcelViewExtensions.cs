namespace UPVApp;

/// <summary>
/// Extensions for the <see cref="UserParcelView"/>, without modifying its public API.
/// </summary>
internal static class UserParcelViewExtensions
{
    public static Address GetRandomAddress(this UserParcelView upv) =>
        upv.AddressAt(Random.Shared.Next(0, upv.AddressCount));
}
