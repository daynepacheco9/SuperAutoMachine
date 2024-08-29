public class Fresa : MaquinaBase{
    public Fresa()
    {
        tier = 4;
        ataque = 4;
        vida = 5;
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