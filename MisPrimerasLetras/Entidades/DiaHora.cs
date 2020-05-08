using System;

public class DiaHora
{

    public int id_dia_hora { get; set; }
    /// <summary>
    /// HoraInicial.
    /// </summary>
	public int HoraInicial { get; set; }
    /// <summary>
    /// HoraFianl.
    /// </summary>
    public int HoraFinal { get; set; }

    public string ConcatenarHoras => $"{HoraInicial} A {HoraFinal}";
    /// <summary>
    /// Dia.
    /// </summary>
    //public string Dia { get; set; }


}
