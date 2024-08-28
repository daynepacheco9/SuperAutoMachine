public class GeradorTier4 : Gerador
{
    protected override void Fill()
    {
        listMaquinas.Clear();
        listMaquinas.Add(()=> new Torno());
        listMaquinas.Add(()=> new Fresa());
    }
}