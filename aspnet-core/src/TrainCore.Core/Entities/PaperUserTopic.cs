using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    /// <summary>
    /// 用户的答案
    /// </summary>
    public class PaperUserTopic : CreationAuditedEntity
    {
        public int TopicId { get; set; }

        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }

        //用户的答案
        public string MyAnswer { get; set; }

        //用户的得分
        public int UserGrade { get; set; }

        //隶属用户
        public int UserPaperId { get; set; }

        [ForeignKey("UserPaperId")]
        public virtual PaperUser UserPaper { get; set; }
    }
}
