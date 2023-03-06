using ATOS.Resource.Common.Abstraction.Interfaces;

namespace ATOS.Resource.Common.Abstraction
{
    public class EntityBaseAuditable<Tkey, TUserKey> : EntityBase, IEntityBaseAuditable<Tkey, TUserKey>
    {
        public DateTime ModifiedDate { get; set; }
        public TUserKey ModifiedBy { get; set; }
    }
}
