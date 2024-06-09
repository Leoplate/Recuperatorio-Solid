// See https://aka.ms/new-console-template for more information
using DIP;
using LSP;
using Open_Close;
using RecuperatorioSolid.ISP;
using RecuperatorioSolid.LSP;
using RecuperatorioSolid.OCP;
using Single_Responsability;


//SRP

Car auto = new Car("208", "Peugeot", 10000,15);
Car auto2 = new Car("Fiesta", "Ford", 15000,10);
List<Car> Base = new List<Car>();

BaseAutoBad BaseAutoB = new BaseAutoBad(Base);
BaseAutoGood BaseAutoG = new BaseAutoGood(Base);
BaseAutoB.Guardar(auto);
BaseAutoB.Guardar(auto2);
BaseAutoG.Guardar(auto);
BaseAutoG.Guardar(auto2);
//BaseAutoB.Mostrar();

//MostrarAuto MA = new MostrarAuto();
//MA.Mostrar(BaseAutoG);



//OCP


List<Auto> BaseI = new List<Auto>();

BaseI.Add(new Peugeot("208", "Peugeot", 10000, 15));
BaseI.Add(new Ford("Fiesta", "Ford", 15000, 10));



//MostrarAutoOCBAD MostrarPrecioB = new MostrarAutoOCBAD();
//MostrarAutoOCGOOD MostrarPrecioG = new MostrarAutoOCGOOD();
//MostrarPrecioG.Mostrar(BaseI);


//LSP


Elefante elefante = new Elefante("Elefante");
Perro perro = new Perro("Perro");

Zoo zoologico = new Zoo();

zoologico.Guardar(perro);
zoologico.Guardar(elefante);

//zoologico.Interactuar();



//ISP


Abeja abe = new Abeja();


abe.Volar();
abe.Comer();


GrilloII griII = new GrilloII();


griII.Saltar();
griII.Comer();



//DIP
BDMySQLServerGood prov = new BDMySQLServerGood();
BDSQLServerGood prov2 = new BDSQLServerGood();
PersistenciaGood bd = new PersistenciaGood(prov);
bd.Persistir(auto);
PersistenciaGood bd2 = new PersistenciaGood(prov2);
bd2.Persistir(auto2);