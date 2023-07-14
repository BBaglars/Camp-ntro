using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseloggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()};

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKredisiManager(),new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});
basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);