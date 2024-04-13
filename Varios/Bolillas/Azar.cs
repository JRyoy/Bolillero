namespace Varios.Bolillas;

public class Azar : IAzar
{
    public int SacarBolilla(List<int>bolillas)
    {
        Random random =new Random ();
        return random.Next(0,bolillas.Count);
    }
}
