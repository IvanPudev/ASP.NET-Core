namespace KidsCenter.Services.Data
{
    using System.Collections.Generic;

    public interface IEventService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
