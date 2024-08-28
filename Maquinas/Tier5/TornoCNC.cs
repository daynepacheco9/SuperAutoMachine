public class TornoCNC : MaquinaBase{
    public TornoCNC()
    {
        tier = 5;
        ataque = 5;
        vida = 8;
    }
    public override void ContraAtaca(Lutador inimigo)
    {
        throw new System.NotImplementedException();
    }

    public override void Morrendo()
    {
        throw new System.NotImplementedException();
    }

    public override void Vendido()
    {
        
    }
}