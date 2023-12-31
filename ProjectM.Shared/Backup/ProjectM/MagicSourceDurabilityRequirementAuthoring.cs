// Decompiled with JetBrains decompiler
// Type: ProjectM.MagicSourceDurabilityRequirementAuthoring
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
  public class MagicSourceDurabilityRequirementAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityCost;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726757, XrefRangeEnd = 726760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MagicSourceDurabilityRequirementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MagicSourceDurabilityRequirementAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MagicSourceDurabilityRequirementAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MagicSourceDurabilityRequirementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MagicSourceDurabilityRequirementAuthoring()
    {
      Il2CppClassPointerStore<MagicSourceDurabilityRequirementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MagicSourceDurabilityRequirementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MagicSourceDurabilityRequirementAuthoring>.NativeClassPtr);
      MagicSourceDurabilityRequirementAuthoring.NativeFieldInfoPtr_DurabilityCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagicSourceDurabilityRequirementAuthoring>.NativeClassPtr, nameof (DurabilityCost));
      MagicSourceDurabilityRequirementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagicSourceDurabilityRequirementAuthoring>.NativeClassPtr, 100664257);
      MagicSourceDurabilityRequirementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagicSourceDurabilityRequirementAuthoring>.NativeClassPtr, 100664258);
    }

    public MagicSourceDurabilityRequirementAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DurabilityCost
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MagicSourceDurabilityRequirementAuthoring.NativeFieldInfoPtr_DurabilityCost));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MagicSourceDurabilityRequirementAuthoring.NativeFieldInfoPtr_DurabilityCost)) = value;
      }
    }
  }
}
