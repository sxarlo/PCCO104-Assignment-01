using System;

class Program {
  public static void Main (string[] args) {

    // input value here. example: 0.05m
    decimal bills = 0.05m;

    // the m is to remind the compiler that the number is decimal.
    if (bills == 0.01m || bills == 0.05m || bills ==  0.25m) {
      Console.WriteLine("No person is found");
    }

    else if (bills == 1){
      Console.WriteLine("Jose Rizal is found in Php." + bills);
    }

    else if (bills == 5) {
      Console.WriteLine("Emilio Aguinaldo in Php." + bills);
     }

    else if (bills == 10) {
      Console.WriteLine("Andres Bonifacio & Apolinario Mabini is found in Php. " + bills);
    }

    else if (bills == 20) {
      Console.WriteLine("Manuel L. Quezon is found in Php. " + bills);
    }

    else if (bills == 50) {
      Console.WriteLine("Sergio Osmena is found in Php. " + bills);
    }

    else if (bills == 100) {
      Console.WriteLine("Manuel Roxas is found in Php. " + bills);
    }

    else if (bills == 200) {
       Console.WriteLine("Diosdado Macapagal is found in Php. " + bills);
    }

    else if (bills == 500) {
       Console.WriteLine("Benigno Sr. & Corazon Aquino is found in Php. " + bills);
    }

    else if (bills == 1000) {
       Console.WriteLine("Jose Abad Santos, Vicent Lim, & Josefa Llanes Escoda is found in Php. " + bills);
    }

    else {
       Console.WriteLine("Invalid Denomination");
      
     }
  }
}