//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Item.cs'.
//
//     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    public partial class Item
    {
        #region Root Data Access

        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;

            LoadProperty(_productIdProperty, "BN");
            ValidationRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(ItemCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_ItemId", ItemId);
					command.Parameters.AddWithValue("@p_ProductId", ProductId);
					command.Parameters.AddWithValue("@p_ListPrice", ListPrice);
					command.Parameters.AddWithValue("@p_UnitCost", UnitCost);
					command.Parameters.AddWithValue("@p_Supplier", Supplier);
					command.Parameters.AddWithValue("@p_Status", Status);
					command.Parameters.AddWithValue("@p_Name", Name);
					command.Parameters.AddWithValue("@p_Image", Image);

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            using (BypassPropertyChecks)
                            {
                            }
                        }
                    }
                }

				FieldManager.UpdateChildren(this, connection);
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            const string commandText = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_ItemId";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_ItemId", ItemId);
					command.Parameters.AddWithValue("@p_ProductId", ProductId);
					command.Parameters.AddWithValue("@p_ListPrice", ListPrice);
					command.Parameters.AddWithValue("@p_UnitCost", UnitCost);
					command.Parameters.AddWithValue("@p_Supplier", Supplier);
					command.Parameters.AddWithValue("@p_Status", Status);
					command.Parameters.AddWithValue("@p_Name", Name);
					command.Parameters.AddWithValue("@p_Image", Image);

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
							
					FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ItemCriteria (ItemId));
        
			OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(ItemCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Child Data Access

        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;

            LoadProperty(_productIdProperty, "BN");
            ValidationRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(ItemCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();

            MarkAsChild();
        }

        private void Child_Insert(Product product, Supplier supplier, SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(ref cancel);
            if (cancel) return;

			if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ItemId", ItemId);
					command.Parameters.AddWithValue("@p_ProductId", product.ProductId);
					command.Parameters.AddWithValue("@p_ListPrice", ListPrice);
					command.Parameters.AddWithValue("@p_UnitCost", UnitCost);
					command.Parameters.AddWithValue("@p_Supplier", supplier.SuppId);
					command.Parameters.AddWithValue("@p_Status", Status);
					command.Parameters.AddWithValue("@p_Name", Name);
					command.Parameters.AddWithValue("@p_Image", Image);

                using(var reader = new SafeDataReader(command.ExecuteReader()))
                {
                    if(reader.Read())
                    {
                    }
                }
            }

            OnChildInserted();
        }

        private void Child_Update(Product product, Supplier supplier, SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(ref cancel);
            if (cancel) return;

			if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_ItemId";
            using(SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ItemId", ItemId);
					command.Parameters.AddWithValue("@p_ProductId", product.ProductId);
					command.Parameters.AddWithValue("@p_ListPrice", ListPrice);
					command.Parameters.AddWithValue("@p_UnitCost", UnitCost);
					command.Parameters.AddWithValue("@p_Supplier", supplier.SuppId);
					command.Parameters.AddWithValue("@p_Status", Status);
					command.Parameters.AddWithValue("@p_Name", Name);
					command.Parameters.AddWithValue("@p_Image", Image);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnChildUpdated();
        }

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ItemCriteria (ItemId));
        
			OnChildSelfDeleted();
        }

        #endregion

        private void Map(SafeDataReader reader)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_itemIdProperty, reader.GetString("ItemId"));
                LoadProperty(_productIdProperty, reader.GetString("ProductId"));
                LoadProperty(_listPriceProperty, reader.GetDecimal("ListPrice"));
                LoadProperty(_unitCostProperty, reader.GetDecimal("UnitCost"));
                LoadProperty(_supplierProperty, reader.GetInt32("Supplier"));
                LoadProperty(_statusProperty, reader.GetString("Status"));
                LoadProperty(_nameProperty, reader.GetString("Name"));
                LoadProperty(_imageProperty, reader.GetString("Image"));
            }

            MarkOld();
        }

        #region Data access partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(ItemCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Child data access partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(ItemCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnChildInserting(ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleted();

        #endregion
    }
}