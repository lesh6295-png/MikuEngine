using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miku.Types.Base
{
    public class Version : IComparer<Version>
    {
        int major, minor, build, revision;
        public int Major {get { return major; }}
        public int Minor { get { return minor; } }
        public int Build { get { return build; } }
        public int Revision { get { return revision; } }
        public override string ToString()
        {
            return $"{Major}.{Minor}.{Build}.{revision}";
        }

        public int Compare(Version x, Version y)
        {
            int r = y.Major - x.Major;
            if (r == 0)
            {
                r = y.Minor - x.Minor;
                if (r == 0)
                {
                    r = y.Build - x.Build;
                    if (r == 0)
                    {
                        r = y.Revision - x.Revision;
                        
                    }
                }
            }
            return r;
        }

        public Version(int major)
        {
            this.major = major;
        }
        public Version(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }
        public Version(int major, int minor, int build)
        {
            this.major = major;
            this.minor = minor;
            this.build = build;
        }
        public Version(int major, int minor, int build, int revision)
        {
            this.major = major;
            this.minor = minor;
            this.build = build;
            this.revision = revision;
        }
        public Version(string version)
        {
            string[] nums = version.Split('.');
            if (nums.Length < 1)
            {
                throw new Exception("Invalid string.");
            }
            major = Convert.ToInt32(nums[0]);
            if (nums.Length > 1)
            {
                minor = Convert.ToInt32(nums[1]);
                if (nums.Length > 2)
                {
                    build = Convert.ToInt32(nums[2]);
                    if (nums.Length > 3)
                    {
                        minor = Convert.ToInt32(nums[3]);
                    }
                }
            }
        }
    }
}
