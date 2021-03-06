﻿// <copyright file="ActivationResult.cs" company="Microsoft Open Technologies, Inc.">
// Copyright 2011-2013 Microsoft Open Technologies, Inc. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace Microsoft.AspNet.Razor.Owin.Execution
{
    public class ActivationResult
    {
        private ActivationResult(bool success, IRazorPage page)
        {
            Success = success;
            Page = page;
        }

        public bool Success { get; private set; }
        public IRazorPage Page { get; private set; }

        public static ActivationResult Failed()
        {
            return new ActivationResult(false, null);
        }

        public static ActivationResult Successful(IRazorPage page)
        {
            return new ActivationResult(true, page);
        }
    }
}
