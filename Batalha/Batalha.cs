using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;

public class Batalha
{
    public readonly Stack<Lutador> Time1 = new();
    public readonly Stack<Lutador> Time2 = new();
    public Stack<Lutador> time1 => Time1;
    public Stack<Lutador> time2 => Time2;

    public bool terminou => time1.Count >= 0 && time2.Count >= 0;

    public Batalha(
        IEnumerable<MaquinaBase> timeJogadores,
        GeradorDeMaquinas.GeradorTier menorTier,
        GeradorDeMaquinas.GeradorTier maiorTier)
    {
        foreach (var maquina in timeJogadores)
        {
            if (maquina is not null)
                time1.Push(new Lutador(maquina));
        }
        int quantInimigo = Random.Shared.Next(3, 5);
        for (int i = 0; i < quantInimigo; i++)
        {
            var GeradorForca = (GeradorDeMaquinas.GeradorTier)Random.Shared.Next((int)menorTier, (int)maiorTier);
            var maquinaAleatoria = GeradorDeMaquinas.Tier(GeradorForca).ListaAleatoria();

            time2.Push(new Lutador(maquinaAleatoria));
        }


    }

    public Status Resultado()
    {
        HandleBattleStart();
        while (!terminou)
        {
            Luta();
            Consequencia();
        }
        if (time1.Count > 0)
            return Status.GANHOU;

        if (time2.Count > 0)
            return Status.PERDEU;
        return Status.PERDEU;
    }

    private void HandleBattleStart()
    {
        foreach (var lutador in time1)
            lutador.ComecarBatalha();

        foreach (var lutador in time2)
            lutador.ComecarBatalha();
    }

    private void Luta()
    {
        var lutadorTime1 = time1.Peek();
        var lutadorTime2 = time2.Peek();

        lutadorTime1.Atacar(lutadorTime2);
        lutadorTime2.Atacar(lutadorTime1);
    }

    private void Consequencia()
    {
        if (!time1.Peek().statusVida)
            time1.Pop();

        if (!time2.Peek().statusVida)
            time2.Pop();
    }

}