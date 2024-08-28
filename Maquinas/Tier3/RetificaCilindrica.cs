public class RetificaCilindrica : MaquinaBase{
    public RetificaCilindrica()
    {
        tier = 3;
        ataque = 2;
        vida = 6;
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