namespace JE.Api.ClientBase.Serialization
{
    public interface ISerializer
    {
        T Deserialize<T>(string data);
        string Serialize(object obj);
    }
}