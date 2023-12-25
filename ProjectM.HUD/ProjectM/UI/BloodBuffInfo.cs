// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BloodBuffInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public sealed class BloodBuffInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodTypeName;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodTypeSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffList;

    static BloodBuffInfo()
    {
      Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BloodBuffInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr);
      BloodBuffInfo.NativeFieldInfoPtr_BloodAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, nameof (BloodAmount));
      BloodBuffInfo.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, nameof (BloodQuality));
      BloodBuffInfo.NativeFieldInfoPtr_BloodTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, nameof (BloodTypeName));
      BloodBuffInfo.NativeFieldInfoPtr_BloodTypeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, nameof (BloodTypeSprite));
      BloodBuffInfo.NativeFieldInfoPtr_BuffList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, nameof (BuffList));
    }

    public BloodBuffInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BloodBuffInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffInfo>.NativeClassPtr, data));
    }

    public unsafe float BloodAmount
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodAmount));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodAmount)) = value;
      }
    }

    public unsafe float BloodQuality
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodQuality));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodQuality)) = value;
      }
    }

    public unsafe LocalizationKey BloodTypeName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodTypeName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodTypeName)) = value;
      }
    }

    public unsafe Sprite BloodTypeSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodTypeSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BloodTypeSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<KeyValuePair_Unboxed<DescriptionWrapper, float>> BuffList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BuffList));
        return pointer == System.IntPtr.Zero ? (List<KeyValuePair_Unboxed<DescriptionWrapper, float>>) null : new List<KeyValuePair_Unboxed<DescriptionWrapper, float>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodBuffInfo.NativeFieldInfoPtr_BuffList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
