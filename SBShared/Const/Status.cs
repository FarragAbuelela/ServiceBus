using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SBShared.Const
{
    [DataContract]
    public enum Status
    {
        [EnumMember]
        AddPerson,
        [EnumMember]
        DeletePerson,
        [EnumMember]
        UpdatePersonName,
        [EnumMember]
        UpdatePersonAge,
        [EnumMember]
        PrintPersonsList
    }
}
