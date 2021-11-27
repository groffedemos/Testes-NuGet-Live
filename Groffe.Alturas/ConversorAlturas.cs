namespace Groffe.Alturas;

public class ConversorAlturas
{
    /// <summary>
    /// Converte uma altura em pes para o equivalente em metros
    /// </summary>
    /// <param name="alturaPes">Altura em pes</param>
    /// <returns>Valor em metros</returns>
    /// <exception cref="ArgumentException">Exceção gerada para uma altura negativa</exception>
    public static double PesParaMetros(double alturaPes)
    {
        if (alturaPes <= 0)
            throw new ArgumentException("Altura em pes deve ser maior do que zero!");
        return Math.Round(alturaPes * 0.3048, 4);
    }
}