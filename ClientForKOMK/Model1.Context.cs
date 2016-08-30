﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KOMK_v11_Procedure_BasePackEntities1 : DbContext
    {
        public KOMK_v11_Procedure_BasePackEntities1()
            : base("name=KOMK_v11_Procedure_BasePackEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hCashBox> hCashBox { get; set; }
        public virtual DbSet<hDish> hDish { get; set; }
        public virtual DbSet<hDishComposition> hDishComposition { get; set; }
        public virtual DbSet<hIngridient> hIngridient { get; set; }
        public virtual DbSet<hMenuId> hMenuId { get; set; }
        public virtual DbSet<hPersonal> hPersonal { get; set; }
        public virtual DbSet<jDish> jDish { get; set; }
        public virtual DbSet<jDishWarehouse> jDishWarehouse { get; set; }
        public virtual DbSet<jEntrancePosition> jEntrancePosition { get; set; }
        public virtual DbSet<jMenuComposition> jMenuComposition { get; set; }
        public virtual DbSet<jReceipt> jReceipt { get; set; }
        public virtual DbSet<jReceiptPosition> jReceiptPosition { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual int InshDish(Nullable<int> dishId, string dishName, Nullable<int> persId, Nullable<System.DateTime> dishDate, Nullable<float> hrsAm)
        {
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            var dishNameParameter = dishName != null ?
                new ObjectParameter("DishName", dishName) :
                new ObjectParameter("DishName", typeof(string));
    
            var persIdParameter = persId.HasValue ?
                new ObjectParameter("PersId", persId) :
                new ObjectParameter("PersId", typeof(int));
    
            var dishDateParameter = dishDate.HasValue ?
                new ObjectParameter("DishDate", dishDate) :
                new ObjectParameter("DishDate", typeof(System.DateTime));
    
            var hrsAmParameter = hrsAm.HasValue ?
                new ObjectParameter("HrsAm", hrsAm) :
                new ObjectParameter("HrsAm", typeof(float));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InshDish", dishIdParameter, dishNameParameter, persIdParameter, dishDateParameter, hrsAmParameter);
        }
    
        public virtual int InshDishComposition(Nullable<int> dishId, Nullable<int> ingId, Nullable<int> ingAm)
        {
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            var ingIdParameter = ingId.HasValue ?
                new ObjectParameter("IngId", ingId) :
                new ObjectParameter("IngId", typeof(int));
    
            var ingAmParameter = ingAm.HasValue ?
                new ObjectParameter("IngAm", ingAm) :
                new ObjectParameter("IngAm", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InshDishComposition", dishIdParameter, ingIdParameter, ingAmParameter);
        }
    
        public virtual int InshIngridient(Nullable<int> ingId, string ingName)
        {
            var ingIdParameter = ingId.HasValue ?
                new ObjectParameter("IngId", ingId) :
                new ObjectParameter("IngId", typeof(int));
    
            var ingNameParameter = ingName != null ?
                new ObjectParameter("IngName", ingName) :
                new ObjectParameter("IngName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InshIngridient", ingIdParameter, ingNameParameter);
        }
    
        public virtual int InshMenuId(Nullable<System.DateTime> menuDate)
        {
            var menuDateParameter = menuDate.HasValue ?
                new ObjectParameter("MenuDate", menuDate) :
                new ObjectParameter("MenuDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InshMenuId", menuDateParameter);
        }
    
        public virtual int InshPersonal(string persFIN, Nullable<decimal> persCost, Nullable<System.DateTime> persDate)
        {
            var persFINParameter = persFIN != null ?
                new ObjectParameter("PersFIN", persFIN) :
                new ObjectParameter("PersFIN", typeof(string));
    
            var persCostParameter = persCost.HasValue ?
                new ObjectParameter("PersCost", persCost) :
                new ObjectParameter("PersCost", typeof(decimal));
    
            var persDateParameter = persDate.HasValue ?
                new ObjectParameter("PersDate", persDate) :
                new ObjectParameter("PersDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InshPersonal", persFINParameter, persCostParameter, persDateParameter);
        }
    
        public virtual int InsjEntrance(Nullable<decimal> entCost, Nullable<System.DateTime> entDT, Nullable<int> ingId, Nullable<int> ingAm, Nullable<decimal> ingCost)
        {
            var entCostParameter = entCost.HasValue ?
                new ObjectParameter("EntCost", entCost) :
                new ObjectParameter("EntCost", typeof(decimal));
    
            var entDTParameter = entDT.HasValue ?
                new ObjectParameter("EntDT", entDT) :
                new ObjectParameter("EntDT", typeof(System.DateTime));
    
            var ingIdParameter = ingId.HasValue ?
                new ObjectParameter("IngId", ingId) :
                new ObjectParameter("IngId", typeof(int));
    
            var ingAmParameter = ingAm.HasValue ?
                new ObjectParameter("IngAm", ingAm) :
                new ObjectParameter("IngAm", typeof(int));
    
            var ingCostParameter = ingCost.HasValue ?
                new ObjectParameter("IngCost", ingCost) :
                new ObjectParameter("IngCost", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsjEntrance", entCostParameter, entDTParameter, ingIdParameter, ingAmParameter, ingCostParameter);
        }
    
        public virtual int InsjMenu(Nullable<int> menuId, Nullable<int> dishId)
        {
            var menuIdParameter = menuId.HasValue ?
                new ObjectParameter("MenuId", menuId) :
                new ObjectParameter("MenuId", typeof(int));
    
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsjMenu", menuIdParameter, dishIdParameter);
        }
    
        public virtual int InsjMenuComposition(Nullable<int> dishId, Nullable<int> dishAm, Nullable<System.DateTime> dishDate)
        {
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            var dishAmParameter = dishAm.HasValue ?
                new ObjectParameter("DishAm", dishAm) :
                new ObjectParameter("DishAm", typeof(int));
    
            var dishDateParameter = dishDate.HasValue ?
                new ObjectParameter("DishDate", dishDate) :
                new ObjectParameter("DishDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsjMenuComposition", dishIdParameter, dishAmParameter, dishDateParameter);
        }
    
        public virtual int InsjReceiptCashBox(Nullable<int> persId, Nullable<int> cashBoxId, Nullable<decimal> sumAmount)
        {
            var persIdParameter = persId.HasValue ?
                new ObjectParameter("PersId", persId) :
                new ObjectParameter("PersId", typeof(int));
    
            var cashBoxIdParameter = cashBoxId.HasValue ?
                new ObjectParameter("CashBoxId", cashBoxId) :
                new ObjectParameter("CashBoxId", typeof(int));
    
            var sumAmountParameter = sumAmount.HasValue ?
                new ObjectParameter("SumAmount", sumAmount) :
                new ObjectParameter("SumAmount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsjReceiptCashBox", persIdParameter, cashBoxIdParameter, sumAmountParameter);
        }
    
        public virtual int InsReceiptPosition(Nullable<int> receiptId, Nullable<int> dishId, Nullable<int> dishAm)
        {
            var receiptIdParameter = receiptId.HasValue ?
                new ObjectParameter("ReceiptId", receiptId) :
                new ObjectParameter("ReceiptId", typeof(int));
    
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            var dishAmParameter = dishAm.HasValue ?
                new ObjectParameter("DishAm", dishAm) :
                new ObjectParameter("DishAm", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsReceiptPosition", receiptIdParameter, dishIdParameter, dishAmParameter);
        }
    
        public virtual int pDeleteDish(Nullable<int> dishId)
        {
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pDeleteDish", dishIdParameter);
        }
    
        public virtual ObjectResult<pGetDishComposition_Result> pGetDishComposition(Nullable<int> dishId)
        {
            var dishIdParameter = dishId.HasValue ?
                new ObjectParameter("DishId", dishId) :
                new ObjectParameter("DishId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pGetDishComposition_Result>("pGetDishComposition", dishIdParameter);
        }
    
        public virtual ObjectResult<pGetMenu_Result> pGetMenu(Nullable<int> menuId, Nullable<System.DateTime> menuDate)
        {
            var menuIdParameter = menuId.HasValue ?
                new ObjectParameter("MenuId", menuId) :
                new ObjectParameter("MenuId", typeof(int));
    
            var menuDateParameter = menuDate.HasValue ?
                new ObjectParameter("MenuDate", menuDate) :
                new ObjectParameter("MenuDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pGetMenu_Result>("pGetMenu", menuIdParameter, menuDateParameter);
        }
    
        public virtual ObjectResult<pGetReceipt_Result> pGetReceipt(Nullable<int> receiptId)
        {
            var receiptIdParameter = receiptId.HasValue ?
                new ObjectParameter("ReceiptId", receiptId) :
                new ObjectParameter("ReceiptId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pGetReceipt_Result>("pGetReceipt", receiptIdParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
