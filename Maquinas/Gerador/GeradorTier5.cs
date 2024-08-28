public class GeradorTier5 : Gerador
{
    protected override void Fill()
    {
        listMaquinas.Clear();
        listMaquinas.Add(()=> new FresaCNC());
        listMaquinas.Add(()=> new TornoCNC());
    }
}