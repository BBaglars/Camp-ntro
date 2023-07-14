using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Bir yerin için de bir şeyden 1 den fazla kullanmak istersek liste(List<>) oluştururuz
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran Bilgilerii Değerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
