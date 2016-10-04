#region Copyright
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2016
// by DotNetNuke Corporation
// All Rights Reserved
#endregion

using System;
using System.Runtime.Serialization;

namespace Dnn.Modules.HelloWorld.Dto
{
    /// <summary>
    /// Data Transfer object that represents a Task
    /// </summary>
    [Serializable]
    [DataContract]
    public class TaskDto
    {
        [DataMember]
        public int TaskId { get; set; }

        [DataMember]
        public string TaskName { get; set; }
    }
}
