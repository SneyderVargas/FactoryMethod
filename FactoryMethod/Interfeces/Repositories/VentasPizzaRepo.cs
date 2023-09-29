namespace FactoryMethod.Interfeces.Repositories
{
    public class VentasPizzaRepo: IVentasRepo
    {
        public async Task<(bool Succeeded, string Message)> calcular()
        {
            try
            {
                return (true, "Exitoso Pizza");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
