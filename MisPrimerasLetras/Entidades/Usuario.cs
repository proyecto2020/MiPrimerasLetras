using System;


public class Usuario
{
    /// <summary>
    /// IdUsuario.
    /// </summary>
    public int IdUsuario { get; set; }
    /// <summary>
    /// nombre.
    /// </summary>
    public string Nombre { get; set; }
    /// <summary>
    /// PirmerApellido.
    /// </summary>
    public string PrimerApellido { get; set; }
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
    /// <summary>
    /// idPerfil.
    /// </summary>
    public int IdPerfil { get; set; }
    /// <summary>
    /// perfil.
    /// </summary>
    public string Perfil { get; set; }
   /// <summary>
   /// contrasena.
   /// </summary>
    public string contrasena { get; set; }

    public override string ToString()
    {
        return Nombre + " " + PrimerApellido;
    }

}
