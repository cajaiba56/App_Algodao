using App_Algodao.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Algodao.Persistencia
{
    public class AcessoDB: IDisposable
    {

        protected static object locker = new object();

        private SQLiteConnection db;

        public AcessoDB()
        {
            db = DependencyService.Get<ISQLiteDb>().GetConnection();
            db.CreateTable<Modulos>();
        }

        public void InserirModulo(Modulos modulo)
        {
            lock (locker)
            {
                db.Insert(modulo);
            }
        }

        public void DeletarModulo(Modulos modulo)
        {
            lock (locker)
            {
                db.Delete(modulo);
            }
        }

        public void AtualizarModulo(Modulos modulo)
        {
            lock (locker)
            {
                db.Update(modulo);
            }
        }

        public Modulos GetModulo(string codigo)
        {
            lock (locker)
            {
                return db.Table<Modulos>().Where(u => u.Numero == codigo).FirstOrDefault();
            }
        }

        public List<Modulos> GetModulos()
        {
            lock (locker)
            {
                return db.Table<Modulos>().ToList();
            }
        }

        public List<Modulos> GetModulos(string criterio)
        {
            lock (locker)
            {
                return db.Table<Modulos>().Where(u => u.Numero.Contains(criterio)).ToList();
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}
