// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UnitCompositionAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RespawnTime;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultFormation;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnBuffKind;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_UnitCompositionId_Entity_EntityManager_DayTimeSpanSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMaxPossibleUnits_Public_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763054, RefRangeEnd = 763055, XrefRangeStart = 762991, XrefRangeEnd = 763054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitCompositionId Convert(
      Entity entity,
      EntityManager dstManager,
      DayTimeSpanSettings timeRequirementOverride)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) timeRequirementOverride);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionAuthoring.NativeMethodInfoPtr_Convert_Public_UnitCompositionId_Entity_EntityManager_DayTimeSpanSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UnitCompositionId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763055, XrefRangeEnd = 763060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetMaxPossibleUnits()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionAuthoring.NativeMethodInfoPtr_GetMaxPossibleUnits_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitCompositionAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitCompositionAuthoring()
    {
      Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr);
      UnitCompositionAuthoring.NativeFieldInfoPtr_RespawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr, nameof (RespawnTime));
      UnitCompositionAuthoring.NativeFieldInfoPtr_DefaultFormation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr, nameof (DefaultFormation));
      UnitCompositionAuthoring.NativeFieldInfoPtr_SpawnBuffKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr, nameof (SpawnBuffKind));
      UnitCompositionAuthoring.NativeMethodInfoPtr_Convert_Public_UnitCompositionId_Entity_EntityManager_DayTimeSpanSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr, 100667408);
      UnitCompositionAuthoring.NativeMethodInfoPtr_GetMaxPossibleUnits_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr, 100667409);
      UnitCompositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionAuthoring>.NativeClassPtr, 100667410);
    }

    public UnitCompositionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitRespawnSettings RespawnTime
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionAuthoring.NativeFieldInfoPtr_RespawnTime));
        return pointer == IntPtr.Zero ? (UnitRespawnSettings) null : new UnitRespawnSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionAuthoring.NativeFieldInfoPtr_RespawnTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitFormationAuthoring DefaultFormation
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionAuthoring.NativeFieldInfoPtr_DefaultFormation));
        return pointer == IntPtr.Zero ? (UnitFormationAuthoring) null : new UnitFormationAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionAuthoring.NativeFieldInfoPtr_DefaultFormation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBuffKind SpawnBuffKind
    {
      get
      {
        return *(SpawnBuffKind*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionAuthoring.NativeFieldInfoPtr_SpawnBuffKind));
      }
      [param: In] set
      {
        *(SpawnBuffKind*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionAuthoring.NativeFieldInfoPtr_SpawnBuffKind)) = value;
      }
    }
  }
}
