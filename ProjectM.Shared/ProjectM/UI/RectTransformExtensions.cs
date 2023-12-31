// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.RectTransformExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public static class RectTransformExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAnchor_Public_Static_Void_RectTransform_AnchorPreset_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPivot_Public_Static_Void_RectTransform_PivotPresets_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnchoredPosition_Public_Static_Vector3_RectTransform_AnchorPreset_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 795750, RefRangeEnd = 795756, XrefRangeStart = 795729, XrefRangeEnd = 795750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAnchor(
      this RectTransform source,
      AnchorPreset align,
      float offsetX = 0.0f,
      float offsetY = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &align;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetY;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_SetAnchor_Public_Static_Void_RectTransform_AnchorPreset_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 795765, RefRangeEnd = 795776, XrefRangeStart = 795756, XrefRangeEnd = 795765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetPivot(this RectTransform source, PivotPresets preset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &preset;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_SetPivot_Public_Static_Void_RectTransform_PivotPresets_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 795781, RefRangeEnd = 795791, XrefRangeStart = 795776, XrefRangeEnd = 795781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 GetAnchoredPosition(RectTransform rect, AnchorPreset align)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &align;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_GetAnchoredPosition_Public_Static_Vector3_RectTransform_AnchorPreset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RectTransformExtensions()
    {
      Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (RectTransformExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr);
      RectTransformExtensions.NativeMethodInfoPtr_SetAnchor_Public_Static_Void_RectTransform_AnchorPreset_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670221);
      RectTransformExtensions.NativeMethodInfoPtr_SetPivot_Public_Static_Void_RectTransform_PivotPresets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670222);
      RectTransformExtensions.NativeMethodInfoPtr_GetAnchoredPosition_Public_Static_Vector3_RectTransform_AnchorPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670223);
    }

    public RectTransformExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
