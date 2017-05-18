using System;

namespace TeduShop.Model.Models
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }//?: nullable
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }//?: nullable
        string UpdatedBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }

    }
}