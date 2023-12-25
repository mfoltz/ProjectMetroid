// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapRegionNameEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MapRegionNameEntry : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_PositionRect;
    private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly IntPtr NativeFieldInfoPtr_Text;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Vector3_LocalizationKey_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270813, RefRangeEnd = 1270814, XrefRangeStart = 1270809, XrefRangeEnd = 1270813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(Vector3 anchoredPosition, LocalizationKey textKey, float alpha)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &anchoredPosition;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &textKey;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &alpha;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapRegionNameEntry.NativeMethodInfoPtr_SetData_Public_Void_Vector3_LocalizationKey_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapRegionNameEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapRegionNameEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapRegionNameEntry()
    {
      Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapRegionNameEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr);
      MapRegionNameEntry.NativeFieldInfoPtr_PositionRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr, nameof (PositionRect));
      MapRegionNameEntry.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr, nameof (CanvasGroup));
      MapRegionNameEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr, nameof (Text));
      MapRegionNameEntry.NativeMethodInfoPtr_SetData_Public_Void_Vector3_LocalizationKey_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr, 100667958);
      MapRegionNameEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionNameEntry>.NativeClassPtr, 100667959);
    }

    public MapRegionNameEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform PositionRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapRegionNameEntry.NativeFieldInfoPtr_PositionRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapRegionNameEntry.NativeFieldInfoPtr_PositionRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapRegionNameEntry.NativeFieldInfoPtr_CanvasGroup));
        return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapRegionNameEntry.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapRegionNameEntry.NativeFieldInfoPtr_Text));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapRegionNameEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
