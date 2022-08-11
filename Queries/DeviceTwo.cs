namespace DeviceSuperTypesHotChocolate.Queries
{
    public class DeviceTwo : IDeviceTwoRepository
    {
        private readonly IDeviceTwoRepository deviceTwoRepository;

        public DeviceTwo(IDeviceTwoRepository deviceTwoRepository)
        {
            this.deviceTwoRepository = deviceTwoRepository;
        }

        public async Task<List<SomeInfo2>> SomethingOtherThanSomeData(Guid deviceId)
        {
            return await deviceTwoRepository.SomethingOtherThanSomeData(deviceId);
        }
    }
}