using System;
using System.Collections.Generic;
using System.Text;

namespace MglZvvq.Core
{
  public  class gaojian
    {
        public Guid ID { get; }

        public DateTime CreateTime { get; }
        public string  Content{ get; }
        public  string Auther  { get; }
        public string AutherID { get; }


        public gaojian(DateTime createTime, string content, string auther,string autherID)
        {
            CreateTime = createTime;
            Content = content;
            Auther = auther;
            AutherID = autherID;

        }
    }
}
