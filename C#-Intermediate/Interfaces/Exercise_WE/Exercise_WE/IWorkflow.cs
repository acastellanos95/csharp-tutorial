namespace Exercise_WE
{
    public interface IWorkflow
    {
        void AddActivity(IActivity activity);
        void RemoveActivity(IActivity activity);
        void Run();
    }
}
