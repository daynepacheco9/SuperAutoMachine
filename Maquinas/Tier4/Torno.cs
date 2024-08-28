public class Torno : MaquinaBase{
    public Torno()
    {
        tier = 4;
        ataque = 5;
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