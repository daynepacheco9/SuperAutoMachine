public class CortePlasmaCNC : MaquinaBase{
    public CortePlasmaCNC()
    {
        tier = 6;
        ataque = 6;
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