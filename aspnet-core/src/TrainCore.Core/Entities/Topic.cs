using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace TrainCore.Entities
{
    //题库
    public class Topic : FullAuditedEntity
    {
        //题目名称
        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

        //题目说明及建议
        [Required]
        public string Describe { get; set; }

        //题目类型
        public TopicEnum TopicType { get; set; }

        //题目的等级
        [Required]
        public  int Level { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        //知识点
        public string KnownPoint { get; set; }

        //题目的答案
        [Required]
        public string Answer { get; set; }

        //题目解析
        public string Analyize { get; set; }

        //题目的状态
        [Required]
        public TopicStatus TopicStatus { get; set; }

    }


    public enum TopicStatus
    {
        //初始状态
        Init,
        //审核完成状态
        Approve
    }


    public enum TopicEnum
    {
        //单选
        Single,
        //多选
        Multi,
        //问答
        QA
    }

}
