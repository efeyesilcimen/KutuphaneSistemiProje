using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeKutuphane.Domain
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int Durum { get; set; }
        public int KategoriId { get; set; }
    }
}
