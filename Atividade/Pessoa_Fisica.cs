namespace Atividade
{
    public class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }

        public override void Pagar_Imposto(float valor)
        {
            this.valor = valor;
            this.valor_imposto = valor * 0.15f;
            this.total = valor + this.valor_imposto;
        }
    }
}
