namespace Examen_III_Juan_Hernandez.Data;

public class MySQLConfiguration
{
    public string CadenaConexion { get; }

    public MySQLConfiguration(string codenaConexion)
    {
        CadenaConexion = codenaConexion;
    }
}
