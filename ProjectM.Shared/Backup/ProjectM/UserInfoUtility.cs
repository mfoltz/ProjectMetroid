// Decompiled with JetBrains decompiler
// Type: ProjectM.UserInfoUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class UserInfoUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetUserInfoBuffer_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_byref_DynamicBuffer_1_UserInfoElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInfoAtIndex_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_Int32_byref_UserInfoElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInfoForUserWithNetworkId_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_NetworkId_byref_UserInfoElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInfoForUserWithName_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_byref_FixedString64_byref_UserInfoElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInfoForUserWithName_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_String_byref_UserInfoElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUserAdmin_Public_Static_Boolean_byref_User_SingletonAccessor_1_SyncedServerDebugSettings_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763123, XrefRangeEnd = 763132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetUserInfoBuffer(
      EntityManager entityManager,
      SingletonAccessor<UserInfoBufferSingleton> userInfoBufferAccessor,
      out DynamicBuffer<UserInfoElement> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userInfoBufferAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoUtility.NativeMethodInfoPtr_TryGetUserInfoBuffer_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_byref_DynamicBuffer_1_UserInfoElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763132, XrefRangeEnd = 763151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInfoAtIndex(
      EntityManager entityManager,
      SingletonAccessor<UserInfoBufferSingleton> userInfoBufferAccessor,
      int index,
      out UserInfoElement result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userInfoBufferAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoUtility.NativeMethodInfoPtr_TryGetInfoAtIndex_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_Int32_byref_UserInfoElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763183, RefRangeEnd = 763184, XrefRangeStart = 763151, XrefRangeEnd = 763183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInfoForUserWithNetworkId(
      EntityManager entityManager,
      SingletonAccessor<UserInfoBufferSingleton> userInfoBufferAccessor,
      NetworkId networkId,
      out UserInfoElement result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userInfoBufferAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoUtility.NativeMethodInfoPtr_TryGetInfoForUserWithNetworkId_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_NetworkId_byref_UserInfoElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763213, RefRangeEnd = 763214, XrefRangeStart = 763184, XrefRangeEnd = 763213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInfoForUserWithName(
      EntityManager entityManager,
      SingletonAccessor<UserInfoBufferSingleton> userInfoBufferAccessor,
      [In] ref FixedString64 name,
      out UserInfoElement result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userInfoBufferAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoUtility.NativeMethodInfoPtr_TryGetInfoForUserWithName_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_byref_FixedString64_byref_UserInfoElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763214, XrefRangeEnd = 763216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetInfoForUserWithName(
      EntityManager entityManager,
      SingletonAccessor<UserInfoBufferSingleton> userInfoBufferAccessor,
      string name,
      out UserInfoElement result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userInfoBufferAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoUtility.NativeMethodInfoPtr_TryGetInfoForUserWithName_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_String_byref_UserInfoElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763216, XrefRangeEnd = 763217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsUserAdmin(
      [In] ref User user,
      SingletonAccessor<SyncedServerDebugSettings> syncedServerDebugSettingsAccessor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &syncedServerDebugSettingsAccessor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoUtility.NativeMethodInfoPtr_IsUserAdmin_Public_Static_Boolean_byref_User_SingletonAccessor_1_SyncedServerDebugSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UserInfoUtility()
    {
      Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UserInfoUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr);
      UserInfoUtility.NativeMethodInfoPtr_TryGetUserInfoBuffer_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_byref_DynamicBuffer_1_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr, 100667420);
      UserInfoUtility.NativeMethodInfoPtr_TryGetInfoAtIndex_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_Int32_byref_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr, 100667421);
      UserInfoUtility.NativeMethodInfoPtr_TryGetInfoForUserWithNetworkId_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_NetworkId_byref_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr, 100667422);
      UserInfoUtility.NativeMethodInfoPtr_TryGetInfoForUserWithName_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_byref_FixedString64_byref_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr, 100667423);
      UserInfoUtility.NativeMethodInfoPtr_TryGetInfoForUserWithName_Public_Static_Boolean_EntityManager_SingletonAccessor_1_UserInfoBufferSingleton_String_byref_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr, 100667424);
      UserInfoUtility.NativeMethodInfoPtr_IsUserAdmin_Public_Static_Boolean_byref_User_SingletonAccessor_1_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoUtility>.NativeClassPtr, 100667425);
    }

    public UserInfoUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
