﻿using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metech.SimpleTaskApp.Tasks.Dtos
{
    public class TaskDto : EntityDto<long>
    {
        public long TaskId { get; set; }
        public int? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public byte State { get; set; }

        //This method is just used by the Console Application to list tasks
        public override string ToString()
        {
            return string.Format(
                "[Task Id={0}, Description={1}, CreationTime={2}, AssignedPersonName={3}, State={4}]",
                Id,
                Description,
                CreationTime,
                AssignedPersonId,
                (TaskState)State
                );
        }
    }
}
