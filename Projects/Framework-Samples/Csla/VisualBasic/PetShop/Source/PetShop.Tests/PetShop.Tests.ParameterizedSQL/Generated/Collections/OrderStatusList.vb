'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1357, CSLA Framework: v3.8.0.
'       Changes to this template will not be lost.
'
'     Template: EditableRootList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Public Partial Class OrderStatusList
#Region "Authorization Rules"

    Private Shared Sub AddObjectAuthorizationRules()
        ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

        'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(OrderStatusList), admin)
        'AuthorizationRules.AllowDelete(GetType(OrderStatusList), admin)
        'AuthorizationRules.AllowEdit(GetType(OrderStatusList), canWrite)
        'AuthorizationRules.AllowGet(GetType(OrderStatusList), canRead)

        ''OrderId
        'AuthorizationRules.AllowWrite(_orderIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_orderIdProperty, canRead)

        ''LineNum
        'AuthorizationRules.AllowWrite(_lineNumProperty, canWrite)
        'AuthorizationRules.AllowRead(_lineNumProperty, canRead)

        ''Timestamp
        'AuthorizationRules.AllowWrite(_timestampProperty, canWrite)
        'AuthorizationRules.AllowRead(_timestampProperty, canRead)

        ''Status
        'AuthorizationRules.AllowWrite(_statusProperty, canWrite)
        'AuthorizationRules.AllowRead(_statusProperty, canRead)

        ''OrderMember
        'AuthorizationRules.AllowRead(_orderMemberProperty, canRead)

    End Sub

    #End Region
End Class