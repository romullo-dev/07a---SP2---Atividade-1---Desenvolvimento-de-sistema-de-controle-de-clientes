namespace Atividade
{
    public class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float valor)
        {
            this.valor = valor;
            this.valor_imposto = valor * 0.2f;
            this.total = valor + this.valor_imposto;
        }
    }
}
