using System;
using System.Collections.Generic;

namespace HSExerc.Entities
{
    public class LRecords
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LRecords))
            {
                return false;
            }
            LRecords other = obj as LRecords;
            return UserName.Equals(other.UserName);
        }
    }
}