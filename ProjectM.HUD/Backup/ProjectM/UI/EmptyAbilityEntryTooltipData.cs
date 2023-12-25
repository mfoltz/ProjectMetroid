// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.EmptyAbilityEntryTooltipData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class EmptyAbilityEntryTooltipData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyAbilityEntryTooltipType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_Desc;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

    static EmptyAbilityEntryTooltipData()
    {
      Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (EmptyAbilityEntryTooltipData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr);
      EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_EmptyAbilityEntryTooltipType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr, nameof (EmptyAbilityEntryTooltipType));
      EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr, nameof (Header));
      EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr, nameof (Desc));
      EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr, nameof (Icon));
    }

    public EmptyAbilityEntryTooltipData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public EmptyAbilityEntryTooltipData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmptyAbilityEntryTooltipData>.NativeClassPtr, data));
    }

    public unsafe EmptyAbilityEntryTooltipType EmptyAbilityEntryTooltipType
    {
      get
      {
        return *(EmptyAbilityEntryTooltipType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_EmptyAbilityEntryTooltipType));
      }
      [param: In] set
      {
        *(EmptyAbilityEntryTooltipType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_EmptyAbilityEntryTooltipType)) = value;
      }
    }

    public unsafe LocalizationKey Header
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Header));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Header)) = value;
      }
    }

    public unsafe LocalizationKey Desc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Desc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Desc)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmptyAbilityEntryTooltipData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
