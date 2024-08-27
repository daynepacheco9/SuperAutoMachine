using System;

public class Lutador{
    public readonly MaquinaBase maquina;

    public int ataqueAtual { get; set;}
    public int vidaAtual { get; set;}
    public bool statusVida { get; set;} = true;

    public Lutador(MaquinaBase maquina)
    {
        maquina = maquina ?? throw new ArgumentNullException(nameof(maquina));
        vidaAtual = maquina.vida;
        ataqueAtual = maquina.ataque;
    }

    public void Morrer(){
        maquina.EstaMorto();
        statusVida = false;
    }

}