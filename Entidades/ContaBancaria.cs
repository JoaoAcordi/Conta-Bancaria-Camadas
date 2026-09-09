namespace Entidades
{
    public class ContaBancaria
    {
        public Guid Id { get; set; }
        public String Titular { get; set; }
        public String NumeroConta { get; set; }
        public EnumTipoConta TipoConta { get; set; }
    }

    public enum EnumTipoConta
    {
        ContaCorrente = 0,
        ContaPoupanca = 1
    }
}
