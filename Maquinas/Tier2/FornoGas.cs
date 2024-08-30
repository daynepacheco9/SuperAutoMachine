public class FornoGas : MaquinaBase{
    public FornoGas()
    {
        tier = 2;
        ataque = 1;
        vida = 3;
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