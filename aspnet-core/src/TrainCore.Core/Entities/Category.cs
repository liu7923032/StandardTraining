using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    public class Category:FullAuditedEntity
    {
        //编码
        public string Code { get; set; }
        //类别名称
        public string Name { get; set; }

        //分类描述
        public string Describe { get; set; }
    }
}
