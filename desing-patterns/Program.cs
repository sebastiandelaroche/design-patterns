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
            // construction

            // new desingpatterns.patterns.construction.AbstractFactory.Main().execute();

            // new desingpatterns.patterns.construction.Builder.Main().execute();

            // new desingpatterns.patterns.construction.MethodFactory.Main().execute();

            // new desingpatterns.patterns.construction.Prototype.Main().execute();

            // new desingpatterns.patterns.construction.Singleton.Main().execute();

            // structuring

            // new desingpatterns.patterns.structuring.Adapter.Main().execute();

            // new desingpatterns.patterns.structuring.Bridge.Main().execute();

            // new desingpatterns.patterns.structuring.Composite.Main().execute();

            // new desingpatterns.patterns.structuring.Decorator.Main().execute();

            // new desingpatterns.patterns.structuring.Facade.Main().execute();

            new desingpatterns.patterns.structuring.Flyweight.Main().execute();

        }
    }
}
