using Backend;

try
{
    var time1 = new Time(); //tiempo cero
    var time2 = new Time(15); //horas
    var time3 = new Time(8, 58, 54, 1000);
    var time4 = new Time(23, 2, 7);

    Console.WriteLine(time1.ToString());
    Console.WriteLine(time2.ToString());
    Console.WriteLine(time3.ToString());
    Console.WriteLine(time4.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

