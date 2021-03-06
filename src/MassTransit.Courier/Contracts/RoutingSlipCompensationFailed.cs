﻿// Copyright 2007-2013 Chris Patterson
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Courier.Contracts
{
    using System;


    public interface RoutingSlipCompensationFailed
    {
        /// <summary>
        /// The tracking number of the routing slip that faulted
        /// </summary>
        Guid TrackingNumber { get; }

        /// <summary>
        /// The date/time when the routing slip compensation was finished
        /// </summary>
        DateTime Timestamp { get; }

        /// <summary>
        /// The exception information from the faulting activity
        /// </summary>
        ExceptionInfo ExceptionInfo { get; }

        /// <summary>
        /// The exception source
        /// </summary>
        [Obsolete("Consider using the new ExceptionInfo property instead")]
        string Source { get; }

        /// <summary>
        /// The exception message
        /// </summary>
        [Obsolete("Consider using the new ExceptionInfo property instead")]
        string Message { get; }

        /// <summary>
        /// The exception stack trace
        /// </summary>
        [Obsolete("Consider using the new ExceptionInfo property instead")]
        string StackTrace { get; }
    }
}