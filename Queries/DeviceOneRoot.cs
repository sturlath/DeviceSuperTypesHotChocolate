using DeviceSuperTypesHotChocolate.Queries;

[ExtendObjectType("Query")]
public class DeviceOneRoot
{
    private readonly IDeviceOneRepository deviceOneRepository;

    public DeviceOneRoot(IDeviceOneRepository deviceOneRepository)
    {
        this.deviceOneRepository = deviceOneRepository;
    }

    public DeviceOne DeviceOne()
    {
        return new DeviceOne(deviceOneRepository);
    }
}