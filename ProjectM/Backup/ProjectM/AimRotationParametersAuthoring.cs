// Decompiled with JetBrains decompiler
// Type: ProjectM.AimRotationParametersAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AimRotationParametersAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Constant;
    private static readonly IntPtr NativeFieldInfoPtr_CoreModifier;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996054, XrefRangeEnd = 996057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AimRotationParametersAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996057, XrefRangeEnd = 996058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AimRotationParametersAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AimRotationParametersAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AimRotationParametersAuthoring()
    {
      Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimRotationParametersAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr);
      AimRotationParametersAuthoring.NativeFieldInfoPtr_Constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr, nameof (Constant));
      AimRotationParametersAuthoring.NativeFieldInfoPtr_CoreModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr, nameof (CoreModifier));
      AimRotationParametersAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr, 100676938);
      AimRotationParametersAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimRotationParametersAuthoring>.NativeClassPtr, 100676939);
    }

    public AimRotationParametersAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Constant
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AimRotationParametersAuthoring.NativeFieldInfoPtr_Constant));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AimRotationParametersAuthoring.NativeFieldInfoPtr_Constant)) = value;
      }
    }

    public unsafe float CoreModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AimRotationParametersAuthoring.NativeFieldInfoPtr_CoreModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AimRotationParametersAuthoring.NativeFieldInfoPtr_CoreModifier)) = value;
      }
    }
  }
}
