// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyAfterDurationOnInventoryChangeAuthoring
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
  public class DestroyAfterDurationOnInventoryChangeAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DurationSettings;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012854, XrefRangeEnd = 1012863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DestroyAfterDurationOnInventoryChangeAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyAfterDurationOnInventoryChangeAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyAfterDurationOnInventoryChangeAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyAfterDurationOnInventoryChangeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyAfterDurationOnInventoryChangeAuthoring()
    {
      Il2CppClassPointerStore<DestroyAfterDurationOnInventoryChangeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroyAfterDurationOnInventoryChangeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfterDurationOnInventoryChangeAuthoring>.NativeClassPtr);
      DestroyAfterDurationOnInventoryChangeAuthoring.NativeFieldInfoPtr_DurationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationOnInventoryChangeAuthoring>.NativeClassPtr, nameof (DurationSettings));
      DestroyAfterDurationOnInventoryChangeAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfterDurationOnInventoryChangeAuthoring>.NativeClassPtr, 100678929);
      DestroyAfterDurationOnInventoryChangeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfterDurationOnInventoryChangeAuthoring>.NativeClassPtr, 100678930);
    }

    public DestroyAfterDurationOnInventoryChangeAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BasicRespawnSettings DurationSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationOnInventoryChangeAuthoring.NativeFieldInfoPtr_DurationSettings));
        return pointer == IntPtr.Zero ? (BasicRespawnSettings) null : new BasicRespawnSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationOnInventoryChangeAuthoring.NativeFieldInfoPtr_DurationSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
