namespace Tech_Potential_Challenge_Payment_API.UoW.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        Task<bool> Commit();
        Task Roolback();
    }
}