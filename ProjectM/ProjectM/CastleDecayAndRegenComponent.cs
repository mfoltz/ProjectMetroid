// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleDecayAndRegenComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CastleDecayAndRegenComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DecayPercentageOnTick;
    private static readonly IntPtr NativeFieldInfoPtr_RegenPercentageOnTick;
    private static readonly IntPtr NativeFieldInfoPtr_DecayThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_CanDieFromDecay;
    private static readonly IntPtr NativeFieldInfoPtr_ChangeModelWhenDecaying;
    private static readonly IntPtr NativeFieldInfoPtr_HealthThreshold;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974356, XrefRangeEnd = 974366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CastleDecayAndRegenComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974366, XrefRangeEnd = 974367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleDecayAndRegenComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleDecayAndRegenComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleDecayAndRegenComponent()
    {
      Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CastleDecayAndRegenComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr);
      CastleDecayAndRegenComponent.NativeFieldInfoPtr_DecayPercentageOnTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, nameof (DecayPercentageOnTick));
      CastleDecayAndRegenComponent.NativeFieldInfoPtr_RegenPercentageOnTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, nameof (RegenPercentageOnTick));
      CastleDecayAndRegenComponent.NativeFieldInfoPtr_DecayThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, nameof (DecayThreshold));
      CastleDecayAndRegenComponent.NativeFieldInfoPtr_CanDieFromDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, nameof (CanDieFromDecay));
      CastleDecayAndRegenComponent.NativeFieldInfoPtr_ChangeModelWhenDecaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, nameof (ChangeModelWhenDecaying));
      CastleDecayAndRegenComponent.NativeFieldInfoPtr_HealthThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, nameof (HealthThreshold));
      CastleDecayAndRegenComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, 100675286);
      CastleDecayAndRegenComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleDecayAndRegenComponent>.NativeClassPtr, 100675287);
    }

    public CastleDecayAndRegenComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DecayPercentageOnTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_DecayPercentageOnTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_DecayPercentageOnTick)) = value;
      }
    }

    public unsafe float RegenPercentageOnTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_RegenPercentageOnTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_RegenPercentageOnTick)) = value;
      }
    }

    public unsafe float DecayThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_DecayThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_DecayThreshold)) = value;
      }
    }

    public unsafe bool CanDieFromDecay
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_CanDieFromDecay));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_CanDieFromDecay)) = value;
      }
    }

    public unsafe bool ChangeModelWhenDecaying
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_ChangeModelWhenDecaying));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_ChangeModelWhenDecaying)) = value;
      }
    }

    public unsafe float HealthThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_HealthThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleDecayAndRegenComponent.NativeFieldInfoPtr_HealthThreshold)) = value;
      }
    }
  }
}
