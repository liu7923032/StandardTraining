using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    public class PaperTopic : CreationAuditedEntity
    {
        //题目隶属的试卷
        public int PaperId { get; set; }

        [ForeignKey("PaperId")]
        public virtual Paper Paper { get; set; }

        public int TopicId { get; set; }

        //题目序号
        public int Sort { get; set; }

        //题目的分数
        public int Grade { get; set; }

        public virtual ICollection<TopicOption> Options { get; set; }


    }

}
