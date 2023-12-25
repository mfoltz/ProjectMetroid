// Decompiled with JetBrains decompiler
// Type: ProjectM.Portrait.ServantPortraitComponent
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
namespace ProjectM.Portrait
{
  public class ServantPortraitComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_NormalPortrait;
    private static readonly IntPtr NativeFieldInfoPtr_VampirePortrait;
    private static readonly IntPtr NativeFieldInfoPtr_NormalUnitPortraitData;
    private static readonly IntPtr NativeFieldInfoPtr_VampireUnitPortraitData;
    private static readonly IntPtr NativeFieldInfoPtr_PortraitEnvironment;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114675, XrefRangeEnd = 1114689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ServantPortraitComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantPortraitComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantPortraitComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantPortraitComponent()
    {
      Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Portrait", nameof (ServantPortraitComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr);
      ServantPortraitComponent.NativeFieldInfoPtr_NormalPortrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, nameof (NormalPortrait));
      ServantPortraitComponent.NativeFieldInfoPtr_VampirePortrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, nameof (VampirePortrait));
      ServantPortraitComponent.NativeFieldInfoPtr_NormalUnitPortraitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, nameof (NormalUnitPortraitData));
      ServantPortraitComponent.NativeFieldInfoPtr_VampireUnitPortraitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, nameof (VampireUnitPortraitData));
      ServantPortraitComponent.NativeFieldInfoPtr_PortraitEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, nameof (PortraitEnvironment));
      ServantPortraitComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, 100688240);
      ServantPortraitComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPortraitComponent>.NativeClassPtr, 100688241);
    }

    public ServantPortraitComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Sprite NormalPortrait
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_NormalPortrait));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_NormalPortrait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite VampirePortrait
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_VampirePortrait));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_VampirePortrait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitPortraitData NormalUnitPortraitData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_NormalUnitPortraitData));
        return pointer == IntPtr.Zero ? (UnitPortraitData) null : new UnitPortraitData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_NormalUnitPortraitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitPortraitData VampireUnitPortraitData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_VampireUnitPortraitData));
        return pointer == IntPtr.Zero ? (UnitPortraitData) null : new UnitPortraitData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_VampireUnitPortraitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PortraitEnvironmentData PortraitEnvironment
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_PortraitEnvironment));
        return pointer == IntPtr.Zero ? (PortraitEnvironmentData) null : new PortraitEnvironmentData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPortraitComponent.NativeFieldInfoPtr_PortraitEnvironment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
