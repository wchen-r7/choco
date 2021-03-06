﻿// Copyright © 2011 - Present RealDimensions Software, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
// You may obtain a copy of the License at
// 
// 	http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace chocolatey.infrastructure.app.attributes
{
    using System;
    using domain;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class CommandForAttribute : Attribute
    {
        public string CommandName { get; private set; }
        public string Description { get; private set; }

        public CommandForAttribute(string commandName, string description)
        {
            CommandName = commandName;
            Description = description;
        }
    }
}