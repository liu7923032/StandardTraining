using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    //参与考试的人员
    public class PaperUser : CreationAuditedEntity
    {
        public int PaperId { get; set; }

        [ForeignKey("PapperId")]
        public Paper Paper { get; set; }

        public long UserId { get; set; }

        //人员成绩
        public int Grade { get; set; }
        //用户试卷状态
        public UserPStatus UserPStatus { get; set; }

        //用户的答案信息
        public virtual List<PaperUserTopic> UserSubList { get; set; }
    }

    /// <summary>
    /// 用户试卷的状态
    /// </summary>
    public enum UserPStatus
    {
        //待开始
        Init,
        //进行中
        Running,
        //考试完结
        End
    }
}
