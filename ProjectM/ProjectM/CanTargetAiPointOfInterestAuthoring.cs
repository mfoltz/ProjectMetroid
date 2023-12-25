// Decompiled with JetBrains decompiler
// Type: ProjectM.CanTargetAiPointOfInterestAuthoring
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
  public class CanTargetAiPointOfInterestAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultType;
    private static readonly IntPtr NativeFieldInfoPtr_Range;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986900, XrefRangeEnd = 986904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CanTargetAiPointOfInterestAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CanTargetAiPointOfInterestAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CanTargetAiPointOfInterestAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CanTargetAiPointOfInterestAuthoring()
    {
      Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CanTargetAiPointOfInterestAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr);
      CanTargetAiPointOfInterestAuthoring.NativeFieldInfoPtr_DefaultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr, nameof (DefaultType));
      CanTargetAiPointOfInterestAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr, nameof (Range));
      CanTargetAiPointOfInterestAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr, 100676121);
      CanTargetAiPointOfInterestAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanTargetAiPointOfInterestAuthoring>.NativeClassPtr, 100676122);
    }

    public CanTargetAiPointOfInterestAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AiPointOfInterestType DefaultType
    {
      get
      {
        return *(AiPointOfInterestType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanTargetAiPointOfInterestAuthoring.NativeFieldInfoPtr_DefaultType));
      }
      [param: In] set
      {
        *(AiPointOfInterestType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanTargetAiPointOfInterestAuthoring.NativeFieldInfoPtr_DefaultType)) = value;
      }
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanTargetAiPointOfInterestAuthoring.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanTargetAiPointOfInterestAuthoring.NativeFieldInfoPtr_Range)) = value;
      }
    }
  }
}
