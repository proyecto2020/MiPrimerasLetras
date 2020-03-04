using System;

public class Usuario
{
    /// <summary>
    /// nombre.
    /// </summary>
   public string Nombre { get; set; }
    /// <summary>
    /// PirmerApellido.
    /// </summary>
    public string PirmerApellido { get; set; }
    /// <summary>
    /// SegundoApellido.
    /// </summary>
    public string SegundoApellido { get; set; }
    /// <summary>
    /// Correo.
    /// </summary>
    public string Correo { get; set; }
    /// <summary>
    /// Estado.
    /// </summary>
    public Boolean Estado { get; set; }
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
    public string UsuarioC { get; set; }

    public int IdPerfil { get; set; }
    public string Perfil { get; set; }


}
