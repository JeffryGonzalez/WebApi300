# Vendors API

Project - `Services/Vendors/Vendors.Api`

## Vendors

We have arrangements with vendors. Each vendor has:

- And ID we assign
- A Name
- A Short, optional description
- A Website URL
- A Point of Contact
  - Name
  - Email
  - Phone Number

Vendors have a set of software they provide that we support.

Resource: `/vendors` - (collection resource)

```http
GET /
Accept: application/json
```


```http
200 Ok
Content-Type:application-json

{

"data": [
  { id: 33, name: 'Microsoft'}
],

}

```
```http
POST /
Content-Type: application/json
Authorization: Bearer {token with SoftwareCenter and Manager}

{
  "name": "Microsoft",
  "description": "Big Corp",
  "pointOfContact": {
    "name": "Bob Jones",
    "companyName": "Geico",
    "phone": "some-phone",
    "email": "some@email.com"
  }
}
```



```http
GET /{id}
Accept: application/json
Authorization: Bearer {SoftwareCenter}
```

```http
PUT  /8bb13b4a-a6e3-4e24-bf0f-0d74c60ea149/point-of-contact

{
  "name": "brenda",
  "email": blah,
  "phone": 939399
}
```

```http

DELETE /8bb13b4a-a6e3-4e24-bf0f-0d74c60ea149
```


Resources have a name, the name is technically a URI in the form of:

