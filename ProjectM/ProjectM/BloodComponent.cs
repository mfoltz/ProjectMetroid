// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using ProjectM.Sequencer;
using ProjectM.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BloodComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BLOOD_POOOL_SIZE_FACTOR;
    private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_BLOOD_QUALITY;
    private static readonly IntPtr NativeFieldInfoPtr_MAX_BLOOD;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultBloodType;
    private static readonly IntPtr NativeFieldInfoPtr_LossPerSecond;
    private static readonly IntPtr NativeFieldInfoPtr_StopDrainOnDisconnect;
    private static readonly IntPtr NativeFieldInfoPtr_Debuff;
    private static readonly IntPtr NativeFieldInfoPtr_BloodSCT;
    private static readonly IntPtr NativeFieldInfoPtr_LowBloodSequenceStartFactor;
    private static readonly IntPtr NativeFieldInfoPtr_LowBloodSequence;
    private static readonly IntPtr NativeFieldInfoPtr_NoBloodSequence;
    private static readonly IntPtr NativeFieldInfoPtr_ShareVBloodAbility;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023989, XrefRangeEnd = 1024007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BloodComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024007, XrefRangeEnd = 1024011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024011, XrefRangeEnd = 1024012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodComponent()
    {
      Il2CppClassPointerStore<BloodComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr);
      BloodComponent.NativeFieldInfoPtr_DEFAULT_BLOOD_POOOL_SIZE_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (DEFAULT_BLOOD_POOOL_SIZE_FACTOR));
      BloodComponent.NativeFieldInfoPtr_DEFAULT_BLOOD_QUALITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (DEFAULT_BLOOD_QUALITY));
      BloodComponent.NativeFieldInfoPtr_MAX_BLOOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (MAX_BLOOD));
      BloodComponent.NativeFieldInfoPtr_DefaultBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (DefaultBloodType));
      BloodComponent.NativeFieldInfoPtr_LossPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (LossPerSecond));
      BloodComponent.NativeFieldInfoPtr_StopDrainOnDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (StopDrainOnDisconnect));
      BloodComponent.NativeFieldInfoPtr_Debuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (Debuff));
      BloodComponent.NativeFieldInfoPtr_BloodSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (BloodSCT));
      BloodComponent.NativeFieldInfoPtr_LowBloodSequenceStartFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (LowBloodSequenceStartFactor));
      BloodComponent.NativeFieldInfoPtr_LowBloodSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (LowBloodSequence));
      BloodComponent.NativeFieldInfoPtr_NoBloodSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (NoBloodSequence));
      BloodComponent.NativeFieldInfoPtr_ShareVBloodAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (ShareVBloodAbility));
      BloodComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, 100679967);
      BloodComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, 100679968);
      BloodComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, 100679969);
    }

    public BloodComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float DEFAULT_BLOOD_POOOL_SIZE_FACTOR
    {
      get
      {
        float bloodPooolSizeFactor;
        IL2CPP.il2cpp_field_static_get_value(BloodComponent.NativeFieldInfoPtr_DEFAULT_BLOOD_POOOL_SIZE_FACTOR, (void*) &bloodPooolSizeFactor);
        return bloodPooolSizeFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BloodComponent.NativeFieldInfoPtr_DEFAULT_BLOOD_POOOL_SIZE_FACTOR, (void*) &value);
      }
    }

    public static unsafe float DEFAULT_BLOOD_QUALITY
    {
      get
      {
        float defaultBloodQuality;
        IL2CPP.il2cpp_field_static_get_value(BloodComponent.NativeFieldInfoPtr_DEFAULT_BLOOD_QUALITY, (void*) &defaultBloodQuality);
        return defaultBloodQuality;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BloodComponent.NativeFieldInfoPtr_DEFAULT_BLOOD_QUALITY, (void*) &value);
      }
    }

    public static unsafe float MAX_BLOOD
    {
      get
      {
        float maxBlood;
        IL2CPP.il2cpp_field_static_get_value(BloodComponent.NativeFieldInfoPtr_MAX_BLOOD, (void*) &maxBlood);
        return maxBlood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BloodComponent.NativeFieldInfoPtr_MAX_BLOOD, (void*) &value);
      }
    }

    public unsafe UnitBloodType DefaultBloodType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_DefaultBloodType));
        return pointer == IntPtr.Zero ? (UnitBloodType) null : new UnitBloodType(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_DefaultBloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float LossPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_LossPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_LossPerSecond)) = value;
      }
    }

    public unsafe bool StopDrainOnDisconnect
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_StopDrainOnDisconnect));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_StopDrainOnDisconnect)) = value;
      }
    }

    public unsafe PrefabGuidComponent Debuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_Debuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_Debuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type BloodSCT
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_BloodSCT));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_BloodSCT), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float LowBloodSequenceStartFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_LowBloodSequenceStartFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_LowBloodSequenceStartFactor)) = value;
      }
    }

    public unsafe SequenceField LowBloodSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_LowBloodSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_LowBloodSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField NoBloodSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_NoBloodSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_NoBloodSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<AbilityGroupComponent> ShareVBloodAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_ShareVBloodAbility));
        return pointer == IntPtr.Zero ? (WeakAssetReference<AbilityGroupComponent>) null : new WeakAssetReference<AbilityGroupComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodComponent.NativeFieldInfoPtr_ShareVBloodAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class BloodQualityBuffArray : ReorderableArray<BloodQualityBuff_Editor>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023986, XrefRangeEnd = 1023989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BloodQualityBuffArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodComponent.BloodQualityBuffArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodComponent.BloodQualityBuffArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BloodQualityBuffArray()
      {
        Il2CppClassPointerStore<BloodComponent.BloodQualityBuffArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodComponent>.NativeClassPtr, nameof (BloodQualityBuffArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodComponent.BloodQualityBuffArray>.NativeClassPtr);
        BloodComponent.BloodQualityBuffArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodComponent.BloodQualityBuffArray>.NativeClassPtr, 100679970);
      }

      public BloodQualityBuffArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
