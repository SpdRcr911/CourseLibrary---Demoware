# Filtering and Searching

## Passing data to the API 
- Binding source attributes 
- ApiController 

Filtering and searching resources 

Data can be passed to an API by various means 

Binding source attributes tell the model binding engine where to find the binding source 

| Source Attribute   | Message location  |
| :------------- | :---------- |
| **[FromBody]** | Request body  |
| **[FromForm]** | Form data in the request body  |
| **[FromHeader]** | Request header  |
| **[FromQuery]** | Query string parameters  |
| **[From Route]** | Route data from the current request  |
| **[FromService]** | The service injected as action parameter  |

# Method Safety and Method Idempotendy

## Safe 

A method is considered safe when it 
doesn't change the resource 
representation 

## Idempotent

A method is considered idempotent 
when it can be called multiple times 
with the same result 

| HTTP Method    | Safe?        | Idempotent?  |
| :------------- | :----------: | :----------: |
|  __GET__       | yes          | yes          |
| __OPTIONS__    | yes          | yes          |
|  __HEAD__      | yes          | yes          |
|  __POST__      | no           | no           |
|  __DELETE__    | no           | yes          |
|  __PUT__       | no           | yes          |
|  __PATCH__     | no           | no           |

## Creating resources

**POST** is used to create resources 
 - Unsafe 
 - Not idempotent 
- 201 Created 
- Location header 

To create a list of resource in one go, 
create a new resource that accepts a 
collection 

When **POST** is not allowed, return 
405 Method Not Allowed 

Use an **OPTIONS** request to learn which 
methods are allowed for a certain 
resource 

Use the _content-type_ header to signify 
the media type of the request body 
