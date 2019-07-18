using System;

namespace CrudFramework.DecoratorClasses
{
    public class AuditInfo
    {
        public string UserName { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
