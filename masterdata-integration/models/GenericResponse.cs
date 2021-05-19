using System;
using System.Collections.Generic;
namespace masterdata_integration.models
{
    public class GenericResponse<T>
    {
        public T data { get; set; }
        public int responseStatus { get; set; }
        public Message message { get; set; }
    }
}
