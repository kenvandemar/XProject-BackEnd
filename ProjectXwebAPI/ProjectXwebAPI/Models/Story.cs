//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectXwebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Story
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Story()
        {
            this.Chapters = new HashSet<Chapter>();
            this.UserWatches = new HashSet<UserWatch>();
            this.Genres = new HashSet<Genre>();
        }
    
        public int StoryId { get; set; }
        public string StoryName { get; set; }
        public int StoryProgress { get; set; }
        public string StoryDescription { get; set; }
        public int StoryStatus { get; set; }
        public int AuthorId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> LastEditedDate { get; set; }
        public string UserId { get; set; }
        public int Score { get; set; }
        public int RateCount { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
    
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chapter> Chapters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserWatch> UserWatches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
