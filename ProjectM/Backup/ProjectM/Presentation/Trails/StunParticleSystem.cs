// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.StunParticleSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public class StunParticleSystem : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Particles;
    private static readonly System.IntPtr NativeFieldInfoPtr__Color;
    private static readonly System.IntPtr NativeFieldInfoPtr__PositionData;
    private static readonly System.IntPtr NativeFieldInfoPtr__MinIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxParticles;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticlesAlive_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxParticleCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearParticleSystem_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EmitParticle_Public_Void_byref_ParticleCreationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EmitParticle_Public_Void_byref_ParticleCreationData_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetParticleArrayData_Public_ParticleArrayData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticleSystem_Public_Boolean_Single_byref_EmitterData_0;

    public unsafe int ParticlesAlive
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 1113825, RefRangeEnd = 1113828, XrefRangeStart = 1113825, XrefRangeEnd = 1113825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_get_ParticlesAlive_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int MaxParticleCount
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 32697, RefRangeEnd = 32698, XrefRangeStart = 32697, XrefRangeEnd = 32698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_get_MaxParticleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113841, RefRangeEnd = 1113842, XrefRangeStart = 1113828, XrefRangeEnd = 1113841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunParticleSystem(int maxParticleCount)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &maxParticleCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1113842, RefRangeEnd = 1113844, XrefRangeStart = 1113842, XrefRangeEnd = 1113842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearParticleSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_ClearParticleSystem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1113845, RefRangeEnd = 1113847, XrefRangeStart = 1113844, XrefRangeEnd = 1113845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EmitParticle(ref ParticleCreationData particle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref particle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_EmitParticle_Public_Void_byref_ParticleCreationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113848, RefRangeEnd = 1113849, XrefRangeStart = 1113847, XrefRangeEnd = 1113848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EmitParticle(ref ParticleCreationData particle, Vector3 localOffset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref particle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localOffset;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_EmitParticle_Public_Void_byref_ParticleCreationData_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113852, RefRangeEnd = 1113853, XrefRangeStart = 1113849, XrefRangeEnd = 1113852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleArrayData GetParticleArrayData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_GetParticleArrayData_Public_ParticleArrayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new ParticleArrayData(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1113877, RefRangeEnd = 1113879, XrefRangeStart = 1113853, XrefRangeEnd = 1113877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UpdateParticleSystem(float time, ref EmitterData emitterData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) emitterData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunParticleSystem.NativeMethodInfoPtr_UpdateParticleSystem_Public_Boolean_Single_byref_EmitterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StunParticleSystem()
    {
      Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (StunParticleSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr);
      StunParticleSystem.NativeFieldInfoPtr__Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, nameof (_Particles));
      StunParticleSystem.NativeFieldInfoPtr__Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, nameof (_Color));
      StunParticleSystem.NativeFieldInfoPtr__PositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, nameof (_PositionData));
      StunParticleSystem.NativeFieldInfoPtr__MinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, nameof (_MinIndex));
      StunParticleSystem.NativeFieldInfoPtr__MaxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, nameof (_MaxIndex));
      StunParticleSystem.NativeFieldInfoPtr__MaxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, nameof (_MaxParticles));
      StunParticleSystem.NativeMethodInfoPtr_get_ParticlesAlive_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688163);
      StunParticleSystem.NativeMethodInfoPtr_get_MaxParticleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688164);
      StunParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688165);
      StunParticleSystem.NativeMethodInfoPtr_ClearParticleSystem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688166);
      StunParticleSystem.NativeMethodInfoPtr_EmitParticle_Public_Void_byref_ParticleCreationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688167);
      StunParticleSystem.NativeMethodInfoPtr_EmitParticle_Public_Void_byref_ParticleCreationData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688168);
      StunParticleSystem.NativeMethodInfoPtr_GetParticleArrayData_Public_ParticleArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688169);
      StunParticleSystem.NativeMethodInfoPtr_UpdateParticleSystem_Public_Boolean_Single_byref_EmitterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunParticleSystem>.NativeClassPtr, 100688170);
    }

    public StunParticleSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<Particle> _Particles
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__Particles));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Particle>) null : new Il2CppStructArray<Particle>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__Particles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Color32> _Color
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__Color));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Color32>) null : new Il2CppStructArray<Color32>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__Color), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<ParticlePositionData> _PositionData
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__PositionData));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ParticlePositionData>) null : new Il2CppStructArray<ParticlePositionData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__PositionData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _MinIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__MinIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__MinIndex)) = value;
      }
    }

    public unsafe int _MaxIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__MaxIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__MaxIndex)) = value;
      }
    }

    public unsafe int _MaxParticles
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__MaxParticles));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunParticleSystem.NativeFieldInfoPtr__MaxParticles)) = value;
      }
    }
  }
}
