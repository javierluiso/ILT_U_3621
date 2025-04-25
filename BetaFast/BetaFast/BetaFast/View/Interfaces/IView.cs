namespace ILTU3621.View.Interfaces
{
    public interface IView
    {
        object DataContext { get; set; }
        void Close();
    }
}
