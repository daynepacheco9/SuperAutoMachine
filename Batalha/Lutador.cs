using System;

public class Lutador{
    public readonly MaquinaBase maquina;

    public int ataqueAtual { get; set;}
    public int vidaAtual { get; set;}
    public bool statusVida { get; set;} = true;

    public Lutador(MaquinaBase maquina)
    {
        this.maquina = maquina;
        vidaAtual = maquina.vida;
        ataqueAtual = maquina.ataque;
    }

    public void Atacar(Lutador inimigo)
    {
        vidaAtual -= inimigo.ataqueAtual;
        maquina.Atacando(inimigo);

        if (vidaAtual <= 0)
            Morrer();
    }

    public void Morrer(){
        maquina.Morrendo();
        statusVida = false;
    }
    
    public void ComecarBatalha() => maquina.Batalhando();

    public void TomaDeVolta() => maquina.ContraAtaca();
}