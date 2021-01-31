using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager 
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, ILoggerService loggerService)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                loggerService.Log();
            }
        }
    }
}
