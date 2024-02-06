namespace ejercicio4Filas
{
    /// <summary>
    /// Clase principal del programa
    /// msm - 050224
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo que contiene el procedimiento del programa
        /// msm - 050224
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("INDIQUE SU FECHA DE NACIMIENTO");
            Console.WriteLine("--------------------------------");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());

            DateTime fechaHoy = DateTime.Now;
            Console.WriteLine(fechaNacimiento);
            int añosModificados = fechaHoy.Year - fechaNacimiento.Year;
            int mesesModificados = fechaHoy.Month - fechaNacimiento.Month;
            int diasModificados = fechaHoy.Day - fechaNacimiento.Day;
            
            //ESTE IF NOS AYUDARA A AJUSTAR EL MES, EN CASO DE MES SEA NEGATIVO 
            //O QUE ESTESMOS EN EL MES PERO TODAVIA NO HAYAMOS PASADO EL DIA
            //SE RESTARA UN AÑO Y LE SUMAREMOS A LOS MESES, 12 MESES (QUE SERIA EQUIVALENTE A ESE AÑO QUE TODAVIA NO SE HA CUMPLIDO
         
            if(mesesModificados < 0 || (mesesModificados ==0 && diasModificados < 0)) 
            {
                añosModificados--;
                mesesModificados += 12;
            }
            
            //ESTE IF SE ENCARGA DE RESTAR MESES, EN EL CASO DE QUE LOS DIAS SEAN NEGATIVOS, SE RESTA MESES YA QUE TODAVIA 
            //YA QUE EL DIA ACTUAL TODAVIA NO HAY LLEGADO AL DIA DE NACIMIENTO (OJO EL DIA, NO EL DIA Y MES)
            if(diasModificados < 0)
            {
                mesesModificados--;
            }

            DateTime fechaFinal = new DateTime(añosModificados, mesesModificados, diasModificados);       
            Console.WriteLine("  ");
            Console.WriteLine("SU FECHA NACIMIENTO");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(fechaFinal.ToString("yy"+" AÑOS "+ "M" +" NESES "+ "d"+ " DIAS "));
           

        }
    }
}