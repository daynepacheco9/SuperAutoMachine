public class CortePlasmaCNC : MaquinaBase{
    public CortePlasmaCNC()
    {
        tier = 6;
        ataque = 6;
        vida = 8;
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