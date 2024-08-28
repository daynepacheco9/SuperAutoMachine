using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;

public class Batalha
{
    public readonly Stack<Lutador> Time1 = new();
    
    public readonly Stack<Lutador> Time2 = new() ;

    public Stack<Lutador> time1 => Time1;
    public Stack<Lutador> time2 => Time2;

}