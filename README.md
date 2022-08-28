# magnify-dot-net-developer-assessment
# Sr Dot Net Developer Assessment

## Assorted Bucket
- Simple Pattern:
Provided demo shows that factory pattern is very helpful in creation of new objects. Base on transport type factory return proper vehicle.
The each vehicle is albe to implement own version of Deliver method.

- Begin to Scale the Monolith:
When we’re consider apply microservice pattern a shared single database is considered an anti-pattern if we’re considering spiting of the monolith application into several micro services. 
The point is that when using a shared database, the microservices lose their core properties: scalability, resilience, and independence. Therefore, a shared database is rarely used with microservices, what is more, the shared database will be a single point of failure. 
Changes related to the database could impact multiple services. Besides, microservices won’t be independent in terms of development and deployment as they connect to and operate on the same database. 
In this case I will suggest to rethink solution to avoid jumping into pitfalls.
Thinking about more modular monolith command and query request segregation done for example via MediatR tool will help to handle grow of application.

