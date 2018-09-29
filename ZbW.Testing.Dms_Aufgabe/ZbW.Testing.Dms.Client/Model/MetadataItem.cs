﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

[assembly: InternalsVisibleTo("Zbw.Testing.Dms.Client.UnitTests")]
namespace ZbW.Testing.Dms.Client.Model
{
    internal class MetadataItem
    {
        public string Description;
        public DateTime ValutaDateTime;
        public string Type;
        public string Tags;
        public DateTime CreationDateTime;
        public string Creator;

        [XmlIgnore]
        public bool DeleteFile;

        public MetadataItem(string description, DateTime valutaDateTime, string type, string tags,
            DateTime creationDateTime, string creator, bool deleteFile)
        {
            this.Description = description;
            this.ValutaDateTime = valutaDateTime;
            this.Type = type;
            this.Tags = tags;
            this.CreationDateTime = creationDateTime;
            this.Creator = creator;
            this.DeleteFile = deleteFile;
        }
    }
}