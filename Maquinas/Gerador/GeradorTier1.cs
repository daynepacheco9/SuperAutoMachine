public class GeradorTier1 : Gerador
{
    protected override void Fill()
    {
        listMaquinas.Clear();
        listMaquinas.Add(()=> new ChaveDeFenda());
        listMaquinas.Add(()=> new Esteira());
        listMaquinas.Add(()=> new Martelo()); 
    }
}