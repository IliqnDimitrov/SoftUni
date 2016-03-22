namespace Blobs.Interfaces
{
    public interface IBlob 
    {
        string Name { get; set; }
        int Health { get; set; }
        int Damage { get; set; }
        bool isTriged { get; set; }
        void AttackBH(IBlob blob1);
        void BH(IBlob blob2);
    }
}