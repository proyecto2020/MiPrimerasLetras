using System;
using LinqToDB.Mapping;

public class Pagos
{
    [PrimaryKey, Identity]
    public int id_pago { set; get; }
    /// <summary>
    /// Total.
    /// </summary>
	public int total { get; set; }
    /// <summary>
    /// Saldo.
    /// </summary>
    public int saldo { get; set; }
    /// <summary>
    /// Abono.
    /// </summary>
    public int abono { get; set; }
    /// <summary>
    /// Mes.
    /// </summary>
    public string mes { get; set; }
    /// <summary>
    /// PazySalvo.
    /// </summary>
    public bool paz_y_salvo { get; set; }
    /// <summary>
    /// FechaCreacion.
    /// </summary>
    public DateTime fecha_modificacion { get; set; }
    /// <summary>
    /// FechaModificación.
    /// </summary>
    public DateTime FechaModificación { get; set; }
    /// <summary>
    /// Usuario.
    /// </summary>
    public string usuario_modificacion { get; set; }

    public int fk_alumno { get; set; }

}
