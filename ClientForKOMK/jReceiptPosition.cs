//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientForKOMK
{
    using System;
    using System.Collections.Generic;
    
    public partial class jReceiptPosition
    {
        public int ReceiptId { get; set; }
        public int DishId { get; set; }
        public int DishAmount { get; set; }
        public decimal DishCost { get; set; }
        public int MenuId { get; set; }
        public int ReceiptPositionId { get; set; }
        public bool Exist { get; set; }
    
        public virtual hDish hDish { get; set; }
        public virtual hMenuId hMenuId { get; set; }
        public virtual jReceipt jReceipt { get; set; }
    }
}