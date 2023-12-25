// Decompiled with JetBrains decompiler
// Type: ProjectM.CrowdednessUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class CrowdednessUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidUser_Public_Static_Boolean_EntityManager_Entity_Entity_Entity_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 988628, RefRangeEnd = 988630, XrefRangeStart = 988614, XrefRangeEnd = 988628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidUser(
      EntityManager entityManager,
      Entity self,
      Entity otherControlled,
      Entity otherUser)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &otherControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &otherUser;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CrowdednessUtility.NativeMethodInfoPtr_IsValidUser_Public_Static_Boolean_EntityManager_Entity_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CrowdednessUtility()
    {
      Il2CppClassPointerStore<CrowdednessUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CrowdednessUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdednessUtility>.NativeClassPtr);
      CrowdednessUtility.NativeMethodInfoPtr_IsValidUser_Public_Static_Boolean_EntityManager_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdednessUtility>.NativeClassPtr, 100676267);
    }

    public CrowdednessUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
