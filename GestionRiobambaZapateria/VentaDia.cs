public class VentaDia
{
    public string Dia { get; set; }
    public int Adidas { get; set; }
    public int Nike { get; set; }
    public int Puma { get; set; }
    public decimal PrecioAdidas { get; set; }
    public decimal PrecioNike { get; set; }
    public decimal PrecioPuma { get; set; }

    public VentaDia() { }

    public VentaDia(string dia, int adidas, int nike, int puma, decimal precioAdidas, decimal precioNike, decimal precioPuma)
    {
        Dia = dia;
        Adidas = adidas;
        Nike = nike;
        Puma = puma;
        PrecioAdidas = precioAdidas;
        PrecioNike = precioNike;
        PrecioPuma = precioPuma;
    }

    public decimal CalcularTotalVentas()
    {
        return (Adidas * PrecioAdidas) + (Nike * PrecioNike) + (Puma * PrecioPuma);
    }

    public override string ToString()
    {
        return $"Día: {Dia}, Adidas: {Adidas}, Nike: {Nike}, Puma: {Puma}, " +
               $"Precio Adidas: {PrecioAdidas:C}, Precio Nike: {PrecioNike:C}, Precio Puma: {PrecioPuma:C}";
    }
}