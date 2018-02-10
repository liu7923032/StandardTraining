using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using TrainCore.Entities;

namespace TrainCore.Topic.Dto
{
    /// <summary>
    /// 增
    /// </summary>
    public class CreateTopicInput
    {
        //题目名称
        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

        //题目说明及建议
        [Required]
        public string Describe { get; set; }

        //题目类型
        [Required]
        public TopicEnum TopicType { get; set; }

        //题目的等级
        [Required]
        public int Level { get; set; }

        [Required]
        public int CategoryId { get; set; }

        //知识点
        public string KnownPoint { get; set; }

        //题目的答案
        [Required]
        public string Answer { get; set; }

        //题目解析
        public string Analyize { get; set; }

    }

    /// <summary>
    /// 改
    /// </summary>
    public class UpdateTopicInput : CreateTopicInput, IEntityDto
    {
        [Required]
        public int Id { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TopicDto : UpdateTopicInput
    {

    }


    public class GetAllTopicsInput : PagedAndSortedResultRequestDto
    {
        public int? CategoryId { get; set; }

        public string Name { get; set; }

    }




}
