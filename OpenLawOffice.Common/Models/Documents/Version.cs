﻿// -----------------------------------------------------------------------
// <copyright file="Version.cs" company="Nodine Legal, LLC">
// Licensed to Nodine Legal, LLC under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  Nodine Legal, LLC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>
// -----------------------------------------------------------------------

namespace OpenLawOffice.Common.Models.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [MapMe]
    public class Version : Core
    {
        public Guid? Id { get; set; }
        public Document Document { get; set; }
        public int VersionNumber { get; set; }
        public string Mime { get; set; }
        public string Filename { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public string Md5 { get; set; }

        public Version()
        {
        }
        
        public override void BuildMappings()
        {
        }
    }
}