public class ChaveDeFenda : MaquinaBase{
    public ChaveDeFenda()
    {
        tier = 1;
        ataque = 2;
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
