public abstract class MaquinaBase
{
    public int nivel{ get; set; }

    public int experiencia { get; set; }

    public int tier { get; set; }

    public int ataque { get; set; }

    public int vida { get; set; }

    protected MaquinaBase()
    {
        nivel = 1;
        experiencia = 1;
    }

    public abstract void Morrendo();

    public virtual void Vendido()
    {
        Game.GetGame().moedas++;
    }
    public abstract void Atacando(Lutador inimigo);

    public abstract void Batalhando();

    public abstract void ContraAtaca();


}