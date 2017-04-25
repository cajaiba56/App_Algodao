using App_Algodao.Droid.Persistencia;
using App_Algodao.Persistencia;
using SQLite;
using System;
using System.IO;


[assembly: Xamarin.Forms.Dependency(typeof(SQLiteAcessoDB))]
namespace App_Algodao.Droid.Persistencia
{
    public class SQLiteAcessoDB : ISQLiteDb
    {
        public SQLiteConnection GetConnection()
        {
            string nomeBD = "Modulos.db3";

            var caminhoPasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var caminho = Path.Combine(caminhoPasta, nomeBD);
            return new SQLiteConnection(caminho);
        }
    }
}