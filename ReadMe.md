## CoreMessage
# Request
- RequestMessage
- GetByIdRequest
- GetByIdRequest<T>
- IdRequest
- IdRequest<T>
- NoneRequest
- QueryByPageRequest

# Response
- ResponseMessage
- QueryResponse<TItem>
- QueryByPageResponse
- QueryByPageResponse<TItem>
- GetByIdResponse<T>
- ResponseMessageWrap<T>

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
Response headers
 content-type: application/json; charset=utf-8 
 date: Fri, 06 Apr 2018 13:28:05 GMT 
 server: Kestrel 
 transfer-encoding: chunked 
```
