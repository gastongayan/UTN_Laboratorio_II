namespace LogicaNegocio
{
    public static class ConversorDeTemperatura
    {

        private const float ceroAbsoluto = 273.15f;

        /// <summary>
        /// Convierte temperaturas de Celsius a Kelvin
        /// </summary>
        /// <param name="temperaturaCelsius"></param>
        /// <returns>temperatura en Kelvin</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            return temperaturaCelsius + ceroAbsoluto;
            
        }

        /// <summary>
        /// Convierte temperaturas de Kelvin a Celsius
        /// 
        /// </summary>
        /// <param name="temperaturaKelvin"></param>
        /// <returns>temperatura en Celsius</returns>

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;

        }


    }
}