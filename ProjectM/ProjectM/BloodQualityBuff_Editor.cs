// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodQualityBuff_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class BloodQualityBuff_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_QualityValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;

    static BloodQualityBuff_Editor()
    {
      Il2CppClassPointerStore<BloodQualityBuff_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodQualityBuff_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodQualityBuff_Editor>.NativeClassPtr);
      BloodQualityBuff_Editor.NativeFieldInfoPtr_QualityValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityBuff_Editor>.NativeClassPtr, nameof (QualityValue));
      BloodQualityBuff_Editor.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodQualityBuff_Editor>.NativeClassPtr, nameof (Buff));
    }

    public BloodQualityBuff_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BloodQualityBuff_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloodQualityBuff_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodQualityBuff_Editor>.NativeClassPtr, data));
    }

    public unsafe float QualityValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityBuff_Editor.NativeFieldInfoPtr_QualityValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityBuff_Editor.NativeFieldInfoPtr_QualityValue)) = value;
      }
    }

    public unsafe PrefabGuidComponent Buff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityBuff_Editor.NativeFieldInfoPtr_Buff));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodQualityBuff_Editor.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
