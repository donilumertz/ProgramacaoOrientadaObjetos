namespace AP2.ViewModels
{
    public class ContaPagamentoRealizadoViewModel
    {
        public ContaPagamentoRealizadoViewModel(bool pagamentoRealizado)
        {
            this.PagamentoRealizado = pagamentoRealizado;
        }
        public bool PagamentoRealizado { get; set; }
    }
}