# Singleton Design Pattern in C#

Singleton pattern is type of Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is easy to implement.

This is a class which is responsible for creating and maintaining its own unique instance.

#Characteristics

1. A single constructor, which is private and parameterless. 
2. The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
3. A static variable which holds a reference to the single created instance, if any.
4. A public static means of getting the reference to the single created instance, creating one if necessary.

# Static classes Vs Singletons
Static classes and singletons both provide sharing of redundant objects in memory, but they differ in usage and implementation.

## Static 

> Using static classes for global data. You can use static classes to store single-instance, global data. The class will usually be initialized lazily, at the last possible moment, making startup faster.
However:
You lose control over the exact behavior and static constructors are slow.

## Singletons
> Singleton. Singletons preserve the conventional class approach, and don't require that you use the static keyword everywhere. They may be more demanding to implement at first, but will greatly simplify the architecture of your program.
And:
Unlike static classes, we can use singletons as parameters to methods, or objects.
