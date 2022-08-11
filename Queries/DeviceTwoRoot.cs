using DeviceSuperTypesHotChocolate.Queries;

[ExtendObjectType("Query")]
public class DeviceTwoRoot
{
    public DeviceTwo? DeviceTwo { get; set; }
}