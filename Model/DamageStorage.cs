
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
    
public partial class DamageStorage
{

    public int DamSId { get; set; }

    public int Damid { get; set; }

    public string ProId { get; set; }

    public int ProBaoSNum { get; set; }



    public virtual Damage Damage { get; set; }

    public virtual Probaict Probaict { get; set; }

}

}
