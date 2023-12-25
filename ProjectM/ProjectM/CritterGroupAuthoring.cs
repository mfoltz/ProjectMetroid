// Decompiled with JetBrains decompiler
// Type: ProjectM.CritterGroupAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CritterGroupAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CritterPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_HasFleeSoundEvent;
    private static readonly IntPtr NativeFieldInfoPtr_FleeSoundEvent;
    private static readonly IntPtr NativeFieldInfoPtr_MinMaxNumberOfSpawnedCritters;
    private static readonly IntPtr NativeFieldInfoPtr_ResetZoneRadius;
    private static readonly IntPtr NativeFieldInfoPtr_ActivationZoneRadius;
    private static readonly IntPtr NativeFieldInfoPtr_EscapeZoneRadius;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnZoneRadius;
    private static readonly IntPtr NativeFieldInfoPtr_IsTemporary;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988054, XrefRangeEnd = 988070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CritterGroupAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988070, XrefRangeEnd = 988090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988090, XrefRangeEnd = 988091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CritterGroupAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CritterGroupAuthoring()
    {
      Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CritterGroupAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr);
      CritterGroupAuthoring.NativeFieldInfoPtr_CritterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (CritterPrefab));
      CritterGroupAuthoring.NativeFieldInfoPtr_HasFleeSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (HasFleeSoundEvent));
      CritterGroupAuthoring.NativeFieldInfoPtr_FleeSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (FleeSoundEvent));
      CritterGroupAuthoring.NativeFieldInfoPtr_MinMaxNumberOfSpawnedCritters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (MinMaxNumberOfSpawnedCritters));
      CritterGroupAuthoring.NativeFieldInfoPtr_ResetZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (ResetZoneRadius));
      CritterGroupAuthoring.NativeFieldInfoPtr_ActivationZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (ActivationZoneRadius));
      CritterGroupAuthoring.NativeFieldInfoPtr_EscapeZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (EscapeZoneRadius));
      CritterGroupAuthoring.NativeFieldInfoPtr_SpawnZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (SpawnZoneRadius));
      CritterGroupAuthoring.NativeFieldInfoPtr_IsTemporary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, nameof (IsTemporary));
      CritterGroupAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, 100676198);
      CritterGroupAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, 100676199);
      CritterGroupAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupAuthoring>.NativeClassPtr, 100676200);
    }

    public CritterGroupAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CritterAuthoring CritterPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_CritterPrefab));
        return pointer == IntPtr.Zero ? (CritterAuthoring) null : new CritterAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_CritterPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool HasFleeSoundEvent
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_HasFleeSoundEvent));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_HasFleeSoundEvent)) = value;
      }
    }

    public FmodEvent FleeSoundEvent
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_FleeSoundEvent);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_FleeSoundEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe Vector2Int MinMaxNumberOfSpawnedCritters
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_MinMaxNumberOfSpawnedCritters));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_MinMaxNumberOfSpawnedCritters)) = value;
      }
    }

    public unsafe float ResetZoneRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_ResetZoneRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_ResetZoneRadius)) = value;
      }
    }

    public unsafe float ActivationZoneRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_ActivationZoneRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_ActivationZoneRadius)) = value;
      }
    }

    public unsafe float EscapeZoneRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_EscapeZoneRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_EscapeZoneRadius)) = value;
      }
    }

    public unsafe float SpawnZoneRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_SpawnZoneRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_SpawnZoneRadius)) = value;
      }
    }

    public unsafe bool IsTemporary
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_IsTemporary));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupAuthoring.NativeFieldInfoPtr_IsTemporary)) = value;
      }
    }
  }
}
