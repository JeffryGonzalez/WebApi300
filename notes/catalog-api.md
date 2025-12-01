
## Catalog Items

Catalog items are instances of software a vendor provides.

A catalog item has:
- An ID we assign
- A vendor the item is associated with
- The name of the software item
- A description
- A version number (we prefer SEMVER, but not all vendors use it)



Missing stuff on the request - like name, description, etc. - 400
Vendor Id: has to be in the "form" of a Guid, and...... it could be for a vendor we don't currently support.



Note - One catalog item may have several versions. Each is it's own item.

## Use Cases

The Software Center needs a way for managers to add vendors. Normal members of the team cannot add vendors.
Software Center team members may add catalog items to a vendor.
Software Center team members may add versions of catalog items.
Software Center may deprecate a catalog items. (effectively retiring them, so they don't show up on the catalog)

Any employee in the company can use our API to get a full list of the software catalog we currently support.

- none of this stuff can be used unless you are verified (intentified) as an employee.
- some employees are:
  - members of the software center team
    - and some of them are managers of that team



## The Catalog Items

### Find a Vendor
```http
GET http://localhost:1337/vendors
Authorization: bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImplZmYiLCJzdWIiOiJqZWZmIiwianRpIjoiYWIyMGRmY2MiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjEzMzciLCJuYmYiOjE3NjEyMzQ1MzQsImV4cCI6MTc2OTE4MzMzNCwiaWF0IjoxNzYxMjM0NTM3LCJpc3MiOiJkb3RuZXQtdXNlci1qd3RzIn0.KMXGN-9mOfzwX8UFLP43hhqhI7jXi9yj85Y70xxbhQ8
```

### Get a List of Catalog Items For That Vendor 

```http
GET http://localhost:1337/vendors/109acd9e-ce3e-43f5-88c1-d9658a87433f/catalog
Authorization: bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImplZmYiLCJzdWIiOiJqZWZmIiwianRpIjoiYWIyMGRmY2MiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjEzMzciLCJuYmYiOjE3NjEyMzQ1MzQsImV4cCI6MTc2OTE4MzMzNCwiaWF0IjoxNzYxMjM0NTM3LCJpc3MiOiJkb3RuZXQtdXNlci1qd3RzIn0.KMXGN-9mOfzwX8UFLP43hhqhI7jXi9yj85Y70xxbhQ8
```

### Get All Catalog Items

```http
GET http://localhost:1337/catalog-items
```

- if that vendor doesn't exist, return a 404

### Add A Catalog Item

- Must be a member of the software team

```http
POST http://localhost:1337/vendors/0679baa8-1533-4a20-9058-246f666f211e/catalog
Content-Type: application/json

{
  "name": "Visual Studio Code",
  "description": "An Editor For Developers"
}
```