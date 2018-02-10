using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    /// <summary>
    /// 题目选项
    /// </summary>
    public class TopicOption:CreationAuditedEntity
    {
        //隶属于哪个题目
        public int TopicId { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }

        //代码 可是 A,B,C,D
        public string Code { get; set; }

        //选项的名称
        public string Name { get; set; }

        //选项的序号
        public int Sort { get; set; }

        //选项是否正确
        public bool IsRight { get; set; }
    }
}
