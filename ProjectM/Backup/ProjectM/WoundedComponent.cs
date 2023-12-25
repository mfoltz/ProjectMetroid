// Decompiled with JetBrains decompiler
// Type: ProjectM.WoundedComponent
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
  public class WoundedComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HealthFactor;
    private static readonly IntPtr NativeFieldInfoPtr_WoundedTriggerSequence;
    private static readonly IntPtr NativeFieldInfoPtr_WoundedSequence;
    private static readonly IntPtr NativeFieldInfoPtr_WoundedKnockbackResistance;
    private static readonly IntPtr NativeFieldInfoPtr_TriggerKnockbackOnWounded;
    private static readonly IntPtr NativeFieldInfoPtr_KnockbackPowerAsset;
    private static readonly IntPtr NativeFieldInfoPtr_KnockbackDuration;
    private static readonly IntPtr NativeFieldInfoPtr_KnockbackRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044186, XrefRangeEnd = 1044198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(WoundedComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WoundedComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WoundedComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WoundedComponent()
    {
      Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WoundedComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr);
      WoundedComponent.NativeFieldInfoPtr_HealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (HealthFactor));
      WoundedComponent.NativeFieldInfoPtr_WoundedTriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (WoundedTriggerSequence));
      WoundedComponent.NativeFieldInfoPtr_WoundedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (WoundedSequence));
      WoundedComponent.NativeFieldInfoPtr_WoundedKnockbackResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (WoundedKnockbackResistance));
      WoundedComponent.NativeFieldInfoPtr_TriggerKnockbackOnWounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (TriggerKnockbackOnWounded));
      WoundedComponent.NativeFieldInfoPtr_KnockbackPowerAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (KnockbackPowerAsset));
      WoundedComponent.NativeFieldInfoPtr_KnockbackDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (KnockbackDuration));
      WoundedComponent.NativeFieldInfoPtr_KnockbackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, nameof (KnockbackRange));
      WoundedComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, 100681824);
      WoundedComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WoundedComponent>.NativeClassPtr, 100681825);
    }

    public WoundedComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float HealthFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_HealthFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_HealthFactor)) = value;
      }
    }

    public unsafe SequenceField WoundedTriggerSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_WoundedTriggerSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_WoundedTriggerSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField WoundedSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_WoundedSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_WoundedSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public KnockbackResistanceCategory WoundedKnockbackResistance
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_WoundedKnockbackResistance);
        return new KnockbackResistanceCategory(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_WoundedKnockbackResistance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KnockbackResistanceCategory>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe bool TriggerKnockbackOnWounded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_TriggerKnockbackOnWounded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_TriggerKnockbackOnWounded)) = value;
      }
    }

    public unsafe KnockbackPowerAsset KnockbackPowerAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_KnockbackPowerAsset));
        return pointer == IntPtr.Zero ? (KnockbackPowerAsset) null : new KnockbackPowerAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_KnockbackPowerAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float KnockbackDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_KnockbackDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_KnockbackDuration)) = value;
      }
    }

    public unsafe float KnockbackRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_KnockbackRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WoundedComponent.NativeFieldInfoPtr_KnockbackRange)) = value;
      }
    }
  }
}
