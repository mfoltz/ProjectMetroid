// Decompiled with JetBrains decompiler
// Type: ProjectM.TakeDamageInSunComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TakeDamageInSunComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DebuffPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_MaxSunShield;
    private static readonly IntPtr NativeFieldInfoPtr_SunShieldRecoverySpeed;
    private static readonly IntPtr NativeFieldInfoPtr_SunChargeUpTime;
    private static readonly IntPtr NativeFieldInfoPtr_SunCooldownTime;
    private static readonly IntPtr NativeFieldInfoPtr_SunChargeUpSequence;
    private static readonly IntPtr NativeFieldInfoPtr_SunChargeUpSunbeamSequence;
    private static readonly IntPtr NativeFieldInfoPtr_SunCooldownSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024987, XrefRangeEnd = 1024998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TakeDamageInSunComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024998, XrefRangeEnd = 1025002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TakeDamageInSunComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025002, XrefRangeEnd = 1025003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TakeDamageInSunComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TakeDamageInSunComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TakeDamageInSunComponent()
    {
      Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TakeDamageInSunComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr);
      TakeDamageInSunComponent.NativeFieldInfoPtr_DebuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (DebuffPrefab));
      TakeDamageInSunComponent.NativeFieldInfoPtr_MaxSunShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (MaxSunShield));
      TakeDamageInSunComponent.NativeFieldInfoPtr_SunShieldRecoverySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (SunShieldRecoverySpeed));
      TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (SunChargeUpTime));
      TakeDamageInSunComponent.NativeFieldInfoPtr_SunCooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (SunCooldownTime));
      TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (SunChargeUpSequence));
      TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpSunbeamSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (SunChargeUpSunbeamSequence));
      TakeDamageInSunComponent.NativeFieldInfoPtr_SunCooldownSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, nameof (SunCooldownSequence));
      TakeDamageInSunComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, 100680079);
      TakeDamageInSunComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, 100680080);
      TakeDamageInSunComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeDamageInSunComponent>.NativeClassPtr, 100680081);
    }

    public TakeDamageInSunComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent DebuffPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_DebuffPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_DebuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float MaxSunShield
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_MaxSunShield));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_MaxSunShield)) = value;
      }
    }

    public unsafe float SunShieldRecoverySpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunShieldRecoverySpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunShieldRecoverySpeed)) = value;
      }
    }

    public unsafe float SunChargeUpTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpTime)) = value;
      }
    }

    public unsafe float SunCooldownTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunCooldownTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunCooldownTime)) = value;
      }
    }

    public unsafe SequenceField SunChargeUpSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField SunChargeUpSunbeamSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpSunbeamSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunChargeUpSunbeamSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField SunCooldownSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunCooldownSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TakeDamageInSunComponent.NativeFieldInfoPtr_SunCooldownSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
