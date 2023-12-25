// Decompiled with JetBrains decompiler
// Type: ProjectM.ExperienceComponent
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
  public class ExperienceComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaxProgressionLevel;
    private static readonly IntPtr NativeFieldInfoPtr_TotalExperienceForMax;
    private static readonly IntPtr NativeFieldInfoPtr_StartingMaxLevelCap;
    private static readonly IntPtr NativeFieldInfoPtr_LevelUpSequence;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredXPForLevelCurve;
    private static readonly IntPtr NativeFieldInfoPtr_ProgrssoionLevelToEntityLevelCurve;
    private static readonly IntPtr NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_HigherLevel;
    private static readonly IntPtr NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_LowerLevel;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ExperienceComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024552, XrefRangeEnd = 1024553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ExperienceComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExperienceComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ExperienceComponent()
    {
      Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ExperienceComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr);
      ExperienceComponent.NativeFieldInfoPtr_MaxProgressionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (MaxProgressionLevel));
      ExperienceComponent.NativeFieldInfoPtr_TotalExperienceForMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (TotalExperienceForMax));
      ExperienceComponent.NativeFieldInfoPtr_StartingMaxLevelCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (StartingMaxLevelCap));
      ExperienceComponent.NativeFieldInfoPtr_LevelUpSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (LevelUpSequence));
      ExperienceComponent.NativeFieldInfoPtr_RequiredXPForLevelCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (RequiredXPForLevelCurve));
      ExperienceComponent.NativeFieldInfoPtr_ProgrssoionLevelToEntityLevelCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (ProgrssoionLevelToEntityLevelCurve));
      ExperienceComponent.NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_HigherLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (UnitLevelDiffXPFactorCurve_HigherLevel));
      ExperienceComponent.NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_LowerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, nameof (UnitLevelDiffXPFactorCurve_LowerLevel));
      ExperienceComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, 100680017);
      ExperienceComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExperienceComponent>.NativeClassPtr, 100680018);
    }

    public ExperienceComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int MaxProgressionLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_MaxProgressionLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_MaxProgressionLevel)) = value;
      }
    }

    public unsafe int TotalExperienceForMax
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_TotalExperienceForMax));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_TotalExperienceForMax)) = value;
      }
    }

    public unsafe int StartingMaxLevelCap
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_StartingMaxLevelCap));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_StartingMaxLevelCap)) = value;
      }
    }

    public unsafe SequenceField LevelUpSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_LevelUpSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_LevelUpSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveReference RequiredXPForLevelCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_RequiredXPForLevelCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_RequiredXPForLevelCurve)) = value;
      }
    }

    public unsafe CurveReference ProgrssoionLevelToEntityLevelCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_ProgrssoionLevelToEntityLevelCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_ProgrssoionLevelToEntityLevelCurve)) = value;
      }
    }

    public unsafe CurveReference UnitLevelDiffXPFactorCurve_HigherLevel
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_HigherLevel));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_HigherLevel)) = value;
      }
    }

    public unsafe CurveReference UnitLevelDiffXPFactorCurve_LowerLevel
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_LowerLevel));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExperienceComponent.NativeFieldInfoPtr_UnitLevelDiffXPFactorCurve_LowerLevel)) = value;
      }
    }
  }
}
