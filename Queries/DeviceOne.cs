namespace DeviceSuperTypesHotChocolate.Queries
{
    public class DeviceOne : IDeviceOneRepository
    {
        private readonly IDeviceOneRepository deviceOneRepository;

        public DeviceOne(IDeviceOneRepository deviceOneRepository)
        {
            this.deviceOneRepository = deviceOneRepository;
        }

        public async Task<List<SomeInfo1>> SomeData(Guid deviceId)
        {
            return await deviceOneRepository.SomeData(deviceId);
        }
    }
}
