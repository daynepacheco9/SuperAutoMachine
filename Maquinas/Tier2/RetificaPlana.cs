public class RetificaPlana : MaquinaBase{
    public RetificaPlana()
    {
        tier = 2;
        ataque = 4;
        vida = 2;
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