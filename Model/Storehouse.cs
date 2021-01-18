
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Model
{

using System;
    using System.Collections.Generic;
    
public partial class Storehouse
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Storehouse()
    {

        this.ProbaictStorage = new HashSet<ProbaictStorage>();

    }


    public int StorId { get; set; }

    public string StoreNum { get; set; }

    public string StoreName { get; set; }

    public int Supid { get; set; }

    public int StId { get; set; }

    public int IsMoren { get; set; }

    public System.DateTime CreateTime { get; set; }

    public int IsDelete { get; set; }

    public string Remake { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ProbaictStorage> ProbaictStorage { get; set; }

    public virtual Storehousetype Storehousetype { get; set; }

    public virtual Supplier Supplier { get; set; }

}

}
