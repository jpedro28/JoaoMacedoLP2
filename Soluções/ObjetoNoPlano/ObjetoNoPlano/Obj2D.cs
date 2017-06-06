using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoNoPlano
{
    class Obj2D
    {
         public int x, y;

        public void AndDir() {
            x++;
        }

        public void AndEsq() {
            x--;
        }

        public void Subir() {
            y++;
        }

        public void Descer() {
            y--;
    }
}
