using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using App_Algodao.Persistencia;
using SQLite;
using System.IO;
using App_Algodao.iOS.Persistencia;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteAcessoDB))]
namespace App_Algodao.iOS.Persistencia
{
    public class SQLiteAcessoDB: ISQLiteDb
    {

        public SQLiteConnection GetConnection()
        {
            string nomeBD = "Modulos.db3";

            var caminhoPasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var caminho = Path.Combine(caminhoPasta, nomeBD);
            return new SQLiteConnection(caminho);

        }
}