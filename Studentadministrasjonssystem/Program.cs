namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bjarne = new Student("Bjarne", 22, "IT", 001);
            var terje = new Student("Terje", 45, "IT", 002);

        }
    }
}

/*
 * Del 1: Klasser og Objekter
   Lag følgende klasser:
   
   Student:
   
   Egenskaper: Navn, Alder, Studieprogram, StudentID.
   Metode: SkrivUtInfo() som skriver ut informasjon om studenten.
   Fag:
   
   Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.
   Metode: SkrivUtInfo() som skriver ut informasjon om faget.
   Karakter:
   
   Egenskaper: Student (referanse til en Student), Fag (referanse til et Fag), Karakterverdi.
   Metode: SkrivUtInfo() som skriver ut informasjon om karakteren.
*/