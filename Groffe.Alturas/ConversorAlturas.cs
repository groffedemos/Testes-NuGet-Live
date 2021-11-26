namespace Groffe.Alturas;

public class ConversorAlturas
{
    /// <summary>
    /// Converte uma altura em pes para o equivalente em metros
    /// </summary>
    /// <param name="alturaPes">Altura em pes</param>
    /// <returns></returns>
    public static double PesParaMetros(double alturaPes)
    {
        return Math.Round(alturaPes * 0.3048, 4);
    }
}