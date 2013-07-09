/*
 * Copyright 2012 - 2013 Matt Ellis
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Xml.Serialization;
using JetBrains.UI.Updates;
using JetBrains.VSIntegration.Updates;

namespace CitizenMatt.ReSharper.PreviewTab.Updates
{
    [XmlType]
    [XmlRoot("PluginLocalInfo")]
    [Serializable]
    public class PluginLocalEnvironmentInfo
    {
        [XmlElement]
        public UpdateLocalEnvironmentInfoVs LocalEnvironment = new UpdateLocalEnvironmentInfoVs();

        [XmlElement]
        public UpdateLocalEnvironmentInfo.VersionSubInfo PluginVersion = new UpdateLocalEnvironmentInfo.VersionSubInfo();
    }
}