﻿namespace FactoryMethod.Interfeces.Repositories
{
    public class VentasBurgerRepo : IVentasRepo
    {
        public string calcular()
        {
            try
            {
                return("Exitoso Burger 2");
            }catch (Exception ex)
            {
                return (ex.Message);
            }
        }
    }
}
