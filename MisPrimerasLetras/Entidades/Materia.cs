using System;

public class Materia
{
    public int IdMateria { get; set; }
    /// <summary>
    /// NombreMateria.
    /// </summary>
    public string NombreMateria { get; set; }
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
        return NombreMateria;
    }
}
