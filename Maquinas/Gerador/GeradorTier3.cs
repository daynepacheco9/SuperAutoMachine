public class GeradorTier3 : Gerador
{
    protected override void Fill()
    {
        listMaquinas.Clear();
        listMaquinas.Add(()=> new FornoEletrico());
        listMaquinas.Add(()=> new FuradeiraCoordenada());
        listMaquinas.Add(()=> new RetificaCilindrica()); 
    }
}