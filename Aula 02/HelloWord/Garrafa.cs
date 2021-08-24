namespace HelloWord
{
    public class Garrafa
    {
        int codigo;
        int capacidade;
        string marca;

        public Garrafa(int codigo, int capacidade, string marca)
        {
            this.codigo = codigo;
            this.capacidade = capacidade;
            this.marca = marca;
        }
        
        public int getCodigo()
        {
            return this.codigo;
        }
        public int getCapacidade()
        {
            return this.capacidade;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public void SetMarca(string marca)
    {
        this.marca = marca;
    }
    }
}