﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Message
{
    public class ResponseMessageWrap<T> //where T : new()
    {
        public ResponseMessageWrap()
        {
            //Body = new T();
            IsSuccess = true;
            ErrorCode = "00000";
        }
        public bool IsSuccess { get; set; }
        public String ErrorCode { get; set; }
        public String Message { get; set; }
        public T Body { get; set; }
    }
}