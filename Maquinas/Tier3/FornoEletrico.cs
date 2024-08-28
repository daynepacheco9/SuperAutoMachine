public class FornoEletrico : MaquinaBase{
    public FornoEletrico()
    {
        tier = 3;
        ataque = 4;
        vida = 3;
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