// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.KWS.KWSInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.KWS
{
  public sealed class KWSInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopypermissionbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateuserApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetpermissionbykeyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetpermissionscountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPermissionLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPermissions;
    private static readonly System.IntPtr NativeFieldInfoPtr_PermissionstatusApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryagegateApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuerypermissionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestpermissionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateparentemailApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPermissionsUpdateReceived_Public_UInt64_byref_AddNotifyPermissionsUpdateReceivedOptions_Object_OnPermissionsUpdateReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPermissionByIndex_Public_Result_byref_CopyPermissionByIndexOptions_byref_Nullable_1_PermissionStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateUser_Public_Void_byref_CreateUserOptions_Object_OnCreateUserCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPermissionByKey_Public_Result_byref_GetPermissionByKeyOptions_byref_KWSPermissionStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPermissionsCount_Public_Int32_byref_GetPermissionsCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryAgeGate_Public_Void_byref_QueryAgeGateOptions_Object_OnQueryAgeGateCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryPermissions_Public_Void_byref_QueryPermissionsOptions_Object_OnQueryPermissionsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPermissionsUpdateReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RequestPermissions_Public_Void_byref_RequestPermissionsOptions_Object_OnRequestPermissionsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParentEmail_Public_Void_byref_UpdateParentEmailOptions_Object_OnUpdateParentEmailCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_byref_CreateUserCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPermissionsUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_PermissionsUpdateReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryAgeGateCallbackInternalImplementation_Internal_Static_Void_byref_QueryAgeGateCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryPermissionsCallbackInternalImplementation_Internal_Static_Void_byref_QueryPermissionsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRequestPermissionsCallbackInternalImplementation_Internal_Static_Void_byref_RequestPermissionsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateParentEmailCallbackInternalImplementation_Internal_Static_Void_byref_UpdateParentEmailCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KWSInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959513, XrefRangeEnd = 959533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPermissionsUpdateReceived(
      ref AddNotifyPermissionsUpdateReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnPermissionsUpdateReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_AddNotifyPermissionsUpdateReceived_Public_UInt64_byref_AddNotifyPermissionsUpdateReceivedOptions_Object_OnPermissionsUpdateReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959533, XrefRangeEnd = 959547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyPermissionByIndex(
      ref CopyPermissionByIndexOptions options,
      out Il2CppSystem.Nullable<PermissionStatus> outPermission)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_CopyPermissionByIndex_Public_Result_byref_CopyPermissionByIndexOptions_byref_Nullable_1_PermissionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<PermissionStatus> local = ref outPermission;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<PermissionStatus>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959547, XrefRangeEnd = 959566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateUser(
      ref CreateUserOptions options,
      Il2CppSystem.Object clientData,
      OnCreateUserCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_CreateUser_Public_Void_byref_CreateUserOptions_Object_OnCreateUserCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959566, XrefRangeEnd = 959577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetPermissionByKey(
      ref GetPermissionByKeyOptions options,
      out KWSPermissionStatus outPermission)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPermission;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_GetPermissionByKey_Public_Result_byref_GetPermissionByKeyOptions_byref_KWSPermissionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959577, XrefRangeEnd = 959585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetPermissionsCount(ref GetPermissionsCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_GetPermissionsCount_Public_Int32_byref_GetPermissionsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959585, XrefRangeEnd = 959604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryAgeGate(
      ref QueryAgeGateOptions options,
      Il2CppSystem.Object clientData,
      OnQueryAgeGateCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_QueryAgeGate_Public_Void_byref_QueryAgeGateOptions_Object_OnQueryAgeGateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959604, XrefRangeEnd = 959623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryPermissions(
      ref QueryPermissionsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryPermissionsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_QueryPermissions_Public_Void_byref_QueryPermissionsOptions_Object_OnQueryPermissionsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959623, XrefRangeEnd = 959628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPermissionsUpdateReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_RemoveNotifyPermissionsUpdateReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959628, XrefRangeEnd = 959647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RequestPermissions(
      ref RequestPermissionsOptions options,
      Il2CppSystem.Object clientData,
      OnRequestPermissionsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_RequestPermissions_Public_Void_byref_RequestPermissionsOptions_Object_OnRequestPermissionsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959647, XrefRangeEnd = 959666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateParentEmail(
      ref UpdateParentEmailOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateParentEmailCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_UpdateParentEmail_Public_Void_byref_UpdateParentEmailOptions_Object_OnUpdateParentEmailCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959666, XrefRangeEnd = 959673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCreateUserCallbackInternalImplementation(
      ref CreateUserCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_byref_CreateUserCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959673, XrefRangeEnd = 959680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPermissionsUpdateReceivedCallbackInternalImplementation(
      ref PermissionsUpdateReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnPermissionsUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_PermissionsUpdateReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959680, XrefRangeEnd = 959687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryAgeGateCallbackInternalImplementation(
      ref QueryAgeGateCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnQueryAgeGateCallbackInternalImplementation_Internal_Static_Void_byref_QueryAgeGateCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959687, XrefRangeEnd = 959694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryPermissionsCallbackInternalImplementation(
      ref QueryPermissionsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnQueryPermissionsCallbackInternalImplementation_Internal_Static_Void_byref_QueryPermissionsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959694, XrefRangeEnd = 959701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRequestPermissionsCallbackInternalImplementation(
      ref RequestPermissionsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnRequestPermissionsCallbackInternalImplementation_Internal_Static_Void_byref_RequestPermissionsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959701, XrefRangeEnd = 959708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateParentEmailCallbackInternalImplementation(
      ref UpdateParentEmailCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KWSInterface.NativeMethodInfoPtr_OnUpdateParentEmailCallbackInternalImplementation_Internal_Static_Void_byref_UpdateParentEmailCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KWSInterface()
    {
      Il2CppClassPointerStore<KWSInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.KWS", nameof (KWSInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr);
      KWSInterface.NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (AddnotifypermissionsupdatereceivedApiLatest));
      KWSInterface.NativeFieldInfoPtr_CopypermissionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (CopypermissionbyindexApiLatest));
      KWSInterface.NativeFieldInfoPtr_CreateuserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (CreateuserApiLatest));
      KWSInterface.NativeFieldInfoPtr_GetpermissionbykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (GetpermissionbykeyApiLatest));
      KWSInterface.NativeFieldInfoPtr_GetpermissionscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (GetpermissionscountApiLatest));
      KWSInterface.NativeFieldInfoPtr_MaxPermissionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (MaxPermissionLength));
      KWSInterface.NativeFieldInfoPtr_MaxPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (MaxPermissions));
      KWSInterface.NativeFieldInfoPtr_PermissionstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (PermissionstatusApiLatest));
      KWSInterface.NativeFieldInfoPtr_QueryagegateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (QueryagegateApiLatest));
      KWSInterface.NativeFieldInfoPtr_QuerypermissionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (QuerypermissionsApiLatest));
      KWSInterface.NativeFieldInfoPtr_RequestpermissionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (RequestpermissionsApiLatest));
      KWSInterface.NativeFieldInfoPtr_UpdateparentemailApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, nameof (UpdateparentemailApiLatest));
      KWSInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671177);
      KWSInterface.NativeMethodInfoPtr_AddNotifyPermissionsUpdateReceived_Public_UInt64_byref_AddNotifyPermissionsUpdateReceivedOptions_Object_OnPermissionsUpdateReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671179);
      KWSInterface.NativeMethodInfoPtr_CopyPermissionByIndex_Public_Result_byref_CopyPermissionByIndexOptions_byref_Nullable_1_PermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671180);
      KWSInterface.NativeMethodInfoPtr_CreateUser_Public_Void_byref_CreateUserOptions_Object_OnCreateUserCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671181);
      KWSInterface.NativeMethodInfoPtr_GetPermissionByKey_Public_Result_byref_GetPermissionByKeyOptions_byref_KWSPermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671182);
      KWSInterface.NativeMethodInfoPtr_GetPermissionsCount_Public_Int32_byref_GetPermissionsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671183);
      KWSInterface.NativeMethodInfoPtr_QueryAgeGate_Public_Void_byref_QueryAgeGateOptions_Object_OnQueryAgeGateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671184);
      KWSInterface.NativeMethodInfoPtr_QueryPermissions_Public_Void_byref_QueryPermissionsOptions_Object_OnQueryPermissionsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671185);
      KWSInterface.NativeMethodInfoPtr_RemoveNotifyPermissionsUpdateReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671186);
      KWSInterface.NativeMethodInfoPtr_RequestPermissions_Public_Void_byref_RequestPermissionsOptions_Object_OnRequestPermissionsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671187);
      KWSInterface.NativeMethodInfoPtr_UpdateParentEmail_Public_Void_byref_UpdateParentEmailOptions_Object_OnUpdateParentEmailCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671188);
      KWSInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_byref_CreateUserCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671189);
      KWSInterface.NativeMethodInfoPtr_OnPermissionsUpdateReceivedCallbackInternalImplementation_Internal_Static_Void_byref_PermissionsUpdateReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671190);
      KWSInterface.NativeMethodInfoPtr_OnQueryAgeGateCallbackInternalImplementation_Internal_Static_Void_byref_QueryAgeGateCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671191);
      KWSInterface.NativeMethodInfoPtr_OnQueryPermissionsCallbackInternalImplementation_Internal_Static_Void_byref_QueryPermissionsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671192);
      KWSInterface.NativeMethodInfoPtr_OnRequestPermissionsCallbackInternalImplementation_Internal_Static_Void_byref_RequestPermissionsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671193);
      KWSInterface.NativeMethodInfoPtr_OnUpdateParentEmailCallbackInternalImplementation_Internal_Static_Void_byref_UpdateParentEmailCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KWSInterface>.NativeClassPtr, 100671194);
    }

    public KWSInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifypermissionsupdatereceivedApiLatest
    {
      get
      {
        int addnotifypermissionsupdatereceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest, (void*) &addnotifypermissionsupdatereceivedApiLatest);
        return addnotifypermissionsupdatereceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_AddnotifypermissionsupdatereceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopypermissionbyindexApiLatest
    {
      get
      {
        int copypermissionbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_CopypermissionbyindexApiLatest, (void*) &copypermissionbyindexApiLatest);
        return copypermissionbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_CopypermissionbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreateuserApiLatest
    {
      get
      {
        int createuserApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &createuserApiLatest);
        return createuserApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetpermissionbykeyApiLatest
    {
      get
      {
        int getpermissionbykeyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_GetpermissionbykeyApiLatest, (void*) &getpermissionbykeyApiLatest);
        return getpermissionbykeyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_GetpermissionbykeyApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetpermissionscountApiLatest
    {
      get
      {
        int getpermissionscountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_GetpermissionscountApiLatest, (void*) &getpermissionscountApiLatest);
        return getpermissionscountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_GetpermissionscountApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxPermissionLength
    {
      get
      {
        int permissionLength;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_MaxPermissionLength, (void*) &permissionLength);
        return permissionLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_MaxPermissionLength, (void*) &value);
      }
    }

    public static unsafe int MaxPermissions
    {
      get
      {
        int maxPermissions;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_MaxPermissions, (void*) &maxPermissions);
        return maxPermissions;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_MaxPermissions, (void*) &value);
      }
    }

    public static unsafe int PermissionstatusApiLatest
    {
      get
      {
        int permissionstatusApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_PermissionstatusApiLatest, (void*) &permissionstatusApiLatest);
        return permissionstatusApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_PermissionstatusApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryagegateApiLatest
    {
      get
      {
        int queryagegateApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_QueryagegateApiLatest, (void*) &queryagegateApiLatest);
        return queryagegateApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_QueryagegateApiLatest, (void*) &value);
      }
    }

    public static unsafe int QuerypermissionsApiLatest
    {
      get
      {
        int querypermissionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_QuerypermissionsApiLatest, (void*) &querypermissionsApiLatest);
        return querypermissionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_QuerypermissionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int RequestpermissionsApiLatest
    {
      get
      {
        int requestpermissionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_RequestpermissionsApiLatest, (void*) &requestpermissionsApiLatest);
        return requestpermissionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_RequestpermissionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdateparentemailApiLatest
    {
      get
      {
        int updateparentemailApiLatest;
        IL2CPP.il2cpp_field_static_get_value(KWSInterface.NativeFieldInfoPtr_UpdateparentemailApiLatest, (void*) &updateparentemailApiLatest);
        return updateparentemailApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KWSInterface.NativeFieldInfoPtr_UpdateparentemailApiLatest, (void*) &value);
      }
    }
  }
}
