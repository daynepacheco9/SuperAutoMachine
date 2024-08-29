public class RetificaCilindrica : MaquinaBase{
    public RetificaCilindrica()
    {
        tier = 3;
        ataque = 2;
        vida = 6;
    }
    public override void Atacando(Lutador inimigo)
    {
        throw new System.NotImplementedException();
    }

    public override void Morrendo()
    {
        throw new System.NotImplementedException();
    }

    public override void Vendido(){}

    public override void Batalhando(){}

    public override void ContraAtaca(){}
}