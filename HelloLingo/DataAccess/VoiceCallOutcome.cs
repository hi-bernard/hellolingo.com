//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Considerate.Hellolingo.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoiceCallOutcome
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoiceCallOutcome()
        {
            this.VoiceCalls = new HashSet<VoiceCall>();
        }
    
        public byte Id { get; set; }
        public string Outcome { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoiceCall> VoiceCalls { get; set; }
    }
}
