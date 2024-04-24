namespace DI_Example.Contracts
{
    public interface ITask1
    {
        void DoTransientWork();
        void DoSingletonWork();
        void DoScopedWork();
    }
}
