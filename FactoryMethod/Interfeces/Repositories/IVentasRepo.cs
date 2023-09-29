namespace FactoryMethod.Interfeces.Repositories
{
    public interface IVentasRepo
    {
        Task<(bool Succeeded, string Message)> calcular();
    }
}
