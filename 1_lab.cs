using System;
class HelloWorld {
  static void Main() {
    int per=0, izm=0, n=0, sche=0;
    n=Convert.ToInt32(Console.ReadLine());
    for (int z=0; z<n; z++)
    {per=Convert.ToInt32(Console.ReadLine());
    if (per>0 && izm==1) {sche++;};
    if (per<0 && izm==2) {sche++;};
    if (per>0) {izm=2;}
    else {izm=1;};}
    Console.WriteLine(sche);
  }
}
 
 
using System;
class HelloWorld {
  static void Main() {
    int per=0, n=0, prov=0, sche=0, izm="i";
    n=Convert.ToInt32(Console.ReadLine());
    for (int z=0; z<n; z++)
    {per=Convert.ToInt32(Console.ReadLine());
   if (per<izm && z!=0) {prov=1;}
   else if (per>izm && prov==1) {prov=0; sche++;};
   int izm=per;
    }Console.WriteLine(sche);
  }
}
 
using System;
class HelloWorld {
  static void Main() {
    int per=0, n=0, prov=1, sche=0, izm=0;
    n=Convert.ToInt32(Console.ReadLine());
    for (int z=0; z<n; z++)
    {per=Convert.ToInt32(Console.ReadLine());
   if (per==izm && z!=0) {prov++;}
   else {if (sche<prov) {sche=prov;}; prov=1;};
    izm=per;
    }if (sche<prov) {sche=prov;}; Console.WriteLine(sche);
  }
}
 
using System;
class HelloWorld {
  static void Main() {
    int per=0, n=0, prov=0, sche=0;
    n=Convert.ToInt32(Console.ReadLine());
    sche=n;
    for (int z=0; z<n; z++)
    {per=Convert.ToInt32(Console.ReadLine());
   if (per<0) {prov++;}
   else {if (sche>prov) {sche=prov;}; prov=0;};
    }if (sche>=prov && sche!=0) {sche=prov; Console.WriteLine(sche);}
    else {Console.WriteLine("Otricatelnix Net");};
  }
}