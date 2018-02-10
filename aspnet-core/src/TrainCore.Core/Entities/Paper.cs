using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    public class Paper:FullAuditedEntity
    {
        //试卷名称
        public string Name { get; set; }
        //试卷描述
        public string Describe { get; set; }
        //试卷类型
        public PaperEnum PaperType { get; set; }

        //试卷开始
        public DateTime StartDate { get; set; }

        //试卷结束
        public DateTime EndDate { get; set; }

        //试卷的状态
        public PaperStatus PaperStatus { get; set; }

        //总成绩
        public int AllGrade { get; set; }

        //通过成绩
        public int PassGrade { get; set; }


    }

    //试卷状态
    public enum PaperStatus
    {
        //初始
        Init,
        //批改，试卷结束后，状态改为批改状态
        Approve,
        //完结
        End

    }

    /// <summary>
    /// 试卷类型
    /// </summary>
    public enum PaperEnum
    {
        //正常试卷
        Normal,
        //练习
        Practice
    }
}
