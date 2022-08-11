public interface IDeviceTwoRepository
{
    Task<List<SomeInfo2>> SomethingOtherThanSomeData(Guid deviceId);
}