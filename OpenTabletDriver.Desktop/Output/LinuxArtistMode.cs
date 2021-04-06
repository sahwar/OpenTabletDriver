using OpenTabletDriver.Desktop.Interop.Input.Absolute;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Output;
using OpenTabletDriver.Plugin.Platform.Pointer;

namespace OpenTabletDriver.Desktop.Output
{
    [PluginName("Artist Mode"), SupportedPlatform(PluginPlatform.Linux)]
    public class LinuxArtistMode : AbsoluteOutputMode, IPointerProvider<IAbsolutePointer>
    {
        public override IAbsolutePointer Pointer { set; get; } = new EvdevVirtualTablet();
    }
}
