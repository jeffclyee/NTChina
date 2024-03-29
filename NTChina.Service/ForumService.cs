﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NTChina.Data.Sqlserver.Infrastructure;
using NTChina.Domain;
using NTChina.Domain.Repositories;
using NTChina.Service.Interfaces;

namespace NTChina.Service
{
    public class ForumService : IForumService
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ForumService(ITopicRepository topicRepository, IUnitOfWork unitOfWork)
        {
            _topicRepository = topicRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddTopic(Topic topic)
        {
            _topicRepository.Add(topic);
            SaveChanges();
        }

        private void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
