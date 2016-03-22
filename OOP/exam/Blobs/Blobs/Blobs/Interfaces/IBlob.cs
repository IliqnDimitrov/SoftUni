namespace Blobs.Interfaces
{
    public interface IBlob 
    {
        string Name { get; set; }
        int Health { get; set; }
        int Damage { get; set; }
    }
}