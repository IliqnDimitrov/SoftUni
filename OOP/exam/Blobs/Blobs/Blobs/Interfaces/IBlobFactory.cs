namespace Blobs.Interfaces
{
    public interface IBlobFactory
    {
        IBlob CreateBlob(string blobType, string name, int health, int damage);
    }
}