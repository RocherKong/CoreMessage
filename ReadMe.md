## CoreMessage
# Request
- RequestMessage
- GetByIdRequest
- IdRequest
- NoneRequest
- QueryByPageRequest

# Response
- ResponseMessage
- QueryResponse
- QueryByPageResponse
- GetByIdResponse
- ResponseMessageWrap

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
