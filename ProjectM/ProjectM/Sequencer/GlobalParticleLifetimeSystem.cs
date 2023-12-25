// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GlobalParticleLifetimeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class GlobalParticleLifetimeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GlobalParticleParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__GlobalParticlePool;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticleSystemJob;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticleCustomData;
    private static readonly System.IntPtr NativeFieldInfoPtr__Handle;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateGlobalParticles_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateGlobalParticles_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_45;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCheckIfShouldSpawnGlobal_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateGlobalParticles_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101547, XrefRangeEnd = 1101586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101586, XrefRangeEnd = 1101602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101602, XrefRangeEnd = 1101709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101709, XrefRangeEnd = 1101717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlobalParticleLifetimeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101717, XrefRangeEnd = 1101758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101780, RefRangeEnd = 1101781, XrefRangeStart = 1101758, XrefRangeEnd = 1101780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCheckIfShouldSpawnGlobal_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckIfShouldSpawnGlobal_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101806, RefRangeEnd = 1101807, XrefRangeStart = 1101781, XrefRangeEnd = 1101806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateGlobalParticles_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateGlobalParticles_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101811, RefRangeEnd = 1101812, XrefRangeStart = 1101807, XrefRangeEnd = 1101811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1101816, RefRangeEnd = 1101817, XrefRangeStart = 1101812, XrefRangeEnd = 1101816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GlobalParticleLifetimeSystem()
    {
      Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GlobalParticleLifetimeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr);
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr__GlobalParticleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (_GlobalParticleParent));
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr__GlobalParticlePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (_GlobalParticlePool));
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr__ParticleSystemJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (_ParticleSystemJob));
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr__ParticleCustomData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (_ParticleCustomData));
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr__Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (_Handle));
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>CheckIfShouldSpawnGlobal_entityQuery");
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>CheckIfShouldSpawnGlobal_profilerMarker");
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr___UpdateGlobalParticles_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>UpdateGlobalParticles_entityQuery");
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr___UpdateGlobalParticles_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>UpdateGlobalParticles_profilerMarker");
      GlobalParticleLifetimeSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_45));
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687391);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687392);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687393);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687394);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687395);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckIfShouldSpawnGlobal_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687396);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateGlobalParticles_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687397);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687398);
      GlobalParticleLifetimeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, 100687399);
    }

    public GlobalParticleLifetimeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform _GlobalParticleParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__GlobalParticleParent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__GlobalParticleParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GlobalParticlePool _GlobalParticlePool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__GlobalParticlePool));
        return pointer == System.IntPtr.Zero ? (GlobalParticlePool) null : new GlobalParticlePool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__GlobalParticlePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UpdateParticlesJob _ParticleSystemJob
    {
      get
      {
        return *(UpdateParticlesJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__ParticleSystemJob));
      }
      [param: In] set
      {
        *(UpdateParticlesJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__ParticleSystemJob)) = value;
      }
    }

    public unsafe List<Vector4> _ParticleCustomData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__ParticleCustomData));
        return pointer == System.IntPtr.Zero ? (List<Vector4>) null : new List<Vector4>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__ParticleCustomData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JobHandle _Handle
    {
      get
      {
        return *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__Handle));
      }
      [param: In] set
      {
        *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__Handle)) = value;
      }
    }

    public unsafe EntityQuery __CheckIfShouldSpawnGlobal_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CheckIfShouldSpawnGlobal_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawnGlobal_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateGlobalParticles_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___UpdateGlobalParticles_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___UpdateGlobalParticles_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateGlobalParticles_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___UpdateGlobalParticles_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr___UpdateGlobalParticles_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_45
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_45));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalParticleLifetimeSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_45)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ParticleToSpawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ParticleToSpawn_0;
      [FieldOffset(0)]
      public float DistanceSq;
      [FieldOffset(4)]
      public Entity Entity;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101293, XrefRangeEnd = 1101294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(GlobalParticleLifetimeSystem.ParticleToSpawn other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.ParticleToSpawn.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ParticleToSpawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ParticleToSpawn()
      {
        Il2CppClassPointerStore<GlobalParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, nameof (ParticleToSpawn));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr);
        GlobalParticleLifetimeSystem.ParticleToSpawn.NativeFieldInfoPtr_DistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, nameof (DistanceSq));
        GlobalParticleLifetimeSystem.ParticleToSpawn.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, nameof (Entity));
        GlobalParticleLifetimeSystem.ParticleToSpawn.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ParticleToSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, 100687400);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/<>c__DisplayClass8_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass8_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasValidPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalParticlesToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalPositionBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalRotationBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_GlobalParticleIndex_byref_Translation_byref_Rotation_byref_SequencerParticle_0;
      [FieldOffset(0)]
      public float3 localPosition;
      [FieldOffset(12)]
      public bool hasValidPosition;
      [FieldOffset(16)]
      public NativeList<GlobalParticleLifetimeSystem.ParticleToSpawn> globalParticlesToSpawn;
      [FieldOffset(32)]
      public NativeArray<float4> globalPositionBuffer;
      [FieldOffset(48)]
      public NativeArray<quaternion> globalRotationBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        [In] ref GlobalParticleIndex globalParticleIndex,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref SequencerParticle sequencerParticle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref globalParticleIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequencerParticle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_GlobalParticleIndex_byref_Translation_byref_Rotation_byref_SequencerParticle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr);
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (localPosition));
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_hasValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (hasValidPosition));
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_globalParticlesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (globalParticlesToSpawn));
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_globalPositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (globalPositionBuffer));
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_globalRotationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (globalRotationBuffer));
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100687401);
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100687402);
        GlobalParticleLifetimeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_GlobalParticleIndex_byref_Translation_byref_Rotation_byref_SequencerParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100687403);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass8_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_CheckIfShouldSpawnGlobal")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CheckIfShouldSpawnGlobal
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasValidPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalParticlesToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float3 localPosition;
      [FieldOffset(12)]
      public bool hasValidPosition;
      [FieldOffset(16)]
      public NativeList<GlobalParticleLifetimeSystem.ParticleToSpawn> globalParticlesToSpawn;
      [FieldOffset(32)]
      public GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101379, XrefRangeEnd = 1101382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1101382, RefRangeEnd = 1101384, XrefRangeStart = 1101382, XrefRangeEnd = 1101382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GlobalParticleLifetimeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1101384, RefRangeEnd = 1101386, XrefRangeStart = 1101384, XrefRangeEnd = 1101384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GlobalParticleLifetimeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101386, XrefRangeEnd = 1101388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1101394, RefRangeEnd = 1101395, XrefRangeStart = 1101388, XrefRangeEnd = 1101394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1101397, RefRangeEnd = 1101398, XrefRangeStart = 1101395, XrefRangeEnd = 1101397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GlobalParticleLifetimeSystem componentSystem,
        ref GlobalParticleLifetimeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101398, XrefRangeEnd = 1101402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101402, XrefRangeEnd = 1101408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CheckIfShouldSpawnGlobal()
      {
        Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass_CheckIfShouldSpawnGlobal");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (localPosition));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_hasValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (hasValidPosition));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_globalParticlesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (globalParticlesToSpawn));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (_runtimes));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687404);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687405);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687406);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687407);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687408);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687409);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687410);
        GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, 100687411);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1101298, RefRangeEnd = 1101299, XrefRangeStart = 1101294, XrefRangeEnd = 1101298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GlobalParticleLifetimeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1101303, RefRangeEnd = 1101304, XrefRangeStart = 1101299, XrefRangeEnd = 1101303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr, 100687412);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr, 100687413);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_CheckIfShouldSpawnGlobal/ProjectM.Sequencer.RunWithoutJobSystem_00005494$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, "RunWithoutJobSystem_00005494$PostfixBurstDelegate");
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687414);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687415);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687416);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687417);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_CheckIfShouldSpawnGlobal/ProjectM.Sequencer.RunWithoutJobSystem_00005494$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101304, XrefRangeEnd = 1101318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101318, XrefRangeEnd = 1101336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101336, XrefRangeEnd = 1101351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1101378, RefRangeEnd = 1101379, XrefRangeStart = 1101351, XrefRangeEnd = 1101378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal>.NativeClassPtr, "RunWithoutJobSystem_00005494$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687418);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687419);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687420);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687421);
          GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687423);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawnGlobal.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateGlobalParticles")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateGlobalParticles
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_globalPositionBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalRotationBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_GlobalParticleIndex_byref_Translation_byref_Rotation_byref_SequencerParticle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<float4> globalPositionBuffer;
      [FieldOffset(16)]
      public NativeArray<quaternion> globalRotationBuffer;
      [FieldOffset(32)]
      public GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1101510, RefRangeEnd = 1101511, XrefRangeStart = 1101509, XrefRangeEnd = 1101510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref GlobalParticleIndex globalParticleIndex,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref SequencerParticle sequencerParticle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref globalParticleIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequencerParticle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_GlobalParticleIndex_byref_Translation_byref_Rotation_byref_SequencerParticle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1101511, RefRangeEnd = 1101514, XrefRangeStart = 1101511, XrefRangeEnd = 1101511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GlobalParticleLifetimeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1101514, RefRangeEnd = 1101517, XrefRangeStart = 1101514, XrefRangeEnd = 1101514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GlobalParticleLifetimeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101517, XrefRangeEnd = 1101519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1101533, RefRangeEnd = 1101534, XrefRangeStart = 1101519, XrefRangeEnd = 1101533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1101536, RefRangeEnd = 1101537, XrefRangeStart = 1101534, XrefRangeEnd = 1101536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GlobalParticleLifetimeSystem componentSystem,
        ref GlobalParticleLifetimeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101537, XrefRangeEnd = 1101541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101541, XrefRangeEnd = 1101547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateGlobalParticles()
      {
        Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateGlobalParticles");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_globalPositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (globalPositionBuffer));
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_globalRotationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (globalRotationBuffer));
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (_runtimes));
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_GlobalParticleIndex_byref_Translation_byref_Rotation_byref_SequencerParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687424);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687425);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687426);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687427);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687428);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687429);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687430);
        GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, 100687431);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_globalParticleIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequencerParticle;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<GlobalParticleIndex> forParameter_globalParticleIndex;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<SequencerParticle> forParameter_sequencerParticle;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1101420, RefRangeEnd = 1101421, XrefRangeStart = 1101408, XrefRangeEnd = 1101420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GlobalParticleLifetimeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1101433, RefRangeEnd = 1101434, XrefRangeStart = 1101421, XrefRangeEnd = 1101433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_globalParticleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_globalParticleIndex));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequencerParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequencerParticle));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GlobalParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, 100687432);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, 100687433);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_globalParticleIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequencerParticle;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<GlobalParticleIndex>.Runtime runtime_globalParticleIndex;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<SequencerParticle>.Runtime runtime_sequencerParticle;

          static Runtimes()
          {
            Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_globalParticleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_globalParticleIndex));
            GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequencerParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequencerParticle));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateGlobalParticles/ProjectM.Sequencer.RunWithoutJobSystem_0000549D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, "RunWithoutJobSystem_0000549D$PostfixBurstDelegate");
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687434);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687435);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687436);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687437);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.GlobalParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateGlobalParticles/ProjectM.Sequencer.RunWithoutJobSystem_0000549D$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101434, XrefRangeEnd = 1101448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101448, XrefRangeEnd = 1101466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101466, XrefRangeEnd = 1101481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1101508, RefRangeEnd = 1101509, XrefRangeStart = 1101481, XrefRangeEnd = 1101508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles>.NativeClassPtr, "RunWithoutJobSystem_0000549D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687438);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687439);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687440);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687441);
          GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687443);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GlobalParticleLifetimeSystem.__c__DisplayClass_UpdateGlobalParticles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
