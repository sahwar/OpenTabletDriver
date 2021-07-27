using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Tablet;

namespace OpenTabletDriver.Vendors.UCLogic
{
    public class UCLogicReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] data)
        {
            if (data[1].IsBitSet(6))
                return new UCLogicAuxReport(data);
            else
                return new TabletReport(data);
        }
    }
}