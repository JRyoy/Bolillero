namespace Varios.Bolillas;

public class Primero:IAzar
{
    public int SacarBolilla(List<int> bolillas)
    {
        if (bolillas.Count == 0)
            {
                return bolillas[0];
            }
            else
            {
                throw new System.InvalidOperationException("La lista de bolillas está vacía.");
            }
    }

}

