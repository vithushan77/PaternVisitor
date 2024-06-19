// See https://aka.ms/new-console-template for more information

using Visitor;

var car = new Car();
var moto = new Moto();
var bicycle = new Bicycle();

var visitor = new PrintVisitor();

car.Accept(visitor);
moto.Accept(visitor);
bicycle.Accept(visitor);


