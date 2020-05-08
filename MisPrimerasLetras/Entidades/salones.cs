using System;

public class Salones
{

    public int IdSalon { get; set; }
    public string Nombre { get; set; }

    public int CodigoUbicación { get; set; }

    public int Numero { get; set; }

    public string Sede { get; set; }
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
}
