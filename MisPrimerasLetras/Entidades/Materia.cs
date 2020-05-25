using System;

public class Materia
{
    public int id_materia { get; set; }
    /// <summary>
    /// materia.
    /// </summary>
    public string materia { get; set; }
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

    public int IdArea { get; set; }

    public override string ToString()
    {
        return materia;
    }
}
