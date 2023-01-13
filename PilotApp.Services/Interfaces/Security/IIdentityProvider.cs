namespace PilotApp
{
    public interface IIdentityProvider<T>
    {
        T GetCurrentUserId();
    }
}