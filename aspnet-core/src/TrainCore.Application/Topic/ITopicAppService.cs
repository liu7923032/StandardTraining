using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using TrainCore.Topic.Dto;

namespace TrainCore.Topic
{
    public interface ITopicAppService: IAsyncCrudAppService<TopicDto,int,GetAllTopicsInput,CreateTopicInput,UpdateTopicInput>
    {
        
    }
}
