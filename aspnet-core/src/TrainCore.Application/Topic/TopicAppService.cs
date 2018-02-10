using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using TrainCore.Topic.Dto;
using TrainCore.Entities;
using System.Linq;
using Abp.Linq.Extensions;

namespace TrainCore.Topic
{
    public class TopicAppService : AsyncCrudAppService<Entities.Topic, TopicDto, int, GetAllTopicsInput, CreateTopicInput, UpdateTopicInput>, ITopicAppService
    {
        private readonly IRepository<Entities.Topic> _topicRepository;

        public TopicAppService(IRepository<Entities.Topic> topicRepository) : base(topicRepository)
        {
            _topicRepository = topicRepository;
        }

        protected override IQueryable<Entities.Topic> CreateFilteredQuery(GetAllTopicsInput input)
        {
            return base.CreateFilteredQuery(input)
                    .WhereIf(input.CategoryId.HasValue, u => u.CategoryId.Equals(input.CategoryId.Value))
                    .WhereIf(string.IsNullOrEmpty(input.Name), u => u.Name.Contains(input.Name));
        }
    }


}
