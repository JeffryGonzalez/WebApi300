# Scaffolding

At some point consider making a .NET project template, but until then:

## Creating the Files for a Service

Edit the `service.config.js` file and change the data portion.

Example:

```js
module.exports = {
   
    service: {
        name: "Hypertheory",
        templates: ["./Service"],
        data: {
            namespace: "Vips.Api",
            "openapi-doc": "vips",
            "openapi-version": "v1",
            database: "vips"
        }
    }
}
```

Run the following command. 

```sh
npx simple-scaffold -o SomeFolder -t ./Service-Template  -c ./service-config.js -k service --overwrite
```

The `-o` is the output directory - you can give it a relative path to your project, or just do it locally and copy/paste.

