// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityInaccuracyAuthoring
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
  public class AbilityInaccuracyAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OnlyOnMovingTargets;
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDegrees;
    private static readonly IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995882, XrefRangeEnd = 995886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityInaccuracyAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 631690, RefRangeEnd = 631694, XrefRangeStart = 631690, XrefRangeEnd = 631694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityInaccuracyAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityInaccuracyAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityInaccuracyAuthoring()
    {
      Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityInaccuracyAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr);
      AbilityInaccuracyAuthoring.NativeFieldInfoPtr_OnlyOnMovingTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, nameof (OnlyOnMovingTargets));
      AbilityInaccuracyAuthoring.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, nameof (Type));
      AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MaxDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, nameof (MaxDegrees));
      AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, nameof (MinDistance));
      AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, nameof (MaxDistance));
      AbilityInaccuracyAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, 100676909);
      AbilityInaccuracyAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityInaccuracyAuthoring>.NativeClassPtr, 100676910);
    }

    public AbilityInaccuracyAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool OnlyOnMovingTargets
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_OnlyOnMovingTargets));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_OnlyOnMovingTargets)) = value;
      }
    }

    public unsafe AbilityInaccuracyType Type
    {
      get
      {
        return *(AbilityInaccuracyType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(AbilityInaccuracyType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe float MaxDegrees
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MaxDegrees));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MaxDegrees)) = value;
      }
    }

    public unsafe float MinDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MinDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MinDistance)) = value;
      }
    }

    public unsafe float MaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityInaccuracyAuthoring.NativeFieldInfoPtr_MaxDistance)) = value;
      }
    }
  }
}
