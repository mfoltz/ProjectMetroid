// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyWhenNoCharacterNearbyAfterDurationComponent
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
  public class DestroyWhenNoCharacterNearbyAfterDurationComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RemoveAfterDuration;
    private static readonly IntPtr NativeFieldInfoPtr_RandomAdditionalDuration;
    private static readonly IntPtr NativeFieldInfoPtr_MinimumRemoveDurationIfNearby;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012869, XrefRangeEnd = 1012872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012872, XrefRangeEnd = 1012873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyWhenNoCharacterNearbyAfterDurationComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyWhenNoCharacterNearbyAfterDurationComponent()
    {
      Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroyWhenNoCharacterNearbyAfterDurationComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr);
      DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_RemoveAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr, nameof (RemoveAfterDuration));
      DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_RandomAdditionalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr, nameof (RandomAdditionalDuration));
      DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_MinimumRemoveDurationIfNearby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr, nameof (MinimumRemoveDurationIfNearby));
      DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr, 100678935);
      DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationComponent>.NativeClassPtr, 100678936);
    }

    public DestroyWhenNoCharacterNearbyAfterDurationComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float RemoveAfterDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_RemoveAfterDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_RemoveAfterDuration)) = value;
      }
    }

    public unsafe float RandomAdditionalDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_RandomAdditionalDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_RandomAdditionalDuration)) = value;
      }
    }

    public unsafe float MinimumRemoveDurationIfNearby
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_MinimumRemoveDurationIfNearby));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationComponent.NativeFieldInfoPtr_MinimumRemoveDurationIfNearby)) = value;
      }
    }
  }
}
