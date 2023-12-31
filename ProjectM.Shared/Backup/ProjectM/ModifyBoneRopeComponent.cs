// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyBoneRopeComponent
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
  public class ModifyBoneRopeComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ModificationType;
    private static readonly IntPtr NativeFieldInfoPtr_SimulationWeight;
    private static readonly IntPtr NativeFieldInfoPtr_Weight;
    private static readonly IntPtr NativeFieldInfoPtr_EndWeight;
    private static readonly IntPtr NativeMethodInfoPtr_Unity_Entities_IConvertGameObjectToEntity_Convert_Private_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726760, XrefRangeEnd = 726763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Unity_Entities_IConvertGameObjectToEntity_Convert(
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
      IL2CPP.il2cpp_runtime_invoke(ModifyBoneRopeComponent.NativeMethodInfoPtr_Unity_Entities_IConvertGameObjectToEntity_Convert_Private_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyBoneRopeComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyBoneRopeComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyBoneRopeComponent()
    {
      Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyBoneRopeComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr);
      ModifyBoneRopeComponent.NativeFieldInfoPtr_ModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr, nameof (ModificationType));
      ModifyBoneRopeComponent.NativeFieldInfoPtr_SimulationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr, nameof (SimulationWeight));
      ModifyBoneRopeComponent.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr, nameof (Weight));
      ModifyBoneRopeComponent.NativeFieldInfoPtr_EndWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr, nameof (EndWeight));
      ModifyBoneRopeComponent.NativeMethodInfoPtr_Unity_Entities_IConvertGameObjectToEntity_Convert_Private_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr, 100664259);
      ModifyBoneRopeComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyBoneRopeComponent>.NativeClassPtr, 100664260);
    }

    public ModifyBoneRopeComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModifyBoneRopeComponent.ModType ModificationType
    {
      get
      {
        return *(ModifyBoneRopeComponent.ModType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_ModificationType));
      }
      [param: In] set
      {
        *(ModifyBoneRopeComponent.ModType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_ModificationType)) = value;
      }
    }

    public unsafe CurveReference SimulationWeight
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_SimulationWeight));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_SimulationWeight)) = value;
      }
    }

    public unsafe float Weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_Weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_Weight)) = value;
      }
    }

    public unsafe float EndWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_EndWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBoneRopeComponent.NativeFieldInfoPtr_EndWeight)) = value;
      }
    }

    public enum ModType
    {
      Constant,
      Curve,
    }
  }
}
