﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Sequence_Editor_VisualEffectParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class Sequence_Editor_VisualEffectParameter : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_EffectName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;

    static Sequence_Editor_VisualEffectParameter()
    {
      Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Sequence_Editor_VisualEffectParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr);
      Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_BlackboardValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, nameof (BlackboardValueType));
      Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, nameof (Value));
      Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_EffectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, nameof (EffectName));
      Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, nameof (Name));
    }

    public Sequence_Editor_VisualEffectParameter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Sequence_Editor_VisualEffectParameter()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, data));
    }

    public unsafe BlackboardRegisterType BlackboardValueType
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_BlackboardValueType));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_BlackboardValueType)) = value;
      }
    }

    public BlackboardParameterValue Value
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_Value);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string EffectName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_EffectName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_EffectName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_VisualEffectParameter.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
