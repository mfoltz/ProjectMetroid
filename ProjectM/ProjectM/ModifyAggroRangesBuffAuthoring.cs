// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyAggroRangesBuffAuthoring
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
  public class ModifyAggroRangesBuffAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ModifyAggroCircleRadius;
    private static readonly IntPtr NativeFieldInfoPtr_AggroCircleRadiusFactor;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyAggroConeRadius;
    private static readonly IntPtr NativeFieldInfoPtr_AggroConeRadiusFactor;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyAlertCircleRadius;
    private static readonly IntPtr NativeFieldInfoPtr_AlertCircleRadiusFactor;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyAlertConeRadius;
    private static readonly IntPtr NativeFieldInfoPtr_AlertConeRadiusFactor;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025047, XrefRangeEnd = 1025053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ModifyAggroRangesBuffAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyAggroRangesBuffAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyAggroRangesBuffAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyAggroRangesBuffAuthoring()
    {
      Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyAggroRangesBuffAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr);
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAggroCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (ModifyAggroCircleRadius));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AggroCircleRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (AggroCircleRadiusFactor));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAggroConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (ModifyAggroConeRadius));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AggroConeRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (AggroConeRadiusFactor));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAlertCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (ModifyAlertCircleRadius));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AlertCircleRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (AlertCircleRadiusFactor));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAlertConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (ModifyAlertConeRadius));
      ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AlertConeRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, nameof (AlertConeRadiusFactor));
      ModifyAggroRangesBuffAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, 100680097);
      ModifyAggroRangesBuffAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyAggroRangesBuffAuthoring>.NativeClassPtr, 100680098);
    }

    public ModifyAggroRangesBuffAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool ModifyAggroCircleRadius
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAggroCircleRadius));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAggroCircleRadius)) = value;
      }
    }

    public unsafe float AggroCircleRadiusFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AggroCircleRadiusFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AggroCircleRadiusFactor)) = value;
      }
    }

    public unsafe bool ModifyAggroConeRadius
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAggroConeRadius));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAggroConeRadius)) = value;
      }
    }

    public unsafe float AggroConeRadiusFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AggroConeRadiusFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AggroConeRadiusFactor)) = value;
      }
    }

    public unsafe bool ModifyAlertCircleRadius
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAlertCircleRadius));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAlertCircleRadius)) = value;
      }
    }

    public unsafe float AlertCircleRadiusFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AlertCircleRadiusFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AlertCircleRadiusFactor)) = value;
      }
    }

    public unsafe bool ModifyAlertConeRadius
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAlertConeRadius));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_ModifyAlertConeRadius)) = value;
      }
    }

    public unsafe float AlertConeRadiusFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AlertConeRadiusFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyAggroRangesBuffAuthoring.NativeFieldInfoPtr_AlertConeRadiusFactor)) = value;
      }
    }
  }
}
