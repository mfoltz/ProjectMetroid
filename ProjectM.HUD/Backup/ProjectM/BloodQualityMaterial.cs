// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodQualityMaterial
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class BloodQualityMaterial : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Material;
    private static readonly System.IntPtr NativeFieldInfoPtr_Threshhold;

    static BloodQualityMaterial()
    {
      Il2CppClassPointerStore<BloodQualityMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (BloodQualityMaterial));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityMaterial>.NativeClassPtr);
      BloodQualityMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityMaterial>.NativeClassPtr, nameof (Material));
      BloodQualityMaterial.NativeFieldInfoPtr_Threshhold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityMaterial>.NativeClassPtr, nameof (Threshhold));
    }

    public BloodQualityMaterial(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BloodQualityMaterial()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloodQualityMaterial>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodQualityMaterial>.NativeClassPtr, data));
    }

    public unsafe Material Material
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityMaterial.NativeFieldInfoPtr_Material));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Threshhold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityMaterial.NativeFieldInfoPtr_Threshhold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityMaterial.NativeFieldInfoPtr_Threshhold)) = value;
      }
    }
  }
}
