public class FresaCNC : MaquinaBase{
    public FresaCNC()
    {
        tier = 5;
        ataque = 8;
        vida = 4;
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