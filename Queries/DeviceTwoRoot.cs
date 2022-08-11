using DeviceSuperTypesHotChocolate.Queries;

[ExtendObjectType("Query")]
public class DeviceTwoRoot
{
    private readonly IDeviceTwoRepository deviceTwoRepository;

    public DeviceTwoRoot(IDeviceTwoRepository deviceTwoRepository)
    {
        this.deviceTwoRepository = deviceTwoRepository;
    }

    public DeviceTwo DeviceTwo()
    {
        return new DeviceTwo(deviceTwoRepository);
    }
}