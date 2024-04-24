namespace DI_Example.Contracts
{
    public interface ITask2
    {
        void DoTransientWork();
        void DoSingletonWork();
        void DoScopedWork();
    }
}
