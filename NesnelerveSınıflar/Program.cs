using NesnelerveSınıflar;

Person ogrenci = new Person();//Nesne Oluşturuldu.

ogrenci.name = "Deniz";
ogrenci.lastName = "Öncü";
ogrenci.birthDate = new DateTime(2002, 03, 16);

ogrenci.BilgileriYazdir();//Metot Çağrıldı.

Person ogretmen =new Person();

ogretmen.name = "Sergen";
ogretmen.lastName = "Yanlçın";
ogretmen.birthDate = new DateTime(1972,11,05);

ogretmen.BilgileriYazdir();//Metot Çağrıldı.
