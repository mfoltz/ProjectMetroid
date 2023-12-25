// Decompiled with JetBrains decompiler
// Type: ProjectM.ImpactMaterialComponent
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
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ImpactMaterialComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Offset;
    private static readonly IntPtr NativeFieldInfoPtr_PlayOnSelf;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024562, XrefRangeEnd = 1024565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ImpactMaterialComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ImpactMaterialComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ImpactMaterialComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ImpactMaterialComponent()
    {
      Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ImpactMaterialComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr);
      ImpactMaterialComponent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr, nameof (Type));
      ImpactMaterialComponent.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr, nameof (Offset));
      ImpactMaterialComponent.NativeFieldInfoPtr_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr, nameof (PlayOnSelf));
      ImpactMaterialComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr, 100680025);
      ImpactMaterialComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactMaterialComponent>.NativeClassPtr, 100680026);
    }

    public ImpactMaterialComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ImpactMaterialType Type
    {
      get
      {
        return *(ImpactMaterialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialComponent.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(ImpactMaterialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialComponent.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe float3 Offset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialComponent.NativeFieldInfoPtr_Offset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialComponent.NativeFieldInfoPtr_Offset)) = value;
      }
    }

    public unsafe bool PlayOnSelf
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialComponent.NativeFieldInfoPtr_PlayOnSelf));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactMaterialComponent.NativeFieldInfoPtr_PlayOnSelf)) = value;
      }
    }
  }
}
