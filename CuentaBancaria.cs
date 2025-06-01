using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class CuentaBancaria
    {
        private string titular;
        private double saldo;


        public CuentaBancaria(string titular, double saldoInicial)
        {
           this.titular = titular;
           saldo = saldoInicial;
        }


        public string Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                return $"Depósito exitoso: ${cantidad}. Nuevo saldo: ${saldo}";
            }
            else
            {
                return "La cantidad a depositar debe ser mayor que 0.";
            }
        }


        public string Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo -= cantidad;
                return $"Retiro exitoso: ${cantidad}. Nuevo saldo: ${saldo}";
            }
            else
            {
                return "Fondos insuficientes o cantidad inválida.";
            }
        }


        public double ConsultarSaldo()
        {
            return saldo;
        }


        public string MostrarInformacion()
        {
            return $"Titular: {titular} - Saldo actual: ${saldo}";
        }

    }
}
