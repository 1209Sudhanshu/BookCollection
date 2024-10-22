# BookCollection
## Project Overview :
#### This RESTfulAPI allows users to perform basics CRUD (Create, Read, Update and Delete) operations on a collection of books, using an SQL database for data storge.This task will help assess ypur understanding of API development, database integration, and basic web application principles.

## Features :
#### CRUD operations for book management.
#### Support JSON requests and response.
#### Error Handling for invalid inputs.
#### Input validation for book attributes (like title, author, published date, Genre).

## Technologies Used :
#### C#: Main Programming language for backend logic.
#### ASP.NET Core: Framework for building and running the API.
#### Entity Framework Core: ORM for database operations.
#### SQL Server: Database for storing book and records.
#### Swagger: API documentation an testing.

## Prerequisties:
#### .NET SDK (version 6.0 or later)
#### SQL Server Management Studio (or any supported database)
#### Visual Studio 2022
#### Swagger
#### GIT

## Clone the Repository Using Command:
#### git clone https://github.com/1209Sudhanshu/BookCollection.git

## API Endpoints:
#### 1.) HTTP Method GET :- Retrieve all Books. (ENDPOINT = /api/books)
#### 2.) HTTP Method GET :- Retrieve a specific book by ID. (ENDPOINT = /api/books/{id})
#### 3.) HTTP Method POST :- Add a new book. (ENDPOINT = /api/books/{id})
#### 4.) HTTP Method PUT :- Update an Existing book. (ENDPOINT = /api/books/{id})
#### 5.) HTTP Method DELETE :- Delete a book. (ENNDPOINT = /api/books/{id})

## Examples Requests and Resources
#### 1.) Retrieve All Books:
         Request: GET /api/books
         
         Response(200 OK):
         
         [
         {
           "id": D75BB40E-FCC2-4C78-FF02-08DCF0EAD099,
           "Title":Beloved,
           "Author":Toni Morrison,
           "Publisheddate":1987-09-16 00:00:00.0000000,
           "Genre":Postmodernism, African American Literature
           },
           
           {
           "id":8A75C876-3FCA-41E5-4034-08DCF1A443D7,
           "Title":Atomic Habits,
           "Author":James Clear,
           "Publisheddate":2018-10-16 00:00:00.0000000,
           "Genre":Same Help,Personal development,psychology
           }
           ]

#### 2.) Retrieve a Book by ID:
      Request: GET /api/books/1

      Response(200 OK):

      {
          "id":8A75C876-3FCA-41E5-4034-08DCF1A443D7,
           "Title":Atomic Habits,
           "Author":James Clear,
           "Publisheddate":2018-10-16 00:00:00.0000000,
           "Genre":Same Help,Personal development,psychology
      }

#### Response if Book Not Found:

      {
      "Not Found"
      }

#### 3.) Add a New Book:
      Request: POST /api/books
      Body:
          {
          "Title":Beloved,
           "Author":Toni Morrison,
           "Publisheddate":1987-09-16 00:00:00.0000000,
           "Genre":Postmodernism, African American Literature
           }

      Response(201 Created):
          "id": D75BB40E-FCC2-4C78-FF02-08DCF0EAD099,
           "Title":Beloved,
           "Author":Toni Morrison,
           "Publisheddate":1987-09-16 00:00:00.0000000,
           "Genre":Postmodernism, African American Literature

#### 4.) Update a Book:
        Request: PUT /api/books/1
        Body:
            {
            "Title":Beloved,
           "Author":Toni Morrison,
           "Publisheddate":1987-09-16 00:00:00.0000000,
           "Genre":Postmodernism, African American Literature
           }

        Response(200 OK):
            {
            "id": D75BB40E-FCC2-4C78-FF02-08DCF0EAD099,
           "Title":Beloved,
           "Author":Toni Morrison,
           "Publisheddate":1987-09-16 00:00:00.0000000,
           "Genre":Postmodernism, African American Literature
           }

        Response If Book Not Found(404 Not Found):
           {
           "Not Found"
           }

#### 5.) Delete a Book:
        Request: DELETE /api/books/1

        Response: (204 No Content)

        Response: If Book Not Found(404 Not Found):
            {
            "NOT Found"
            }
            
              
            


