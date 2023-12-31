// Decompiled with JetBrains decompiler
// Type: ProjectM.SetBuffTargetPositionToOwnerAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SetBuffTargetPositionToOwnerAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ClientPositionOffset;
    private static readonly IntPtr NativeFieldInfoPtr_ClientRotationOffset;
    private static readonly IntPtr NativeFieldInfoPtr_AttatchmentBone;
    private static readonly IntPtr NativeFieldInfoPtr_ServerPositionOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726938, XrefRangeEnd = 726941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SetBuffTargetPositionToOwnerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetBuffTargetPositionToOwnerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetBuffTargetPositionToOwnerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetBuffTargetPositionToOwnerAuthoring()
    {
      Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SetBuffTargetPositionToOwnerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr);
      SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ClientPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr, nameof (ClientPositionOffset));
      SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ClientRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr, nameof (ClientRotationOffset));
      SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_AttatchmentBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr, nameof (AttatchmentBone));
      SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ServerPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr, nameof (ServerPositionOffset));
      SetBuffTargetPositionToOwnerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr, 100664283);
      SetBuffTargetPositionToOwnerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetBuffTargetPositionToOwnerAuthoring>.NativeClassPtr, 100664284);
    }

    public SetBuffTargetPositionToOwnerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float3 ClientPositionOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ClientPositionOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ClientPositionOffset)) = value;
      }
    }

    public unsafe float3 ClientRotationOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ClientRotationOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ClientRotationOffset)) = value;
      }
    }

    public unsafe HybridBoneEnum AttatchmentBone
    {
      get
      {
        return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_AttatchmentBone));
      }
      [param: In] set
      {
        *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_AttatchmentBone)) = value;
      }
    }

    public unsafe float3 ServerPositionOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ServerPositionOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetBuffTargetPositionToOwnerAuthoring.NativeFieldInfoPtr_ServerPositionOffset)) = value;
      }
    }
  }
}
