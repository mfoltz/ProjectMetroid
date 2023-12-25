// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapCompass
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MinimapCompass : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RectTransform;
    private static readonly IntPtr NativeFieldInfoPtr_Markers;
    private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Quaternion_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272994, RefRangeEnd = 1272995, XrefRangeStart = 1272985, XrefRangeEnd = 1272994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(Quaternion rotation)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &rotation;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinimapCompass.NativeMethodInfoPtr_Refresh_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MinimapCompass()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinimapCompass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MinimapCompass()
    {
      Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapCompass));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr);
      MinimapCompass.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr, nameof (RectTransform));
      MinimapCompass.NativeFieldInfoPtr_Markers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr, nameof (Markers));
      MinimapCompass.NativeMethodInfoPtr_Refresh_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr, 100668191);
      MinimapCompass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapCompass>.NativeClassPtr, 100668192);
    }

    public MinimapCompass(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform RectTransform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapCompass.NativeFieldInfoPtr_RectTransform));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinimapCompass.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<RectTransform> Markers
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinimapCompass.NativeFieldInfoPtr_Markers));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinimapCompass.NativeFieldInfoPtr_Markers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
