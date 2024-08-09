using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Auto auto = new Auto("Toyota", "Corolla", 2020, 15000, 4);
        Motocicleta moto = new Motocicleta("Yamaha", "YZF-R3", 2021, 5000, "Deportiva");
        Camion camion = new Camion("Volvo", "FH16", 2019, 20000, 35000);

        auto.Encender();
        auto.Conducir(120);
        auto.Apagar();

        moto.Encender();
        moto.Conducir(80);
        moto.Apagar();

        camion.Encender();
        camion.Conducir(200);
        camion.Apagar();
    }
}