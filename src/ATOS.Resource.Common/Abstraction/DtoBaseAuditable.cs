using ATOS.Resource.Common.Abstraction.Interfaces;

namespace ATOS.Resource.Common.Abstraction
{
    public class DtoBaseAuditable<Tkey, TUserKey> : DtoBase, IDtoBaseAuditable<Tkey, TUserKey>
    {
        public DateTime ModifiedDate { get; set; } 
        public TUserKey ModifiedBy { get; set; }
    }
}
