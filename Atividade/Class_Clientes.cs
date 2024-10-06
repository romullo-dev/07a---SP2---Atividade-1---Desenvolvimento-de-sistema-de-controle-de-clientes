namespace Atividade
{
    public class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; set; }
        public float valor_imposto { get; set; }
        public float total { get; set; }

        public virtual void Pagar_Imposto(float valor)
        {
            this.valor = valor;
            this.valor_imposto = valor * 0.1f;
            this.total = valor + this.valor_imposto;
        }
    }
}
