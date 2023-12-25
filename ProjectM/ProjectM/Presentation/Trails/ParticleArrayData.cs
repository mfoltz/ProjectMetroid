// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.ParticleArrayData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public sealed class ParticleArrayData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Particles;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxParticles;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticlesAlive;

    static ParticleArrayData()
    {
      Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (ParticleArrayData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr);
      ParticleArrayData.NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (Particles));
      ParticleArrayData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (Color));
      ParticleArrayData.NativeFieldInfoPtr_PositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (PositionData));
      ParticleArrayData.NativeFieldInfoPtr_MinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (MinIndex));
      ParticleArrayData.NativeFieldInfoPtr_MaxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (MaxIndex));
      ParticleArrayData.NativeFieldInfoPtr_MaxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (MaxParticles));
      ParticleArrayData.NativeFieldInfoPtr_ParticlesAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, nameof (ParticlesAlive));
    }

    public ParticleArrayData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ParticleArrayData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleArrayData>.NativeClassPtr, data));
    }

    public unsafe Il2CppStructArray<Particle> Particles
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_Particles));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Particle>) null : new Il2CppStructArray<Particle>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_Particles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Color32> Color
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_Color));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : new Il2CppStructArray<Color32>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_Color), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<ParticlePositionData> PositionData
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_PositionData));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ParticlePositionData>) null : new Il2CppStructArray<ParticlePositionData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_PositionData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int MinIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_MinIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_MinIndex)) = value;
      }
    }

    public unsafe int MaxIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_MaxIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_MaxIndex)) = value;
      }
    }

    public unsafe int MaxParticles
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_MaxParticles));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_MaxParticles)) = value;
      }
    }

    public unsafe int ParticlesAlive
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_ParticlesAlive));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleArrayData.NativeFieldInfoPtr_ParticlesAlive)) = value;
      }
    }
  }
}
