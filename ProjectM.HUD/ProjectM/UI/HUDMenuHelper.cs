// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDMenuHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class HUDMenuHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSubMenuEntity_Public_Static_Entity_EntityManager_Entity_HUDMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSubMenuEntity_Public_Static_Entity_EntityManager_Entity_HUDMenu_IComponentData_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1276975, RefRangeEnd = 1276977, XrefRangeStart = 1276966, XrefRangeEnd = 1276975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateSubMenuEntity(
      EntityManager entityManager,
      Entity parentMenuEntity,
      HUDMenu subMenu)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentMenuEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subMenu);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDMenuHelper.NativeMethodInfoPtr_CreateSubMenuEntity_Public_Static_Entity_EntityManager_Entity_HUDMenu_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276977, XrefRangeEnd = 1276989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateSubMenuEntity(
      EntityManager entityManager,
      Entity parentMenuEntity,
      HUDMenu subMenu,
      IComponentData componentData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentMenuEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subMenu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDMenuHelper.NativeMethodInfoPtr_CreateSubMenuEntity_Public_Static_Entity_EntityManager_Entity_HUDMenu_IComponentData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HUDMenuHelper()
    {
      Il2CppClassPointerStore<HUDMenuHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDMenuHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDMenuHelper>.NativeClassPtr);
      HUDMenuHelper.NativeMethodInfoPtr_CreateSubMenuEntity_Public_Static_Entity_EntityManager_Entity_HUDMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuHelper>.NativeClassPtr, 100668649);
      HUDMenuHelper.NativeMethodInfoPtr_CreateSubMenuEntity_Public_Static_Entity_EntityManager_Entity_HUDMenu_IComponentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuHelper>.NativeClassPtr, 100668650);
    }

    public HUDMenuHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
