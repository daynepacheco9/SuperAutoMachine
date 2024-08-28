public class GeradorTier2 : Gerador
{
    protected override void Fill()
    {
        listMaquinas.Clear();
        listMaquinas.Add(()=> new FornoGas());
        listMaquinas.Add(()=> new FuradeiraDeColuna());
        listMaquinas.Add(()=> new RetificaPlana()); 
    }
}