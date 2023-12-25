// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldVFXSpawnAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class WorldVFXSpawnAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnedVisualEffect;
    private static readonly IntPtr NativeFieldInfoPtr_VFXSpawnTranslationOffsets;
    private static readonly IntPtr NativeFieldInfoPtr_VFXSpawnScale;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnCooldownOffsetRange;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnCooldown;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084828, XrefRangeEnd = 1084849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084849, XrefRangeEnd = 1084867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSpawnAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084867, XrefRangeEnd = 1084875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldVFXSpawnAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldVFXSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldVFXSpawnAuthoring()
    {
      Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorldVFXSpawnAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr);
      WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnedVisualEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, nameof (SpawnedVisualEffect));
      WorldVFXSpawnAuthoring.NativeFieldInfoPtr_VFXSpawnTranslationOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, nameof (VFXSpawnTranslationOffsets));
      WorldVFXSpawnAuthoring.NativeFieldInfoPtr_VFXSpawnScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, nameof (VFXSpawnScale));
      WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnCooldownOffsetRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, nameof (SpawnCooldownOffsetRange));
      WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, nameof (SpawnCooldown));
      WorldVFXSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, 100685450);
      WorldVFXSpawnAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, 100685451);
      WorldVFXSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldVFXSpawnAuthoring>.NativeClassPtr, 100685452);
    }

    public WorldVFXSpawnAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject SpawnedVisualEffect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnedVisualEffect));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnedVisualEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<float3> VFXSpawnTranslationOffsets
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_VFXSpawnTranslationOffsets));
        return pointer == IntPtr.Zero ? (List<float3>) null : new List<float3>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_VFXSpawnTranslationOffsets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 VFXSpawnScale
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_VFXSpawnScale));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_VFXSpawnScale)) = value;
      }
    }

    public unsafe Vector2 SpawnCooldownOffsetRange
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnCooldownOffsetRange));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnCooldownOffsetRange)) = value;
      }
    }

    public unsafe float SpawnCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldVFXSpawnAuthoring.NativeFieldInfoPtr_SpawnCooldown)) = value;
      }
    }
  }
}
