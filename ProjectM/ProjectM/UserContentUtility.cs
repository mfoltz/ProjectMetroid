// Decompiled with JetBrains decompiler
// Type: ProjectM.UserContentUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class UserContentUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlocked_Public_Static_Boolean_UserContentFlags_UserContentFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUserContent_Public_Static_Void_SystemBase_Entity_UserContentFlags_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1030230, RefRangeEnd = 1030234, XrefRangeStart = 1030230, XrefRangeEnd = 1030230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlocked(
      UserContentFlags userContentFlags,
      UserContentFlags requirement)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userContentFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requirement;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserContentUtility.NativeMethodInfoPtr_HasUnlocked_Public_Static_Boolean_UserContentFlags_UserContentFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1030255, RefRangeEnd = 1030258, XrefRangeStart = 1030234, XrefRangeEnd = 1030255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateUserContent(
      SystemBase systemBase,
      Entity userEntity,
      UserContentFlags userContentFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlags;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserContentUtility.NativeMethodInfoPtr_UpdateUserContent_Public_Static_Void_SystemBase_Entity_UserContentFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserContentUtility()
    {
      Il2CppClassPointerStore<UserContentUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UserContentUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserContentUtility>.NativeClassPtr);
      UserContentUtility.NativeMethodInfoPtr_HasUnlocked_Public_Static_Boolean_UserContentFlags_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserContentUtility>.NativeClassPtr, 100680386);
      UserContentUtility.NativeMethodInfoPtr_UpdateUserContent_Public_Static_Void_SystemBase_Entity_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserContentUtility>.NativeClassPtr, 100680387);
    }

    public UserContentUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
