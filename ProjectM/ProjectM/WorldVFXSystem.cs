// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldVFXSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

#nullable disable
namespace ProjectM
{
  public class WorldVFXSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__SnowVFX;
    private static readonly IntPtr NativeFieldInfoPtr__RainVFX;
    private static readonly IntPtr NativeFieldInfoPtr__DustVFX;
    private static readonly IntPtr NativeFieldInfoPtr__StartVaultVFX;
    private static readonly IntPtr NativeFieldInfoPtr__FarbaneVFX;
    private static readonly IntPtr NativeFieldInfoPtr__DunleyVFX;
    private static readonly IntPtr NativeFieldInfoPtr__CursedForestVFX;
    private static readonly IntPtr NativeFieldInfoPtr__SilverlightHillsVFX;
    private static readonly IntPtr NativeFieldInfoPtr__SnowEffect;
    private static readonly IntPtr NativeFieldInfoPtr__RainEffect;
    private static readonly IntPtr NativeFieldInfoPtr__DustEffect;
    private static readonly IntPtr NativeFieldInfoPtr__StartVaultEffect;
    private static readonly IntPtr NativeFieldInfoPtr__FarbaneEffect;
    private static readonly IntPtr NativeFieldInfoPtr__DunleyEffect;
    private static readonly IntPtr NativeFieldInfoPtr__CursedForestEffect;
    private static readonly IntPtr NativeFieldInfoPtr__SilverlightHillsEffect;
    private static readonly IntPtr NativeFieldInfoPtr__SnowSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__RainSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__RainWindDirProp;
    private static readonly IntPtr NativeFieldInfoPtr__DustSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__StartVaultSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__FarbaneSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__DunleySpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__CursedForestSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__SilverlightHillsSpawnRateProp;
    private static readonly IntPtr NativeFieldInfoPtr__SnowMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__RainMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__DustMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__StartVaultMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__FarbaneMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__DunleyMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__CursedForestMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__SilverlightHillsMinMaxSpawnRate;
    private static readonly IntPtr NativeFieldInfoPtr__CallbackNeedsCleanup;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_43;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVolumeStackUpdateWorldVFX_Private_Void_VolumeStack_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetWorldVFXsForNewCamera_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084875, XrefRangeEnd = 1084878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldVFXSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084878, XrefRangeEnd = 1084894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldVFXSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084894, XrefRangeEnd = 1084928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnVolumeStackUpdateWorldVFX(VolumeStack volumeStack)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSystem.NativeMethodInfoPtr_OnVolumeStackUpdateWorldVFX_Private_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetWorldVFXsForNewCamera()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSystem.NativeMethodInfoPtr_SetWorldVFXsForNewCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084928, XrefRangeEnd = 1085100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldVFXSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldVFXSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085100, XrefRangeEnd = 1085108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldVFXSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldVFXSystem()
    {
      Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorldVFXSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr);
      WorldVFXSystem.NativeFieldInfoPtr__SnowVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SnowVFX));
      WorldVFXSystem.NativeFieldInfoPtr__RainVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_RainVFX));
      WorldVFXSystem.NativeFieldInfoPtr__DustVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DustVFX));
      WorldVFXSystem.NativeFieldInfoPtr__StartVaultVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_StartVaultVFX));
      WorldVFXSystem.NativeFieldInfoPtr__FarbaneVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_FarbaneVFX));
      WorldVFXSystem.NativeFieldInfoPtr__DunleyVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DunleyVFX));
      WorldVFXSystem.NativeFieldInfoPtr__CursedForestVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_CursedForestVFX));
      WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SilverlightHillsVFX));
      WorldVFXSystem.NativeFieldInfoPtr__SnowEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SnowEffect));
      WorldVFXSystem.NativeFieldInfoPtr__RainEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_RainEffect));
      WorldVFXSystem.NativeFieldInfoPtr__DustEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DustEffect));
      WorldVFXSystem.NativeFieldInfoPtr__StartVaultEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_StartVaultEffect));
      WorldVFXSystem.NativeFieldInfoPtr__FarbaneEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_FarbaneEffect));
      WorldVFXSystem.NativeFieldInfoPtr__DunleyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DunleyEffect));
      WorldVFXSystem.NativeFieldInfoPtr__CursedForestEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_CursedForestEffect));
      WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SilverlightHillsEffect));
      WorldVFXSystem.NativeFieldInfoPtr__SnowSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SnowSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__RainSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_RainSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__RainWindDirProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_RainWindDirProp));
      WorldVFXSystem.NativeFieldInfoPtr__DustSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DustSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__StartVaultSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_StartVaultSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__FarbaneSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_FarbaneSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__DunleySpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DunleySpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__CursedForestSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_CursedForestSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsSpawnRateProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SilverlightHillsSpawnRateProp));
      WorldVFXSystem.NativeFieldInfoPtr__SnowMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SnowMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__RainMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_RainMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__DustMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DustMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__StartVaultMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_StartVaultMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__FarbaneMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_FarbaneMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__DunleyMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_DunleyMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__CursedForestMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_CursedForestMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsMinMaxSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SilverlightHillsMinMaxSpawnRate));
      WorldVFXSystem.NativeFieldInfoPtr__CallbackNeedsCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_CallbackNeedsCleanup));
      WorldVFXSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_43 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_HybridCameraData_43));
      WorldVFXSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685453);
      WorldVFXSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685454);
      WorldVFXSystem.NativeMethodInfoPtr_OnVolumeStackUpdateWorldVFX_Private_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685455);
      WorldVFXSystem.NativeMethodInfoPtr_SetWorldVFXsForNewCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685456);
      WorldVFXSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685457);
      WorldVFXSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685458);
      WorldVFXSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSystem>.NativeClassPtr, 100685459);
    }

    public WorldVFXSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject _SnowVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _RainVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _DustVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _StartVaultVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _FarbaneVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _DunleyVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleyVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleyVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _CursedForestVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject _SilverlightHillsVFX
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsVFX));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsVFX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _SnowEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _RainEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _DustEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _StartVaultEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _FarbaneEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _DunleyEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleyEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleyEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _CursedForestEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VisualEffect _SilverlightHillsEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsEffect));
        return pointer == IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _SnowSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _RainSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _RainWindDirProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainWindDirProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainWindDirProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _DustSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _StartVaultSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _FarbaneSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _DunleySpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleySpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleySpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _CursedForestSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ExposedProperty _SilverlightHillsSpawnRateProp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsSpawnRateProp));
        return pointer == IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsSpawnRateProp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float2 _SnowMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SnowMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _RainMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__RainMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _DustMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DustMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _StartVaultMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__StartVaultMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _FarbaneMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__FarbaneMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _DunleyMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleyMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__DunleyMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _CursedForestMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CursedForestMinMaxSpawnRate)) = value;
      }
    }

    public unsafe float2 _SilverlightHillsMinMaxSpawnRate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsMinMaxSpawnRate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SilverlightHillsMinMaxSpawnRate)) = value;
      }
    }

    public unsafe bool _CallbackNeedsCleanup
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CallbackNeedsCleanup));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__CallbackNeedsCleanup)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_HybridCameraData_43
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_43));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_43)) = value;
      }
    }
  }
}
