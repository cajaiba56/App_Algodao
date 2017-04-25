using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Algodao.Model
{
    [Table("Modulos")]
    public class Modulos : NotifyBase
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _numero;
        [MaxLength(20)]
        public string Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
                OnPropertyChanged();
            }
        }

        //private string _fazenda;
        //[MaxLength(50)]
        //public string Fazenda
        //{
        //    get { return _fazenda; }
        //    set
        //    {
        //        _fazenda = value;
        //        OnPropertyChanged();
        //    }
        //}


        private string _setor;
        [MaxLength(50)]
        public string Setor
        {
            get { return _setor; }
            set
            {
                _setor = value;
                OnPropertyChanged();
            }
        }

        private string _talhao;
        [MaxLength(20)]
        public string Talhao
        {
            get { return _talhao; }
            set
            {
                _talhao = value;
                OnPropertyChanged();
            }
        }

        private string _variedade;
        [MaxLength(50)]
        public string Variedade
        {
            get { return _variedade; }
            set
            {
                _variedade = value;
                OnPropertyChanged();
            }
        }

        //private DateTime _data;
        //[MaxLength(20)]
        //public DateTime Data
        //{
        //    get { return _data; }
        //    set
        //    {
        //        _data = value;
        //        OnPropertyChanged();
        //    }
        //}


        private bool _bordadura;
        public bool Bordadura
        {
            get { return _bordadura; }
            set
            {
                _bordadura = value;
                OnPropertyChanged();
            }
        }


        private string _turno;
        [MaxLength(20)]
        public string Turno
        {
            get { return _turno; }
            set
            {
                _turno = value;
                OnPropertyChanged();
            }
        }

    }
}
