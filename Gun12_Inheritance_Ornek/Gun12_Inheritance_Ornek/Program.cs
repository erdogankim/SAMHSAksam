// See https://aka.ms/new-console-template for more information

using Gun12_Inheritance_Ornek;

//Umumi u = new Umumi();
//u.SonIndex = 500;
//u.IlkIndex = 400;

//Mesken m = new Mesken();
//m.SonIndex = 600;
//m.IlkIndex = 500;

//AboneIslem.FaturaHesapla(u);
//AboneIslem.FaturaHesapla(m);


Abone a = new Umumi();
Console.WriteLine(a.BirimFiyat);

Abone a2 = new Mesken();
Console.WriteLine(a2.BirimFiyat);