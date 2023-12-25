// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GlobalParticlePool
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class GlobalParticlePool : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACTIVE_PARTICLE_SYSTEMS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACTIVE_PARTICLES_IN_SYSTEM;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalPositionBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalRotationBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeIndexes;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveParticleSystems;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexInPositionBuffer_Public_Static_Int32_GlobalParticleIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalBufferOffset_Public_Static_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeltaParticleCount_Public_Static_Int32_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveParticleSystems_Public_Il2CppReferenceArray_1_ActiveParticle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetParticleIndex_Public_GlobalParticleIndex_ParticleSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillSystem_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101209, XrefRangeEnd = 1101231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlobalParticlePool(Transform parent)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe int GetIndexInPositionBuffer(GlobalParticleIndex globalParticleIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &globalParticleIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_GetIndexInPositionBuffer_Public_Static_Int32_GlobalParticleIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int GetGlobalBufferOffset(int prefabIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_GetGlobalBufferOffset_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101231, XrefRangeEnd = 1101241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetDeltaParticleCount(
      [In] ref int activeParticleCount,
      [In] ref int spawnedCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref activeParticleCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnedCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_GetDeltaParticleCount_Public_Static_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<GlobalParticlePool.ActiveParticle> GetActiveParticleSystems()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_GetActiveParticleSystems_Public_Il2CppReferenceArray_1_ActiveParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GlobalParticlePool.ActiveParticle>) null : new Il2CppReferenceArray<GlobalParticlePool.ActiveParticle>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101277, RefRangeEnd = 1101278, XrefRangeStart = 1101241, XrefRangeEnd = 1101277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlobalParticleIndex GetParticleIndex(ParticleSystem particleSystemPrefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particleSystemPrefab);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_GetParticleIndex_Public_GlobalParticleIndex_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GlobalParticleIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101285, RefRangeEnd = 1101286, XrefRangeStart = 1101278, XrefRangeEnd = 1101285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void KillSystem(int prefabIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_KillSystem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101286, XrefRangeEnd = 1101292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticlePool.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GlobalParticlePool()
    {
      Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GlobalParticlePool));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr);
      GlobalParticlePool.NativeFieldInfoPtr_MAX_ACTIVE_PARTICLE_SYSTEMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (MAX_ACTIVE_PARTICLE_SYSTEMS));
      GlobalParticlePool.NativeFieldInfoPtr_MAX_ACTIVE_PARTICLES_IN_SYSTEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (MAX_ACTIVE_PARTICLES_IN_SYSTEM));
      GlobalParticlePool.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (Parent));
      GlobalParticlePool.NativeFieldInfoPtr_GlobalPositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (GlobalPositionBuffer));
      GlobalParticlePool.NativeFieldInfoPtr_GlobalRotationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (GlobalRotationBuffer));
      GlobalParticlePool.NativeFieldInfoPtr__FreeIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (_FreeIndexes));
      GlobalParticlePool.NativeFieldInfoPtr__ActiveParticleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (_ActiveParticleSystems));
      GlobalParticlePool.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687382);
      GlobalParticlePool.NativeMethodInfoPtr_GetIndexInPositionBuffer_Public_Static_Int32_GlobalParticleIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687383);
      GlobalParticlePool.NativeMethodInfoPtr_GetGlobalBufferOffset_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687384);
      GlobalParticlePool.NativeMethodInfoPtr_GetDeltaParticleCount_Public_Static_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687385);
      GlobalParticlePool.NativeMethodInfoPtr_GetActiveParticleSystems_Public_Il2CppReferenceArray_1_ActiveParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687386);
      GlobalParticlePool.NativeMethodInfoPtr_GetParticleIndex_Public_GlobalParticleIndex_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687387);
      GlobalParticlePool.NativeMethodInfoPtr_KillSystem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687388);
      GlobalParticlePool.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, 100687389);
    }

    public GlobalParticlePool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAX_ACTIVE_PARTICLE_SYSTEMS
    {
      get
      {
        int activeParticleSystems;
        IL2CPP.il2cpp_field_static_get_value(GlobalParticlePool.NativeFieldInfoPtr_MAX_ACTIVE_PARTICLE_SYSTEMS, (void*) &activeParticleSystems);
        return activeParticleSystems;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalParticlePool.NativeFieldInfoPtr_MAX_ACTIVE_PARTICLE_SYSTEMS, (void*) &value);
      }
    }

    public static unsafe int MAX_ACTIVE_PARTICLES_IN_SYSTEM
    {
      get
      {
        int particlesInSystem;
        IL2CPP.il2cpp_field_static_get_value(GlobalParticlePool.NativeFieldInfoPtr_MAX_ACTIVE_PARTICLES_IN_SYSTEM, (void*) &particlesInSystem);
        return particlesInSystem;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalParticlePool.NativeFieldInfoPtr_MAX_ACTIVE_PARTICLES_IN_SYSTEM, (void*) &value);
      }
    }

    public unsafe Transform Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr_Parent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<float4> GlobalPositionBuffer
    {
      get
      {
        return *(NativeArray<float4>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr_GlobalPositionBuffer));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr_GlobalPositionBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<quaternion> GlobalRotationBuffer
    {
      get
      {
        return *(NativeArray<quaternion>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr_GlobalRotationBuffer));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr_GlobalRotationBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Stack<int> _FreeIndexes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr__FreeIndexes));
        return pointer == System.IntPtr.Zero ? (Stack<int>) null : new Stack<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr__FreeIndexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GlobalParticlePool.ActiveParticle> _ActiveParticleSystems
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr__ActiveParticleSystems));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GlobalParticlePool.ActiveParticle>) null : new Il2CppReferenceArray<GlobalParticlePool.ActiveParticle>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.NativeFieldInfoPtr__ActiveParticleSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class ActiveParticle : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_FollowInstances;
      private static readonly System.IntPtr NativeFieldInfoPtr_FollowInstancesCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParticleCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnedCount;

      static ActiveParticle()
      {
        Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticlePool>.NativeClassPtr, nameof (ActiveParticle));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr);
        GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, nameof (Prefab));
        GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_FollowInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, nameof (FollowInstances));
        GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_FollowInstancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, nameof (FollowInstancesCount));
        GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_ParticleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, nameof (ParticleCount));
        GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_SpawnedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, nameof (SpawnedCount));
      }

      public ActiveParticle(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ActiveParticle()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticlePool.ActiveParticle>.NativeClassPtr, data));
      }

      public unsafe ParticleSystem Prefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_Prefab));
          return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<GameObject> FollowInstances
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_FollowInstances));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_FollowInstances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int FollowInstancesCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_FollowInstancesCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_FollowInstancesCount)) = value;
        }
      }

      public unsafe int ParticleCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_ParticleCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_ParticleCount)) = value;
        }
      }

      public unsafe int SpawnedCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_SpawnedCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticlePool.ActiveParticle.NativeFieldInfoPtr_SpawnedCount)) = value;
        }
      }
    }
  }
}
