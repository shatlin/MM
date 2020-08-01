using System;

namespace MM.ClientModels
{
    public interface ITenantIdProvider<out T>
        where T : IEquatable<T>
    {
        T TenantId { get; }
    }
}