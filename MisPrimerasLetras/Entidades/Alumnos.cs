using System;
using LinqToDB.Mapping;

public class Alumnos
{
    [PrimaryKey, Identity]
    public int id_alumno { set; get; }
    /// <summary>
    /// NombreMateria.
    /// </summary>
    public string nombre { get; set; }
    /// <summary>
    /// PrimerApellido.
    /// </summary>
    public string primer_apellido { get; set; }
    /// <summary>
    /// SegundoApellido.
    /// </summary>
    public string segundo_apellido { get; set; }
    /// <summary>
    /// FechaNacimiento.
    /// </summary>
    public DateTime fecha_nacimiento { get; set; }
    /// <summary>
    /// Acudiente.
    /// </summary>
    public string acudiente { get; set; }
    /// <summary>
    /// Dirección.
    /// </summary>
    public string direccion { get; set; }
    /// <summary>
    /// Telefono.
    /// </summary>
    public int telefono { get; set; }
    /// <summary>
    /// Correo.
    /// </summary>
    public string correo { get; set; }
    /// <summary>
    /// Observaciones.
    /// </summary>
    public string observaciones { get; set; }
    public string ocupacion { get; set; }
    /// <summary>
    /// FechaCreacion.
    /// </summary>
    public DateTime fecha_creacion { get; set; }
    /// <summary>
    /// FechaModificación.
    /// </summary>
    public DateTime fecha_modificacion { get; set; }
    /// <summary>
    /// Usuario.
    /// </summary>
    public string creado_por { get; set; }
}
