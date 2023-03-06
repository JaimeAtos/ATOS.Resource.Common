using Atos.Core.Abstractions;

namespace ATOS.Resource.Common.Abstraction.Interfaces
{
    public interface IDtoBaseAuditable<TKey, TUserKey> : IDtoBase<TKey, TUserKey>
    {
        public DateTime? ModifiedDate { get; set; } 
        public TUserKey? ModifiedBy { get; set; }
    }
}
