# RealWorldApi (Mostly)

This application is a REST API for a fictional blog platform named Conduit. It's mostly based on the [RealWorld project](https://github.com/gothinkster/realworld) but with some minor differences (see below). Currently, it's a work in progress.

The stack is:
    - ASP.NET Core 6.
    - Entity Framework 6.
    - SQL Server (Docker).

## Differences from the RealWorld spec

### PUT /api/user
The RealWorld spec defines one endpoint `PUT /api/user` to partially update a `User` resource. To be more REST compliant, I implemented this endpoint as a full update method.

Example request body:
```json
{
  "user":{
    "username": "Jake",
    "email": "jake@jake.jake",
    "bio": "I like to skateboard",
    "password": "S0MePaSW0rd"
  }
}
```
All fields are required. The image cannot be changed by this endpoint but through `POST /api/user/image-upload` (see below).

### PUT /api/articles/:slug
Similarly, the spec defines one endpoint `PUT /api/articles/:slug` to partially update an `Article` resource. In this case, considering the potentially big size of an `Article`, partial updates make sense. So, I implemented this endpoint as `PATCH /api/articles/:slug`.

### User image
The RealWorld spec treats the user image as a resource that must be uploaded elsewhere. This is unpractical, so I created an endpoint `POST /api/user/image-upload` for image upload.
