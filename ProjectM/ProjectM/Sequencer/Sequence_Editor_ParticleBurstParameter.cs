// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Sequence_Editor_ParticleBurstParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class Sequence_Editor_ParticleBurstParameter : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;

    static Sequence_Editor_ParticleBurstParameter()
    {
      Il2CppClassPointerStore<Sequence_Editor_ParticleBurstParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Sequence_Editor_ParticleBurstParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence_Editor_ParticleBurstParameter>.NativeClassPtr);
      Sequence_Editor_ParticleBurstParameter.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleBurstParameter>.NativeClassPtr, nameof (Time));
      Sequence_Editor_ParticleBurstParameter.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_ParticleBurstParameter>.NativeClassPtr, nameof (Count));
    }

    public Sequence_Editor_ParticleBurstParameter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Sequence_Editor_ParticleBurstParameter()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Sequence_Editor_ParticleBurstParameter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_ParticleBurstParameter>.NativeClassPtr, data));
    }

    public BlackboardParameterValue Time
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleBurstParameter.NativeFieldInfoPtr_Time);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleBurstParameter.NativeFieldInfoPtr_Time), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BlackboardParameterValue Count
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleBurstParameter.NativeFieldInfoPtr_Count);
        return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_ParticleBurstParameter.NativeFieldInfoPtr_Count), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
