module.exports = {
   
    service: {
        name: "Hypertheory",
        templates: ["./Service"],
        data: {
            namespace: "Thing.Api",
            "openapi-doc": "thing",
            "openapi-version": "v1",
            database: "thing"
        }
    }
}