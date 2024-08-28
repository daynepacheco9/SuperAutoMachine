public class FuradeiraDeColuna : MaquinaBase{
    public FuradeiraDeColuna()
    {
        tier = 2;
        ataque = 3;
        vida = 5;
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