namespace CrudContracts
{
    /// <summary>
    /// Use this interface in conjunction with the DeleteConfirmation or similar decorators
    /// when user interaction is required to perform an action.
    /// </summary>
    public interface IUserInteraction
    {
        bool Confirm(string message);
    }
}
