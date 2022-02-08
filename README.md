# Inheritance
###### inheritance is a process in which one object acquires all the properties and behaviors of its parent object automatically. In such way, you can reuse, extend or modify the attributes and behaviors which is defined in other class.
>Inheritance. Constructors' calls sequence
>
>Inheriting from a base class
>
>Inheriting from a class and implementing an interface
>
>Inheriting from a class and implementing multiple interfaces
>
>Constructors In A Subclass


# Polymorphism
## Ad hoc polymorphism:
###### contains function overloading. The target is that a Method can be used with different types without the need of being generic.
## Subtyping:
###### Subtyping is the use of inherit from a base class to generalize a similar behavior.

# Interfaces
###### An interface is used to enforce the presence of a method in any class that 'implements' it. The interface is defined with the keyword interface and a class can 'implement' it by adding : InterfaceName after the class name. A class can implement multiple interfaces by separating each interface with a comma.
```: InterfaceName, ISecondInterface```
# Abstraction
###### A class marked with the keyword abstract cannot be instantiated. A class must be marked as abstract if it contains abstract members or if it inherits abstract members that it doesn't implement. A class may be marked as abstract even if no abstract members are involved. Abstract classes are usually used as base classes when some part of the implementation needs to be specified by another component. 
###### A method, property, or event marked with the keyword abstract indicates that the implementation for that member is expected to be provided in a subclass. As mentioned above, abstract members can only appear in abstract classes.
