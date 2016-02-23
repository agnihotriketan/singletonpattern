# Singleton Design Pattern in C#

Singleton pattern is type of Creational Pattern of Gang of Four (GOF) Design Patterns in .Net. It is easy to implement.

This is a class which is responsible for creating and maintaining its own unique instance.

#Characteristics

1. A single constructor, which is private and parameterless. 
2. The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
3. A static variable which holds a reference to the single created instance, if any.
4. A public static means of getting the reference to the single created instance, creating one if necessary.
