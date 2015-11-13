using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoAnima01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoAnimaTest
{
    [TestClass]
    public class MeritoDocenteTeste
    {
        [TestMethod]
        public void DeveObterProfessorMaisVotadoNoCasoSimples()
        {
           
            var meritoDocente = new MeritoDocente();
            var professor = meritoDocente.MaiorNota();
            Assert.AreEqual("Erix",professor);
        }
        [TestMethod]
        public void DeveObterProfessorMaisVotadoNoCasoVotacao()
        {

            var meritoDocente = new MeritoDocente();
            meritoDocente.Votar("Nande",5);

            
            var professor = meritoDocente.MaiorNota();
            Assert.AreEqual("Nande", professor);
        }

        

    }


}
