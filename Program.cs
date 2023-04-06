using System;

namespace while1
{

    /*
    STATEMEN WHILE
    
    Bentuk umum :
    while (kondisi) statemen ;
    atau
    while (kondisi){
        statemen1;
        statemen2;
        ...

        contoh 1:
         int i ; 
            i = 0;
            while (i<5){
                Console.Write("Langkah ke-"+i+ " : ");
                Console.WriteLine("Pemrograman c#");
                i++;
            }
    }

    int n, i , faktorial = 1;
           string s;

           Console.Write ("Masukkan bilangan bulat : ");
           s = Console.ReadLine();
           n = int.Parse(s);

           if (n>=1){
               i = n;
               while (i>=1){
                   faktorial = faktorial *i;
                   i--;
               }
           }
           Console.WriteLine(n + "! = "+faktorial);
    */
    class Program
    {
        static void Main(string[] args)
        {
           //menampilkan nilai i disetiap langkah pengulangan
           int n, i;
           int faktorial = 1;
           string s;

           Console.Write("masukkan bilangan bulat : ");
           s= Console.ReadLine();
           n = int.Parse(s);
           
           Console.WriteLine(n+ "! = ");

           if (n>1){// jika n lebih dari satu
               i= n; //maka i = n
               while (i>=1){ //ketika i lebih dari/lebih besar atau sama dengan 1
                   if (i !=1){ // maka jika i tidak samadengan 1
                       Console.Write(i + " x ");//lakukan , tulis i 
                   }else {
                       Console.Write(i + " = ");
                   }faktorial = faktorial * i;
                   i--;
               }
           }
           Console.WriteLine(faktorial);
        }
    }
}
