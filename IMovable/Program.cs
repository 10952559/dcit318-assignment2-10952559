using System;
interface IMovable{
    void Move();
}

class Car : IMovable
{
   public void Move(){
    Console.WriteLine("The Car moves.");
   } 
}
class Bicycle : IMovable
{
   public void Move(){
    Console.WriteLine("The Bicycle moves.");
   } 
}

class Program{
    static void Main(String[] args){
IMovable car = new Car();
IMovable bicycle = new Bicycle();

car.Move();
bicycle.Move();
    }
}