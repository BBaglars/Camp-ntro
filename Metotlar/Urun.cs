using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {
        //property 0 özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
//manager, service, dal, dataacsess, controler - Bunlar bir classın başında var ise bir operasyon tutuyor demek 
