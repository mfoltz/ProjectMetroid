// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Sequence_Editor_ParticleParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class Sequence_Editor_ParticleParameter : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetEmissionrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateOverTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RateOverDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorFoldout;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetBurstEmission;
    private static readonly System.IntPtr NativeFieldInfoPtr_BurstParameters;

    static Sequence_Editor_ParticleParameter()
    {
      Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Sequence_Editor_ParticleParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr);
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (ParticleSystem));
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_SetEmissionrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (SetEmissionrate));
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_RateOverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (RateOverTime));
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_RateOverDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (RateOverDistance));
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_EditorFoldout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (EditorFoldout));
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_SetBurstEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (SetBurstEmission));
      Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_BurstParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, nameof (BurstParameters));
    }

    public Sequence_Editor_ParticleParameter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Sequence_Editor_ParticleParameter()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_ParticleParameter>.NativeClassPtr, data));
    }

    public unsafe ParticleSystem ParticleSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_ParticleSystem));
        return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool SetEmissionrate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_SetEmissionrate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_SetEmissionrate)) = value;
      }
    }

    public BlackboardParameterValue RateOverTime
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_RateOverTime);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_RateOverTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BlackboardParameterValue RateOverDistance
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_RateOverDistance);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_RateOverDistance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool EditorFoldout
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_EditorFoldout));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_EditorFoldout)) = value;
      }
    }

    public unsafe bool SetBurstEmission
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_SetBurstEmission));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_SetBurstEmission)) = value;
      }
    }

    public unsafe List<Sequence_Editor_ParticleBurstParameter> BurstParameters
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_BurstParameters));
        return pointer == System.IntPtr.Zero ? (List<Sequence_Editor_ParticleBurstParameter>) null : new List<Sequence_Editor_ParticleBurstParameter>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleParameter.NativeFieldInfoPtr_BurstParameters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
