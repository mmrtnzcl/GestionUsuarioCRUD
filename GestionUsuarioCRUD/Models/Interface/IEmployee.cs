namespace GestionUsuarioCRUD.Models.Interface
{
    public interface IEmployee
    {
        string GetName();
        int GetId();
        abstract decimal GetSalario();
    }
}
