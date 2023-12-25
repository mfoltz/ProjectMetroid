// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.RelicBoundMapIconSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Shared
{
  public class RelicBoundMapIconSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__TeamsWithRelics;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetTeamsWithRelicRadar_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetTeamsWithRelicRadar_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FillBitMaskWithUsers_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FillBitMaskWithUsers_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RelicSpawnBoundMapIcon_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RelicSpawnBoundMapIcon_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RelicMapIcon_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RelicMapIcon_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_29;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetTeamsWithRelicRadar_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFillBitMaskWithUsers_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRelicSpawnBoundMapIcon_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRelicMapIcon_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468684, XrefRangeEnd = 1468694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RelicBoundMapIconSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468694, XrefRangeEnd = 1468697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RelicBoundMapIconSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468697, XrefRangeEnd = 1468770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RelicBoundMapIconSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RelicBoundMapIconSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468770, XrefRangeEnd = 1468897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RelicBoundMapIconSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1468919, RefRangeEnd = 1468920, XrefRangeStart = 1468897, XrefRangeEnd = 1468919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetTeamsWithRelicRadar_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetTeamsWithRelicRadar_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468920, XrefRangeEnd = 1468939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFillBitMaskWithUsers_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForFillBitMaskWithUsers_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468939, XrefRangeEnd = 1468958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRelicSpawnBoundMapIcon_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForRelicSpawnBoundMapIcon_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468958, XrefRangeEnd = 1468977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRelicMapIcon_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForRelicMapIcon_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1468981, RefRangeEnd = 1468982, XrefRangeStart = 1468977, XrefRangeEnd = 1468981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1468986, RefRangeEnd = 1468987, XrefRangeStart = 1468982, XrefRangeEnd = 1468986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1468991, RefRangeEnd = 1468992, XrefRangeStart = 1468987, XrefRangeEnd = 1468991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1468996, RefRangeEnd = 1468997, XrefRangeStart = 1468992, XrefRangeEnd = 1468996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RelicBoundMapIconSystem()
    {
      Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Shared", nameof (RelicBoundMapIconSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr);
      RelicBoundMapIconSystem.NativeFieldInfoPtr__ServerGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, nameof (_ServerGameSettings));
      RelicBoundMapIconSystem.NativeFieldInfoPtr__TeamsWithRelics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, nameof (_TeamsWithRelics));
      RelicBoundMapIconSystem.NativeFieldInfoPtr___GetTeamsWithRelicRadar_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>GetTeamsWithRelicRadar_entityQuery");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___GetTeamsWithRelicRadar_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>GetTeamsWithRelicRadar_profilerMarker");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___FillBitMaskWithUsers_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>FillBitMaskWithUsers_entityQuery");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___FillBitMaskWithUsers_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>FillBitMaskWithUsers_profilerMarker");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicSpawnBoundMapIcon_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>RelicSpawnBoundMapIcon_entityQuery");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicSpawnBoundMapIcon_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>RelicSpawnBoundMapIcon_profilerMarker");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicMapIcon_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>RelicMapIcon_entityQuery");
      RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicMapIcon_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>RelicMapIcon_profilerMarker");
      RelicBoundMapIconSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_RelicDropped_29));
      RelicBoundMapIconSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674377);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674378);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674379);
      RelicBoundMapIconSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674380);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674381);
      RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetTeamsWithRelicRadar_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674382);
      RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForFillBitMaskWithUsers_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674383);
      RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForRelicSpawnBoundMapIcon_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674384);
      RelicBoundMapIconSystem.NativeMethodInfoPtr___GetEntityQuery_ForRelicMapIcon_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674385);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674386);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674387);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674388);
      RelicBoundMapIconSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, 100674389);
    }

    public RelicBoundMapIconSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerGameSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr__ServerGameSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr__ServerGameSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<int> _TeamsWithRelics
    {
      get
      {
        return *(NativeHashSet<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr__TeamsWithRelics));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr__TeamsWithRelics), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __GetTeamsWithRelicRadar_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___GetTeamsWithRelicRadar_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___GetTeamsWithRelicRadar_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetTeamsWithRelicRadar_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___GetTeamsWithRelicRadar_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___GetTeamsWithRelicRadar_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FillBitMaskWithUsers_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___FillBitMaskWithUsers_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___FillBitMaskWithUsers_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FillBitMaskWithUsers_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___FillBitMaskWithUsers_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___FillBitMaskWithUsers_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RelicSpawnBoundMapIcon_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicSpawnBoundMapIcon_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicSpawnBoundMapIcon_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RelicSpawnBoundMapIcon_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicSpawnBoundMapIcon_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicSpawnBoundMapIcon_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RelicMapIcon_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicMapIcon_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicMapIcon_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RelicMapIcon_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicMapIcon_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr___RelicMapIcon_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_RelicDropped_29
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_29));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelicBoundMapIconSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_29)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/<>c__DisplayClass4_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass4_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_teamsWithRelics;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersWithRadarBitMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_uniqueRelics;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ConnectedUser_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_OnlySyncToUserBitMask_byref_RelicSpawnBoundMapIcon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_OnlySyncToUserBitMask_0;
      [FieldOffset(0)]
      public NativeHashSet<int> teamsWithRelics;
      [FieldOffset(16)]
      public UserBitMask128 usersWithRadarBitMask;
      [FieldOffset(32)]
      public NativeArray<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(48)]
      public bool uniqueRelics;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref ConnectedUser connectedUser, [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref connectedUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ConnectedUser_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        ref OnlySyncToUserBitMask onlySyncToUserBitMask,
        [In] ref RelicSpawnBoundMapIcon relicBoundMapIcon)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref onlySyncToUserBitMask;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref relicBoundMapIcon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_OnlySyncToUserBitMask_byref_RelicSpawnBoundMapIcon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(ref OnlySyncToUserBitMask onlySyncToUserBitMask)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref onlySyncToUserBitMask;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_OnlySyncToUserBitMask_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr);
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_teamsWithRelics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (teamsWithRelics));
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_usersWithRadarBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (usersWithRadarBitMask));
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (relicsDroppedBuffer));
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_uniqueRelics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (uniqueRelics));
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, 100674390);
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, 100674391);
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ConnectedUser_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, 100674392);
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_OnlySyncToUserBitMask_byref_RelicSpawnBoundMapIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, 100674393);
        RelicBoundMapIconSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_OnlySyncToUserBitMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, 100674394);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass4_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_GetTeamsWithRelicRadar")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetTeamsWithRelicRadar
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_teamsWithRelics;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<int> teamsWithRelics;
      [FieldOffset(16)]
      public RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468305, XrefRangeEnd = 1468308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468308, XrefRangeEnd = 1468310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468315, RefRangeEnd = 1468316, XrefRangeStart = 1468310, XrefRangeEnd = 1468315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468318, RefRangeEnd = 1468319, XrefRangeStart = 1468316, XrefRangeEnd = 1468318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RelicBoundMapIconSystem componentSystem,
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468319, XrefRangeEnd = 1468323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468323, XrefRangeEnd = 1468329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetTeamsWithRelicRadar()
      {
        Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>c__DisplayClass_GetTeamsWithRelicRadar");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_teamsWithRelics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, nameof (teamsWithRelics));
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, nameof (_runtimes));
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674395);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674396);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674397);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674398);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674399);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674400);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674401);
        RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, 100674402);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468225, RefRangeEnd = 1468226, XrefRangeStart = 1468222, XrefRangeEnd = 1468225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RelicBoundMapIconSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468229, RefRangeEnd = 1468230, XrefRangeStart = 1468226, XrefRangeEnd = 1468229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders>.NativeClassPtr, 100674403);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders>.NativeClassPtr, 100674404);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;

          static Runtimes()
          {
            Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_GetTeamsWithRelicRadar/ProjectM.Shared.RunWithoutJobSystem_00001A56$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, "RunWithoutJobSystem_00001A56$PostfixBurstDelegate");
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674405);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674406);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674407);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674408);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_GetTeamsWithRelicRadar/ProjectM.Shared.RunWithoutJobSystem_00001A56$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468230, XrefRangeEnd = 1468244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468244, XrefRangeEnd = 1468262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468262, XrefRangeEnd = 1468277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468304, RefRangeEnd = 1468305, XrefRangeStart = 1468277, XrefRangeEnd = 1468304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar>.NativeClassPtr, "RunWithoutJobSystem_00001A56$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674409);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674410);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674411);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674412);
          RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674414);
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
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_GetTeamsWithRelicRadar.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_FillBitMaskWithUsers")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FillBitMaskWithUsers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_teamsWithRelics;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersWithRadarBitMask;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ConnectedUser_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<int> teamsWithRelics;
      [FieldOffset(16)]
      public UserBitMask128 usersWithRadarBitMask;
      [FieldOffset(32)]
      public RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468418, XrefRangeEnd = 1468422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref ConnectedUser connectedUser, [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref connectedUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ConnectedUser_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468422, XrefRangeEnd = 1468424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468432, RefRangeEnd = 1468433, XrefRangeStart = 1468424, XrefRangeEnd = 1468432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468435, RefRangeEnd = 1468436, XrefRangeStart = 1468433, XrefRangeEnd = 1468435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RelicBoundMapIconSystem componentSystem,
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468436, XrefRangeEnd = 1468440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468440, XrefRangeEnd = 1468446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FillBitMaskWithUsers()
      {
        Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>c__DisplayClass_FillBitMaskWithUsers");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_teamsWithRelics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (teamsWithRelics));
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_usersWithRadarBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (usersWithRadarBitMask));
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (_runtimes));
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ConnectedUser_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674415);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674416);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674417);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674418);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674419);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674420);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674421);
        RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, 100674422);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_connectedUser;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ConnectedUser> forParameter_connectedUser;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468335, RefRangeEnd = 1468336, XrefRangeStart = 1468329, XrefRangeEnd = 1468335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RelicBoundMapIconSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468342, RefRangeEnd = 1468343, XrefRangeStart = 1468336, XrefRangeEnd = 1468342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_connectedUser));
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr, 100674423);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr, 100674424);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_connectedUser;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ConnectedUser>.Runtime runtime_connectedUser;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;

          static Runtimes()
          {
            Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_connectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_connectedUser));
            RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_FillBitMaskWithUsers/ProjectM.Shared.RunWithoutJobSystem_00001A5F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, "RunWithoutJobSystem_00001A5F$PostfixBurstDelegate");
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674425);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674426);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674427);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674428);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_FillBitMaskWithUsers/ProjectM.Shared.RunWithoutJobSystem_00001A5F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468343, XrefRangeEnd = 1468357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468357, XrefRangeEnd = 1468375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468375, XrefRangeEnd = 1468390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468417, RefRangeEnd = 1468418, XrefRangeStart = 1468390, XrefRangeEnd = 1468417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers>.NativeClassPtr, "RunWithoutJobSystem_00001A5F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674429);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674430);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674431);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674432);
          RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674434);
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
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_FillBitMaskWithUsers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_RelicSpawnBoundMapIcon")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RelicSpawnBoundMapIcon
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_uniqueRelics;
      private static readonly System.IntPtr NativeFieldInfoPtr_usersWithRadarBitMask;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_byref_RelicSpawnBoundMapIcon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(16)]
      public bool uniqueRelics;
      [FieldOffset(20)]
      public UserBitMask128 usersWithRadarBitMask;
      [FieldOffset(40)]
      public RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468535, RefRangeEnd = 1468536, XrefRangeStart = 1468535, XrefRangeEnd = 1468535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref OnlySyncToUserBitMask onlySyncToUserBitMask,
        [In] ref RelicSpawnBoundMapIcon relicBoundMapIcon)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref onlySyncToUserBitMask;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref relicBoundMapIcon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_byref_RelicSpawnBoundMapIcon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468536, RefRangeEnd = 1468537, XrefRangeStart = 1468536, XrefRangeEnd = 1468536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468537, RefRangeEnd = 1468538, XrefRangeStart = 1468537, XrefRangeEnd = 1468537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468538, XrefRangeEnd = 1468540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468548, RefRangeEnd = 1468549, XrefRangeStart = 1468540, XrefRangeEnd = 1468548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468551, RefRangeEnd = 1468552, XrefRangeStart = 1468549, XrefRangeEnd = 1468551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RelicBoundMapIconSystem componentSystem,
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468552, XrefRangeEnd = 1468556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468556, XrefRangeEnd = 1468562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RelicSpawnBoundMapIcon()
      {
        Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>c__DisplayClass_RelicSpawnBoundMapIcon");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (relicsDroppedBuffer));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_uniqueRelics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (uniqueRelics));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_usersWithRadarBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (usersWithRadarBitMask));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (_runtimes));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_byref_RelicSpawnBoundMapIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674435);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674436);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674437);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674438);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674439);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674440);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674441);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, 100674442);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_onlySyncToUserBitMask;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_relicBoundMapIcon;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask> forParameter_onlySyncToUserBitMask;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RelicSpawnBoundMapIcon> forParameter_relicBoundMapIcon;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468452, RefRangeEnd = 1468453, XrefRangeStart = 1468446, XrefRangeEnd = 1468452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RelicBoundMapIconSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468459, RefRangeEnd = 1468460, XrefRangeStart = 1468453, XrefRangeEnd = 1468459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_onlySyncToUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_onlySyncToUserBitMask));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_relicBoundMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_relicBoundMapIcon));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr, 100674443);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr, 100674444);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_onlySyncToUserBitMask;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_relicBoundMapIcon;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask>.Runtime runtime_onlySyncToUserBitMask;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RelicSpawnBoundMapIcon>.Runtime runtime_relicBoundMapIcon;

          static Runtimes()
          {
            Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_onlySyncToUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_onlySyncToUserBitMask));
            RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_relicBoundMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_relicBoundMapIcon));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_RelicSpawnBoundMapIcon/ProjectM.Shared.RunWithoutJobSystem_00001A68$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, "RunWithoutJobSystem_00001A68$PostfixBurstDelegate");
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674445);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674446);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674447);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674448);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_RelicSpawnBoundMapIcon/ProjectM.Shared.RunWithoutJobSystem_00001A68$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468460, XrefRangeEnd = 1468474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468474, XrefRangeEnd = 1468492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468492, XrefRangeEnd = 1468507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468534, RefRangeEnd = 1468535, XrefRangeStart = 1468507, XrefRangeEnd = 1468534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon>.NativeClassPtr, "RunWithoutJobSystem_00001A68$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674449);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674450);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674451);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674452);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674454);
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
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicSpawnBoundMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_RelicMapIcon")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RelicMapIcon
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_usersWithRadarBitMask;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public UserBitMask128 usersWithRadarBitMask;
      [FieldOffset(16)]
      public RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref OnlySyncToUserBitMask onlySyncToUserBitMask)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref onlySyncToUserBitMask;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752617, RefRangeEnd = 752621, XrefRangeStart = 752617, XrefRangeEnd = 752621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752621, RefRangeEnd = 752625, XrefRangeStart = 752621, XrefRangeEnd = 752625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468663, XrefRangeEnd = 1468665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468670, RefRangeEnd = 1468671, XrefRangeStart = 1468665, XrefRangeEnd = 1468670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1468673, RefRangeEnd = 1468674, XrefRangeStart = 1468671, XrefRangeEnd = 1468673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RelicBoundMapIconSystem componentSystem,
        ref RelicBoundMapIconSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468674, XrefRangeEnd = 1468678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468678, XrefRangeEnd = 1468684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RelicMapIcon()
      {
        Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem>.NativeClassPtr, "<>c__DisplayClass_RelicMapIcon");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_usersWithRadarBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, nameof (usersWithRadarBitMask));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, nameof (_runtimes));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_OnlySyncToUserBitMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674455);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674456);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674457);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674458);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674459);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674460);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674461);
        RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, 100674462);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_onlySyncToUserBitMask;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask> forParameter_onlySyncToUserBitMask;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468565, RefRangeEnd = 1468566, XrefRangeStart = 1468562, XrefRangeEnd = 1468565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RelicBoundMapIconSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468569, RefRangeEnd = 1468570, XrefRangeStart = 1468566, XrefRangeEnd = 1468569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_onlySyncToUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_onlySyncToUserBitMask));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RelicBoundMapIconSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders>.NativeClassPtr, 100674463);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders>.NativeClassPtr, 100674464);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_onlySyncToUserBitMask;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<OnlySyncToUserBitMask>.Runtime runtime_onlySyncToUserBitMask;

          static Runtimes()
          {
            Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_onlySyncToUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_onlySyncToUserBitMask));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_RelicMapIcon/ProjectM.Shared.RunWithoutJobSystem_00001A71$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, "RunWithoutJobSystem_00001A71$PostfixBurstDelegate");
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674465);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674466);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674467);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100674468);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Shared.RelicBoundMapIconSystem/ProjectM.Shared.<>c__DisplayClass_RelicMapIcon/ProjectM.Shared.RunWithoutJobSystem_00001A71$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468570, XrefRangeEnd = 1468584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468584, XrefRangeEnd = 1468602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1468602, XrefRangeEnd = 1468617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1468662, RefRangeEnd = 1468663, XrefRangeStart = 1468617, XrefRangeEnd = 1468662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon>.NativeClassPtr, "RunWithoutJobSystem_00001A71$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674469);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674470);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674471);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674472);
          RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100674474);
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
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RelicBoundMapIconSystem.__c__DisplayClass_RelicMapIcon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
