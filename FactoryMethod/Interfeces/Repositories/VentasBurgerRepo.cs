namespace FactoryMethod.Interfeces.Repositories
{
    public class VentasBurgerRepo : IVentasRepo
    {
        public async Task<(bool Succeeded, string Message)> calcular()
        {
            try
            {
                return(true, "Exitoso Burger");
            }catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
