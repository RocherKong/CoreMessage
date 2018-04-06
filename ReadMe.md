## CoreMessage
# Request
- RequestMessage
- GetByIdRequest
- GetByIdRequest&lt;T&gt;
- IdRequest
- IdRequest&lt;T&gt;
- NoneRequest
- QueryByPageRequest

# Response
- ResponseMessage
- QueryResponse&lt;TItem&gt;
- QueryByPageResponse
- QueryByPageResponse&lt;TItem&gt;
- GetByIdResponse&lt;T&gt;
- ResponseMessageWrap&lt;T&gt;

```c# 
* Use Bara ORM
[HttpPost]
 public ResponseMessageWrap<GetByPageResponse<B_Book>> Query([FromBody]QueryRequest reqMsg)
        {
            var list = baraMapper.Query<B_Book>(new Bara.Core.Context.RequestContext
            {
                Request = reqMsg,
                Scope = "B_Book",
                SqlId = "QueryListByPage"
            });

            var record = baraMapper.ExecuteScalar<int>(new Bara.Core.Context.RequestContext
            {
                Request = reqMsg,
                Scope = "B_Book",
                SqlId = "GetRecord"
            });

            return new ResponseMessageWrap<GetByPageResponse<B_Book>>
            {
                Body = new GetByPageResponse<B_Book>
                {
                    List = list,
                    TotalRecord = record
                }
            };
        }
```

```json
Request Parameters
{
  "PageIndex": 0,
  "PageSize": 0,
  "Header": {
    "Operator": 0,
    "IP": "string"
  }
}

Response body
{
  "IsSuccess": true,
  "ErrorCode": "00000",
  "Message": null,
  "Body": {
    "TotalRecord": 0,
    "List": []
  }
}

```
