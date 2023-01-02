using System;

using Miku.Types.Enums;
namespace Miku.Interfaces
{
    public interface IPlatformInfo
    {
        OsType OSData()
        {
            OsType ret=OsType.Unknown;
            if (OperatingSystem.IsWindows())
                ret = OsType.Windows;
            else if (OperatingSystem.IsLinux())
                ret = OsType.Linux;
            else if (OperatingSystem.IsMacOS())
                ret = OsType.MacOs;
            else if (OperatingSystem.IsAndroid())
                ret = OsType.Andriod;
            else if (OperatingSystem.IsIOS())
                ret = OsType.iOS;
            return ret;
        }
    }
}
