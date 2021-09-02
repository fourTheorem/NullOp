## Build

```
dotnet publish -c Debug
docker build -t nullop .
```

## Run

```
docker-compose up
```

## Test

Browse to `http://localhost:5001/swagger/index.html` and use payload:

```
{
  "payload": {
    "MyStringProperty": "StringValue",
    "MyIntegerProperty": 1,
    "MySubDocument": {
      "SubDocumentProperty": "SubDocumentValue"
    },
    "MyListProperty": [1,2,3]
  }
}

```

or


```
curl -X POST "https://localhost:5001/Noop" -H  "accept: */*" -H  "Content-Type: application/json" -d "{\"payload\":{\"MyStringProperty\":\"StringValue\",\"MyIntegerProperty\":1,\"MySubDocument\":{\"SubDocumentProperty\":\"SubDocumentValue\"},\"MyListProperty\":[1,2,3]}}"
```

