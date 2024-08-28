public class GeradorTier6 : Gerador
{
    protected override void Fill()
    {
        listMaquinas.Clear();
        listMaquinas.Add(()=> new CortePlasmaCNC());
    }
}