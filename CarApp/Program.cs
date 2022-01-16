using CarApp;
Console.OutputEncoding = System.Text.Encoding.UTF8; //azerbyacan sirifti taninmagi ucun istifade edirik ) 

CarManager myCarManager = new CarManager();

Car asd = myCarManager.AddCar();
Console.WriteLine(asd);


myCarManager.ShowInfo(asd);


//MyMeyhot();


//void MyMeyhot()
//{
//    Car cr=new Car();
//    cr.Model = "asd";
//    cr.Marka = "Test";


//    Console.WriteLine(cr.Model);
//}





