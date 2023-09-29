namespace FactoryMethod.Interfeces.Repositories
{
    public class VentasPizzaRepo: IVentasRepo
    {
        public string calcular()
        {
            try
            {
                return ("Exitoso Pizza");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
    }
}
