using Backend;

var time1 = new Time(); //tiempo cero
var time2 = new Time(15); //horas
var time3 = new Time(8, 32, 54, 214);
var time4 = new Time(23, 2, 7);

Console.WriteLine(time1.ToString());
Console.WriteLine(time2.ToString());
Console.WriteLine(time3.ToString());
Console.WriteLine(time4.ToString());