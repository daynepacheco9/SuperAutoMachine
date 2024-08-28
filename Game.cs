public class Game
{
    private static Game game;

    public int moedas { get; set; }
    public int nivel {get; set; }
    public int vidas { get; set; }
    public int trofeu { get; set; }

    public MaquinaBase[] timeJogador;

    private Game()
    {
        moedas = 0;
        vidas = 0;
        trofeu = 0;
        nivel = 1;

        timeJogador = new MaquinaBase[5];
    }
    public static Game GetGame(){
        game = new Game();
        return game;
    }



}