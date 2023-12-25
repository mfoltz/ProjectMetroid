// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SomeHelperClass
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public static class SomeHelperClass : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPointerOverUIElement_Public_Static_Boolean_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPointerOverUIElement_Public_Static_Boolean_List_1_RaycastResult_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEventSystemRaycastResults_Private_Static_List_1_RaycastResult_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1239357, RefRangeEnd = 1239359, XrefRangeStart = 1239332, XrefRangeEnd = 1239357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPointerOverUIElement(GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SomeHelperClass.NativeMethodInfoPtr_IsPointerOverUIElement_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239359, XrefRangeEnd = 1239367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPointerOverUIElement(
      List<RaycastResult> eventSystemRaycastResults,
      GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventSystemRaycastResults);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SomeHelperClass.NativeMethodInfoPtr_IsPointerOverUIElement_Public_Static_Boolean_List_1_RaycastResult_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239367, XrefRangeEnd = 1239384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<RaycastResult> GetEventSystemRaycastResults()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SomeHelperClass.NativeMethodInfoPtr_GetEventSystemRaycastResults_Private_Static_List_1_RaycastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<RaycastResult>) null : new List<RaycastResult>(pointer);
    }

    static SomeHelperClass()
    {
      Il2CppClassPointerStore<SomeHelperClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SomeHelperClass));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SomeHelperClass>.NativeClassPtr);
      SomeHelperClass.NativeMethodInfoPtr_IsPointerOverUIElement_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SomeHelperClass>.NativeClassPtr, 100665956);
      SomeHelperClass.NativeMethodInfoPtr_IsPointerOverUIElement_Public_Static_Boolean_List_1_RaycastResult_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SomeHelperClass>.NativeClassPtr, 100665957);
      SomeHelperClass.NativeMethodInfoPtr_GetEventSystemRaycastResults_Private_Static_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SomeHelperClass>.NativeClassPtr, 100665958);
    }

    public SomeHelperClass(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
