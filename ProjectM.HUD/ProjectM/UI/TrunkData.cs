// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TrunkData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class TrunkData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RootParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodUnitParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreInstantiatedVBloodEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevelHeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevelDivider;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearTooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearTooltipImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevelValueText;

    static TrunkData()
    {
      Il2CppClassPointerStore<TrunkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TrunkData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrunkData>.NativeClassPtr);
      TrunkData.NativeFieldInfoPtr_RootParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (RootParent));
      TrunkData.NativeFieldInfoPtr_VBloodUnitParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (VBloodUnitParent));
      TrunkData.NativeFieldInfoPtr_PreInstantiatedVBloodEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (PreInstantiatedVBloodEntries));
      TrunkData.NativeFieldInfoPtr_GearLevelHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (GearLevelHeaderText));
      TrunkData.NativeFieldInfoPtr_GearLevelDivider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (GearLevelDivider));
      TrunkData.NativeFieldInfoPtr_GearTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (GearTooltip));
      TrunkData.NativeFieldInfoPtr_GearTooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (GearTooltipText));
      TrunkData.NativeFieldInfoPtr_GearTooltipImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (GearTooltipImage));
      TrunkData.NativeFieldInfoPtr_GearLevelValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, nameof (GearLevelValueText));
    }

    public TrunkData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TrunkData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, data));
    }

    public unsafe RectTransform RootParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_RootParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_RootParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup VBloodUnitParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_VBloodUnitParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_VBloodUnitParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VBloodTrackingUnitEntry> PreInstantiatedVBloodEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_PreInstantiatedVBloodEntries));
        return pointer == System.IntPtr.Zero ? (List<VBloodTrackingUnitEntry>) null : new List<VBloodTrackingUnitEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_PreInstantiatedVBloodEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GearLevelHeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearLevelHeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearLevelHeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image GearLevelDivider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearLevelDivider));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearLevelDivider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform GearTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearTooltip));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GearTooltipText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearTooltipText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearTooltipText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image GearTooltipImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearTooltipImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearTooltipImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GearLevelValueText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearLevelValueText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrunkData.NativeFieldInfoPtr_GearLevelValueText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
