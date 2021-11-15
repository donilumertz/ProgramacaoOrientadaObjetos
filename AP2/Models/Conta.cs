using System;

namespace AP2.Models
{
    public class Conta
    {
        public Conta(int id, int numLeitura, 
        int kwgasto, double valorPagar, double mediaConsumo)
        {
            this.Id = id;
            this.NumLeitura = numLeitura;
            this.KwGasto = kwgasto;
            this.ValorPagar = valorPagar;
            this.MediaConsumo = mediaConsumo;
            this.PagamentoRealizado = false;
        }

        public Conta()
        {
            
        }
   
            public int Id { get; set; }
            public DateTime DataLeitura { get; set; }
            public int NumLeitura { get; set; }
            public int KwGasto { get; set; }
            public double ValorPagar { get; set; }
            public DateTime DataPagamento { get; set; }
            public double MediaConsumo { get; set; }
            public bool PagamentoRealizado { get; set; }



    }
}