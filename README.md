# Polymorphism
## Ad hoc polymorphism:
###### contains function overloading. The target is that a Method can be used with different types without the need of being generic.
## Subtyping:
###### Subtyping is the use of inherit from a base class to generalize a similar behavior.

# Interfaces
###### An interface is used to enforce the presence of a method in any class that 'implements' it. The interface is defined with the keyword interface and a class can 'implement' it by adding : InterfaceName after the class name. A class can implement multiple interfaces by separating each interface with a comma.
```: InterfaceName, ISecondInterface```
# Abstraction
###### A class marked with the keyword abstract cannot be instantiated. A class must be marked as abstract if it contains abstract members or if it inherits abstract members that it doesn't implement. A class may be marked as abstract even if no abstract members are involved.
