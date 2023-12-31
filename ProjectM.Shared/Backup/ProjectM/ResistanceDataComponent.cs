// Decompiled with JetBrains decompiler
// Type: ProjectM.ResistanceDataComponent
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
namespace ProjectM
{
  public class ResistanceDataComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SunResistance_IncreasedSunPiercingDuration;
    private static readonly IntPtr NativeFieldInfoPtr_GarlicResistance_DamageReductionPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_GarlicResistance_IncreasedExposureFactorPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_GarlicResistance_ReduceMaxStacksPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_FireResistance_DamageReductionPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_FireResistance_RedcuedIgiteChancePerRating;
    private static readonly IntPtr NativeFieldInfoPtr_SilverResistance_DamageReductionPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_SilverResistance_CarryValueAbsorbedPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_HolyResistance_DamageReductionPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_HolyResistance_DamageAbsorbPerRating;
    private static readonly IntPtr NativeFieldInfoPtr_PvPResilience_DamageReductionPerRating;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747836, XrefRangeEnd = 747839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ResistanceDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ResistanceDataComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResistanceDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ResistanceDataComponent()
    {
      Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ResistanceDataComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr);
      ResistanceDataComponent.NativeFieldInfoPtr_SunResistance_IncreasedSunPiercingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (SunResistance_IncreasedSunPiercingDuration));
      ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (GarlicResistance_DamageReductionPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_IncreasedExposureFactorPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (GarlicResistance_IncreasedExposureFactorPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_ReduceMaxStacksPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (GarlicResistance_ReduceMaxStacksPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_FireResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (FireResistance_DamageReductionPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_FireResistance_RedcuedIgiteChancePerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (FireResistance_RedcuedIgiteChancePerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_SilverResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (SilverResistance_DamageReductionPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_SilverResistance_CarryValueAbsorbedPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (SilverResistance_CarryValueAbsorbedPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_HolyResistance_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (HolyResistance_DamageReductionPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_HolyResistance_DamageAbsorbPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (HolyResistance_DamageAbsorbPerRating));
      ResistanceDataComponent.NativeFieldInfoPtr_PvPResilience_DamageReductionPerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, nameof (PvPResilience_DamageReductionPerRating));
      ResistanceDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, 100665860);
      ResistanceDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistanceDataComponent>.NativeClassPtr, 100665861);
    }

    public ResistanceDataComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SunResistance_IncreasedSunPiercingDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_SunResistance_IncreasedSunPiercingDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_SunResistance_IncreasedSunPiercingDuration)) = value;
      }
    }

    public unsafe float GarlicResistance_DamageReductionPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_DamageReductionPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_DamageReductionPerRating)) = value;
      }
    }

    public unsafe float GarlicResistance_IncreasedExposureFactorPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_IncreasedExposureFactorPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_IncreasedExposureFactorPerRating)) = value;
      }
    }

    public unsafe float GarlicResistance_ReduceMaxStacksPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_ReduceMaxStacksPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_GarlicResistance_ReduceMaxStacksPerRating)) = value;
      }
    }

    public unsafe float FireResistance_DamageReductionPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_FireResistance_DamageReductionPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_FireResistance_DamageReductionPerRating)) = value;
      }
    }

    public unsafe float FireResistance_RedcuedIgiteChancePerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_FireResistance_RedcuedIgiteChancePerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_FireResistance_RedcuedIgiteChancePerRating)) = value;
      }
    }

    public unsafe float SilverResistance_DamageReductionPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_SilverResistance_DamageReductionPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_SilverResistance_DamageReductionPerRating)) = value;
      }
    }

    public unsafe float SilverResistance_CarryValueAbsorbedPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_SilverResistance_CarryValueAbsorbedPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_SilverResistance_CarryValueAbsorbedPerRating)) = value;
      }
    }

    public unsafe float HolyResistance_DamageReductionPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_HolyResistance_DamageReductionPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_HolyResistance_DamageReductionPerRating)) = value;
      }
    }

    public unsafe float HolyResistance_DamageAbsorbPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_HolyResistance_DamageAbsorbPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_HolyResistance_DamageAbsorbPerRating)) = value;
      }
    }

    public unsafe float PvPResilience_DamageReductionPerRating
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_PvPResilience_DamageReductionPerRating));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResistanceDataComponent.NativeFieldInfoPtr_PvPResilience_DamageReductionPerRating)) = value;
      }
    }
  }
}
