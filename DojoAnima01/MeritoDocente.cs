using System;
using System.Collections.Generic;
using System.Linq;

namespace DojoAnima01
{
    public class MeritoDocente
    {
        private readonly Dictionary<string, int> _quadroNotas;

        public MeritoDocente()
        {
            _quadroNotas = new Dictionary<string, int>
            {
                {"Erix", 0},
                {"Nande", 0},
                {"Renato", 0}
            };
        }

        public string MaiorNota()
        {
            var melhorProfessor = _quadroNotas.FirstOrDefault();
            foreach (var quadroNota in _quadroNotas)
            {
                if (melhorProfessor.Value < quadroNota.Value)
                {
                    melhorProfessor = quadroNota;
                }
            }
            return melhorProfessor.Key;
        }

        public void Votar(string professor, int nota)
        {
            if (nota < 0 || nota > 5)
                throw new Exception("Nota deve ser maior ou igual a 0 e menor ou igual a 5");

            var n = _quadroNotas[professor];
            n = n + nota;

            _quadroNotas[professor] = n;
        }

    }

}
