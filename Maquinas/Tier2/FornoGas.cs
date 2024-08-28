public class FornoGas : MaquinaBase{
    public FornoGas()
    {
        tier = 2;
        ataque = 1;
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