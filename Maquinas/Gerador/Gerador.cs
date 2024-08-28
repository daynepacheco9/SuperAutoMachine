using System;
using System.Collections.Generic;

public abstract class Gerador
{
    public List<Func<MaquinaBase>> listMaquinas = new();

    protected abstract void Fill();

    public MaquinaBase ListaAleatoria()
    {
        if (listMaquinas.Count == 0)    
            Fill();

        int numeroAleatorio = Random.Shared.Next(0, listMaquinas.Count);

        return listMaquinas[numeroAleatorio]();
    }

}