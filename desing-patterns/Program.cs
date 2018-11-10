using System;

/**
 * Design Patterns
 * 
 * Clasificated in: 
 * 
 * Contruction: Abstract Factory, Builder, Factory Method, Prototype y Singleton 
 * Structuration: Adapter, Bridge, Composite, Decorator, Facade, Flyweight y Proxy 
 * Comportamient: Chain of responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method y Visitor
 * 
 * 
 */


namespace desingpatterns
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            new desingpatterns.patterns.construction.AbstractFactory.Main().execute();
        }
    }
}
