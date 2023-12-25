// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningAttractorAuthoring
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
namespace ProjectM.LightningStorm
{
  public class LightningAttractorAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AttractorType;
    private static readonly IntPtr NativeFieldInfoPtr_AttractorWeight;
    private static readonly IntPtr NativeFieldInfoPtr_AttractorRadius;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114691, XrefRangeEnd = 1114695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(LightningAttractorAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114695, XrefRangeEnd = 1114696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningAttractorAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningAttractorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningAttractorAuthoring()
    {
      Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningAttractorAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr);
      LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr, nameof (AttractorType));
      LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr, nameof (AttractorWeight));
      LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr, nameof (AttractorRadius));
      LightningAttractorAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr, 100688245);
      LightningAttractorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningAttractorAuthoring>.NativeClassPtr, 100688246);
    }

    public LightningAttractorAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LightningAttractorType AttractorType
    {
      get
      {
        return *(LightningAttractorType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorType));
      }
      [param: In] set
      {
        *(LightningAttractorType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorType)) = value;
      }
    }

    public unsafe float AttractorWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorWeight)) = value;
      }
    }

    public unsafe float AttractorRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningAttractorAuthoring.NativeFieldInfoPtr_AttractorRadius)) = value;
      }
    }
  }
}
