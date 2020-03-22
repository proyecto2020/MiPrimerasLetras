using System;

public class Area
{
    public int IdArea { get; set; }
    /// <summary>
    /// Area.
    /// </summary>
    public string AreaM { get; set; }
    /// <summary>
    /// FechaCreacion.
    /// </summary>
    public DateTime FechaCreacion { get; set; }
    /// <summary>
    /// FechaModificación.
    /// </summary>
    public DateTime FechaModificación { get; set; }
    /// <summary>
    /// Usuario.
    /// </summary>
    public string Usuario { get; set; }

    public override string ToString()
    {
        return AreaM;
    }
}
