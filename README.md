# diffingapi

Binary Diffing API

# Assignment Info
• Provided 2 http endpoints (<host>/v1/diff/<ID>/left and <host>/v1/diff/<ID>/right) that accept 
JSON containing base64 encoded binary data on both endpoints.
• The provided data needs to be diff-ed and the results shall be available on a third endpoint 
(<host>/v1/diff/<ID>). The results shall provide the following info in JSON format:
o If equal return that
o If not of equal size just return that
o If of same size provide insight in where the diff are, actual diffs are not needed.
	▪ So mainly offsets + length in the data
	
# Technologies in use:

    • OpenAPI (Swagger.io)
	• ASP .Net core
    • Application server IIS Express

# Project structure


## Read me file

	 • This readme file: README.md

## Server API documentation

	 • file swagger.yaml
	 
## Server code

	 • folder aspnetcore-server
	 
### Unit test

To test internal logic run unit test on folder aspnetcore-server\UnitTestProject1

## Client code

	 • folder csharp-client

### Integartion test

To test functionality run on folder csharp-client\IntegrationTestProject1

