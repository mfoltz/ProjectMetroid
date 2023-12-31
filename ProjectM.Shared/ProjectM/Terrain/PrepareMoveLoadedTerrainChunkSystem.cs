// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.PrepareMoveLoadedTerrainChunkSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  public class PrepareMoveLoadedTerrainChunkSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__TerrainQuery;
    private static readonly IntPtr NativeFieldInfoPtr__TerrainChunkSharedQuery;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LoadTerrainChunkRequest_8;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LoadToTargetWorld_9;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766890, XrefRangeEnd = 766914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766914, XrefRangeEnd = 766946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrepareMoveLoadedTerrainChunkSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766946, XrefRangeEnd = 766960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrepareMoveLoadedTerrainChunkSystem()
    {
      Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (PrepareMoveLoadedTerrainChunkSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr);
      PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__TerrainQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, nameof (_TerrainQuery));
      PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__TerrainChunkSharedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, nameof (_TerrainChunkSharedQuery));
      PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__SingletonEntityQuery_LoadTerrainChunkRequest_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LoadTerrainChunkRequest_8));
      PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__SingletonEntityQuery_LoadToTargetWorld_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LoadToTargetWorld_9));
      PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, 100667820);
      PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, 100667821);
      PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, 100667822);
      PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, 100667823);
      PrepareMoveLoadedTerrainChunkSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrepareMoveLoadedTerrainChunkSystem>.NativeClassPtr, 100667824);
    }

    public PrepareMoveLoadedTerrainChunkSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _TerrainQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__TerrainQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__TerrainQuery)) = value;
      }
    }

    public unsafe EntityQuery _TerrainChunkSharedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__TerrainChunkSharedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__TerrainChunkSharedQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LoadTerrainChunkRequest_8
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__SingletonEntityQuery_LoadTerrainChunkRequest_8));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__SingletonEntityQuery_LoadTerrainChunkRequest_8)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LoadToTargetWorld_9
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__SingletonEntityQuery_LoadToTargetWorld_9));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrepareMoveLoadedTerrainChunkSystem.NativeFieldInfoPtr__SingletonEntityQuery_LoadToTargetWorld_9)) = value;
      }
    }
  }
}
