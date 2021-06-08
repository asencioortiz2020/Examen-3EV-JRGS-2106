using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;

namespace UnitTestProject1
{
    [TestClass]
    public class Examen3EvTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;
            int susE = 3;
            int aprE = 1;
            int notE = 2;
            int sbrE = 1;

            for (int i = 0; i < notas.Count; i++)
            {
                Assert.AreEqual(mediaEsperada, notas[i]);
            }

        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void prueba_listaNotas_vacia_devuelveExcepcion()
        {
            List<int> notas = new List<int>();
            ConjuntoNotas nota = new ConjuntoNotas();

            //Probamos que la lista tiene un tamaño menor que 0 // NO VÁLIDO
            notas.Add(-1);
            nota.calculaMedia(notas);


        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void prueba_listaNotas_Incorrectas_devuelevExcepcion()
        {
            List<int> notas = new List<int>();
            ConjuntoNotas nota = new ConjuntoNotas();

            //Probamos que la lista tiene un tamaño menor que 0 // NO VÁLIDO
            notas.Add(60);
            nota.calculaMedia(notas);


        }
        [TestMethod]
        public void prueba_notasValidas()
        {
            List<int> notas = new List<int>();

            notas.Add(5);
            notas.Add(5);
            notas.Add(5);


            double mediaEsperada = 5.00;


            for (int i = 0; i < notas.Count; i++)
            {
                Assert.AreEqual(mediaEsperada, notas[i]);
            }

        }
        [TestMethod]
        public void prueba_Aprobados()
        {

            ConjuntoNotas nota = new ConjuntoNotas();

            List<int> notas = new List<int>();

            double mediaEsperada = 5.00;


            notas.Add(4);
            notas.Add(5);
            notas.Add(5);

            bool res = nota.AprobadosySuspensos(notas, mediaEsperada);
            bool esperado = true;



            Assert.AreEqual(esperado, res);



        }
    }
}
