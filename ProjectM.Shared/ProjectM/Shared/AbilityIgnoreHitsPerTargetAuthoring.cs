// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.AbilityIgnoreHitsPerTargetAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Shared
{
  public class AbilityIgnoreHitsPerTargetAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HitResetTimer;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797205, XrefRangeEnd = 797211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityIgnoreHitsPerTargetAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797211, XrefRangeEnd = 797212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityIgnoreHitsPerTargetAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityIgnoreHitsPerTargetAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityIgnoreHitsPerTargetAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityIgnoreHitsPerTargetAuthoring()
    {
      Il2CppClassPointerStore<AbilityIgnoreHitsPerTargetAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (AbilityIgnoreHitsPerTargetAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityIgnoreHitsPerTargetAuthoring>.NativeClassPtr);
      AbilityIgnoreHitsPerTargetAuthoring.NativeFieldInfoPtr_HitResetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreHitsPerTargetAuthoring>.NativeClassPtr, nameof (HitResetTimer));
      AbilityIgnoreHitsPerTargetAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityIgnoreHitsPerTargetAuthoring>.NativeClassPtr, 100670348);
      AbilityIgnoreHitsPerTargetAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityIgnoreHitsPerTargetAuthoring>.NativeClassPtr, 100670349);
    }

    public AbilityIgnoreHitsPerTargetAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float HitResetTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreHitsPerTargetAuthoring.NativeFieldInfoPtr_HitResetTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreHitsPerTargetAuthoring.NativeFieldInfoPtr_HitResetTimer)) = value;
      }
    }
  }
}
