
# Evodice Core
Development of Domain Logic with abstraction. Interfaces drives business requirements with light implementation. The Core project is the center of the Clean Architecture design, and all other project dependencies should point toward it.

## Project Structure

- Entities
- Interfaces
- Specifications
- ValueObjects
- Exceptions
  
## Entities

Includes Entity Framework Core Entities which creates sql table with Entity Framework Core Code First Approach. Some Aggregate folders holds entity and aggregates. You can see example of code-first Entity definition in Product.cs. Applying domain driven approach, Product class responsible to create Product instance.
  
  
## Interfaces

Abstraction of Repository — Domain repositories (IAsyncRepository — IProductRepository) — Specifications etc.. This interfaces include database operations without any application and UI responsibilities.  

  
## Infrastructure Layer
Implementation of Core interfaces in this project with Entity Framework Core and other dependencies. Most of your application’s dependence on external resources should be implemented in classes defined in the Infrastructure project. These classes must implement the interfaces defined in Core. If you have a very large project with many dependencies, it may make sense to have more than one Infrastructure project (eg Infrastructure.Data), but in most projects one Infrastructure project that contains folders works well.


## Authors

- [@ramazangunes](https://github.com/ramazangunes)