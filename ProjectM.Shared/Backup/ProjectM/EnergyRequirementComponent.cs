// Decompiled with JetBrains decompiler
// Type: ProjectM.EnergyRequirementComponent
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
  public class EnergyRequirementComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Energy;
    private static readonly IntPtr NativeFieldInfoPtr_DrainEnergyOnUse;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726685, XrefRangeEnd = 726688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(EnergyRequirementComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnergyRequirementComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EnergyRequirementComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EnergyRequirementComponent()
    {
      Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EnergyRequirementComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr);
      EnergyRequirementComponent.NativeFieldInfoPtr_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr, nameof (Energy));
      EnergyRequirementComponent.NativeFieldInfoPtr_DrainEnergyOnUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr, nameof (DrainEnergyOnUse));
      EnergyRequirementComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr, 100664239);
      EnergyRequirementComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyRequirementComponent>.NativeClassPtr, 100664240);
    }

    public EnergyRequirementComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Energy
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyRequirementComponent.NativeFieldInfoPtr_Energy));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyRequirementComponent.NativeFieldInfoPtr_Energy)) = value;
      }
    }

    public unsafe bool DrainEnergyOnUse
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyRequirementComponent.NativeFieldInfoPtr_DrainEnergyOnUse));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyRequirementComponent.NativeFieldInfoPtr_DrainEnergyOnUse)) = value;
      }
    }
  }
}
