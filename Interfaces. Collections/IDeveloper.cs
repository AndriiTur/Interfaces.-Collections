namespace Interfaces.Collections
{
    interface IDeveloper
    {
        string Tool { get; set; }

        void Create();
        void Destroy();
    }
}
