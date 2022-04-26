using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_BANCARIA
{
    class CalcularCuenta
    {
        SaldoFinal SaldoFinal = new SaldoFinal();
        Form1 Form1 = new Form1();
        public decimal CuentaAhorroMensual(double Interes, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            int Mensualidades;
            int Meses = 12;
            decimal Total = 0;

            switch (Periodo)
            {
                case "1 AÑO":
                    Mensualidades = Meses;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "2 AÑOS":
                    Mensualidades = Meses * 2;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "3 AÑOS":
                    Mensualidades = Meses * 3;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "4 AÑOS":
                    Mensualidades = Meses * 4;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "5 AÑOS":
                    Mensualidades = Meses * 5;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
            }
            return Total;
        }

        public decimal CuentaAhorroSemestral(double Interes, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            int Semestres;
            decimal Total = 0;
            switch (Periodo)
            {
                case "1 AÑO":
                    Semestres = 2;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "2 AÑOS":
                    Semestres = 4;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "3 AÑOS":
                    Semestres = 6;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "4 AÑOS":
                    Semestres = 8;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "5 AÑOS":
                    Semestres=10;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
            }
            return Total;
        }

        public decimal CuentaAhorroAnual(double Interes, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            int Anual;
            decimal Total = 0;
            switch (Periodo)
            {
                case "1 AÑO":
                    Anual = 1;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    break;
                case "2 AÑOS":
                    Anual = 2;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    break;
                case "3 AÑOS":
                    Anual = 3;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    break;
                case "4 AÑOS":
                    Anual = 4;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    break;
                case "5 AÑOS":
                    Anual = 5;
                    Total = Form1.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    break;
            }
            return Total;
        }

    }
}
