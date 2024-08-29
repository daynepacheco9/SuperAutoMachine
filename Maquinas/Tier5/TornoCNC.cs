public class TornoCNC : MaquinaBase{
    public TornoCNC()
    {
        tier = 5;
        ataque = 5;
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