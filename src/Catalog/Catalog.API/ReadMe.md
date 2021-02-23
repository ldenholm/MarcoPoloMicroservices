# Catalog API

This microservice handles the retrieval of product data that our solution uses.


# High Level Overview

- ASP.NET Core Web API app.
- REST API, CRUD operations.
- Mongo DB NoSQL database connection on docker.
- N-Layer implementation.
- Repository Design Pattern.
- Swagger API Implementation.
- Dockerfile implementation.

##Architecture of Catalog Microservices

Heirarchy from bottom up:
1. Data Source (MongoDB)
2. DAL
3. Business Logic Layer.
4. Presentation Layer.
6. Common Layer.

##Folder Structure:
- Entities (Product, Category).
- Data (Context with MongoDB driver).
- Repositories (Repository design pattern, business operations).
- Controller Folder (Catalog controller).
- Settings folder (Db connection info).

##Implementation of Repository Pattern:
- Encapsulate DB operations.
- Abstract db context classes from controller.
- Able to mock classes without a db connection for unit tests.