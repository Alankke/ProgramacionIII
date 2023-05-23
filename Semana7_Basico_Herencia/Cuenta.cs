using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasProg3
{
    internal class Cuenta
    {
        private int saldo, cbu;
        private string dueño;

        public Cuenta(string dueño, int saldo, int cbu)
        {
            this.dueño = dueño;
            this.saldo = saldo;
            this.cbu = cbu;
        }

        public int getSaldo() { return saldo; }
        public int getCbu() { return cbu; }
        public string getDueño() { return dueño; }

        public void setSaldo(int saldo)
        {
            this.saldo = saldo;
        }
        public void deposito(int monto)
        {
            this.saldo += monto;
        }
        public void extraccion(int monto)
        {
            this.saldo -= monto;
        }
    }
}
