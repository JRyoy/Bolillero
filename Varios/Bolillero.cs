using Varios.Bolillas;

namespace Varios;

public class Bolillero
{
    public static List<int>Bolilla;
    public static List<int>BolillasElegidas;
    public Azar azar { get; set; }
    public int CantidadJugar { get; set; }
    public Bolillero(int CantidadJugar)
    {
        this.CantidadJugar=CantidadJugar;
        for(int i=0;i<CantidadJugar;i++){Bolilla.Add(i);}
    }
    public int SacarBolilla(List<int> bolilla)
    {
        return azar.SacarBolilla(bolilla);
    }
    public bool Jugar(List<int> bolilla)
    {
        BolillasElegidas.Where(x=>bolilla.Any(d=>d==x)).ToList().Count()==BolillasElegidas.Count();
        

    }
    public bool JugarNV(List<int>BolillasElegidas,int CantidadJugar)
    {

    }
}
