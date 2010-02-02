'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
'
'     Template: EditableChild.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Public Partial Class Cart
    <RunLocal()> _
    Protected Overrides Sub Child_Create()
        ' TODO: load default values
        ' omit this override if you have no defaults to set
        'MyBase.Child_Create()
    End Sub
    
    Private Sub Child_Fetch(ByVal criteria As CartCriteria)
        Dim commandText As String = String.Format("SELECT [CartId], [UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity] FROM [dbo].[Cart] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Cart' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using
    End Sub
    
    Private Sub Child_Insert(ByVal profile As Profile)
        Const commandText As String = "INSERT INTO [dbo].[Cart] ([UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity]) VALUES (@p_UniqueID, @p_ItemId, @p_Name, @p_Type, @p_Price, @p_CategoryId, @p_ProductId, @p_IsShoppingCart, @p_Quantity); SELECT [CartId] FROM [dbo].[Cart] WHERE CartId = SCOPE_IDENTITY()"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UniqueID", profile.UniqueID)
				command.Parameters.AddWithValue("@p_ItemId", ItemId)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Type", Type)
				command.Parameters.AddWithValue("@p_Price", Price)
				command.Parameters.AddWithValue("@p_CategoryId", CategoryId)
				command.Parameters.AddWithValue("@p_ProductId", ProductId)
				command.Parameters.AddWithValue("@p_IsShoppingCart", IsShoppingCart)
				command.Parameters.AddWithValue("@p_Quantity", Quantity)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        LoadProperty(_cartIdProperty, reader.GetInt32("CartId"))
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Child_Update(ByVal profile As Profile)
        Const commandText As String = "UPDATE [dbo].[Cart]  SET [UniqueID] = @p_UniqueID, [ItemId] = @p_ItemId, [Name] = @p_Name, [Type] = @p_Type, [Price] = @p_Price, [CategoryId] = @p_CategoryId, [ProductId] = @p_ProductId, [IsShoppingCart] = @p_IsShoppingCart, [Quantity] = @p_Quantity WHERE [CartId] = @p_CartId"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
				command.Parameters.AddWithValue("@p_CartId", CartId)
				command.Parameters.AddWithValue("@p_UniqueID", profile.UniqueID)
				command.Parameters.AddWithValue("@p_ItemId", ItemId)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Type", Type)
				command.Parameters.AddWithValue("@p_Price", Price)
				command.Parameters.AddWithValue("@p_CategoryId", CategoryId)
				command.Parameters.AddWithValue("@p_ProductId", ProductId)
				command.Parameters.AddWithValue("@p_IsShoppingCart", IsShoppingCart)
				command.Parameters.AddWithValue("@p_Quantity", Quantity)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    If reader.RecordsAffected = 0 Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
        End Using
    End Sub
    
    Private Sub Child_DeleteSelf()
        DataPortal_Delete(New CartCriteria(CartId))
    End Sub
    
    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Shadows Sub DataPortal_Delete(ByVal criteria As CartCriteria)
        Dim commandText As String = String.Format("DELETE FROM [dbo].[Cart] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

				'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
				Dim result As Integer = command.ExecuteNonQuery()
				If (result = 0) Then
					throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
				End If
            End Using
        End Using
    End Sub
    
    Private Sub Map(ByVal reader As SafeDataReader)
        Using(BypassPropertyChecks)
            LoadProperty(_cartIdProperty, reader.GetInt32("CartId"))
            LoadProperty(_uniqueIDProperty, reader.GetInt32("UniqueID"))
            LoadProperty(_itemIdProperty, reader.GetString("ItemId"))
            LoadProperty(_nameProperty, reader.GetString("Name"))
            LoadProperty(_typeProperty, reader.GetString("Type"))
            LoadProperty(_priceProperty, reader.GetDecimal("Price"))
            LoadProperty(_categoryIdProperty, reader.GetString("CategoryId"))
            LoadProperty(_productIdProperty, reader.GetString("ProductId"))
            LoadProperty(_isShoppingCartProperty, reader.GetBoolean("IsShoppingCart"))
            LoadProperty(_quantityProperty, reader.GetInt32("Quantity"))
        End Using

        MarkAsChild()
        MarkOld()
    End Sub
End Class