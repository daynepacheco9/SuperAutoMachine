public class GeradorDeMaquinas
{   
    private static Gerador gerador = new GeradorTier1();

    public static Gerador Tier(GeradorTier tier){
        switch (tier)
        {
            case GeradorTier.UM:
                gerador = new GeradorTier1();
                break;
            case GeradorTier.DOIS:
                gerador = new GeradorTier2();
                break;
            case GeradorTier.TRES:
                gerador = new GeradorTier3();
                break;
            case GeradorTier.QUATRO:
                gerador = new GeradorTier4();
                break;
            case GeradorTier.CINCO:
                gerador = new GeradorTier5();
                break;
            case GeradorTier.SEIS:
                gerador = new GeradorTier6();
                break;
        }
        return gerador;
    }
    public enum GeradorTier
    {
        UM,
        DOIS,
        TRES,
        QUATRO,
        CINCO,
        SEIS
    }
}