using System.Collections.Generic;

namespace Examen3EV_NS
{
    /// <summary>
    /// En la clase vamos a introducir un conjunto de notas y vemos la nota media,suspensos,aprobados,etc
    /// </summary>
    public class ConjuntoNotas  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {

        private int suspensos;  // Suspensos         //ASEOR2021
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        private double Notamedia; // Nota media

        private const string listaVacia = "No hay nada";
        private const string notasIncorrectas = "las notas introducidas no son válidas";    //ASEOR2021

        /// <summary>
        /// El constructor está vacío y se incializan los tipos de nota y la notaMedia a 0
        /// </summary>
        /// <remarks>No es necesariopasarle parámetros al constructor</remarks>
        // Constructor vacío
        public ConjuntoNotas()
        {
            suspensos = aprobados = notables = sobresalientes = 0;  // inicializamos las variables
            Notamedia = 0.0;

        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        /// <summary>
        /// A este método le pasamos una lista con notas y nos dice el tipo de nota
        /// </summary>
        /// <param name="listaNotas">Este método tiene como parámetro una lista de notas</param>

        public ConjuntoNotas(List<int> listaNotas)
        {
            Notamedia = 0.0;
            //ASEOR2021
            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5)
                {
                    suspensos++;              // Por debajo de 5 suspenso
                }
                else if (listaNotas[i] > 5 && listaNotas[i] < 7)
                {
                    aprobados++;// Nota para aprobar: 5
                }
                else if (listaNotas[i] > 7 && listaNotas[i] < 9)
                {
                    notables++;// Nota para notable: 7
                }
                else if (listaNotas[i] > 9)
                {
                    sobresalientes++;         // Nota para sobresaliente: 9
                }


                Notamedia = Notamedia + listaNotas[i];



            }

            Notamedia = Notamedia / listaNotas.Count;
        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario
        /// <summary>
        /// A este método se le pasa una lista de notas y nos devuelve la nota media
        /// </summary>
        /// <param name="listnot"></param>
        /// <returns>Esta función nos devuelve un double</returns>
        public double calculaMedia(List<int> listnot)
        {
            Notamedia = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
            {
                throw new System.ArgumentOutOfRangeException(listaVacia);

            }

            //return -1;

            for (int i = 0; i < 10; i++)
            {
                if (listnot[i] < 0 || listnot[i] > 10)
                {
                    throw new System.ArgumentOutOfRangeException(notasIncorrectas);
                }
            }
            // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
            //return -1;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5)
                {
                    suspensos++;              // Por debajo de 5 suspenso
                }

                else if (listnot[i] >= 5 && listnot[i] < 7)
                {
                    aprobados++;// Nota para aprobar: 5
                }

                else if (listnot[i] >= 7 && listnot[i] < 9)
                {
                    notables++;// Nota para notable: 7
                }

                else if (listnot[i] > 9)
                {
                    sobresalientes++;         // Nota para sobresaliente: 9
                }


                Notamedia = Notamedia + listnot[i];
            }

            Notamedia = Notamedia / listnot.Count;

            return Notamedia;
        }
        public bool AprobadosySuspensos(List<int> listnot, double notaMedia)
        {

            bool res = false;

            for (int i = 0; i < 10; i++)
            {
                if (notaMedia >= 5)
                {
                    res = true;
                }
            }

            return res;
        }
    }
}
