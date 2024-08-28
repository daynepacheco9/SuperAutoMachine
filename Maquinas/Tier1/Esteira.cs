public class Esteira : MaquinaBase{
    public Esteira()
    {
        tier = 1;
        ataque = 3;
        vida = 1;
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