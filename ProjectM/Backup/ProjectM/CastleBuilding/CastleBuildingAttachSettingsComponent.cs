// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachSettingsComponent
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
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingAttachSettingsComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MoveWithParentWhenAttached;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyWithParentWhenAttached;
    private static readonly IntPtr NativeFieldInfoPtr_LinkDestroyToParentWhenAttached;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictMoveWhenAttached;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictDismantleWhenAttached;
    private static readonly IntPtr NativeFieldInfoPtr_MoveWithParentAlsoMovesOtherParents;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125873, XrefRangeEnd = 1125876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachSettingsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125876, XrefRangeEnd = 1125877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingAttachSettingsComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachSettingsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingAttachSettingsComponent()
    {
      Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachSettingsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr);
      CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_MoveWithParentWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, nameof (MoveWithParentWhenAttached));
      CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_DestroyWithParentWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, nameof (DestroyWithParentWhenAttached));
      CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_LinkDestroyToParentWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, nameof (LinkDestroyToParentWhenAttached));
      CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_RestrictMoveWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, nameof (RestrictMoveWhenAttached));
      CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_RestrictDismantleWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, nameof (RestrictDismantleWhenAttached));
      CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_MoveWithParentAlsoMovesOtherParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, nameof (MoveWithParentAlsoMovesOtherParents));
      CastleBuildingAttachSettingsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, 100689309);
      CastleBuildingAttachSettingsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachSettingsComponent>.NativeClassPtr, 100689310);
    }

    public CastleBuildingAttachSettingsComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool MoveWithParentWhenAttached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_MoveWithParentWhenAttached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_MoveWithParentWhenAttached)) = value;
      }
    }

    public unsafe bool DestroyWithParentWhenAttached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_DestroyWithParentWhenAttached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_DestroyWithParentWhenAttached)) = value;
      }
    }

    public unsafe bool LinkDestroyToParentWhenAttached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_LinkDestroyToParentWhenAttached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_LinkDestroyToParentWhenAttached)) = value;
      }
    }

    public unsafe bool RestrictMoveWhenAttached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_RestrictMoveWhenAttached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_RestrictMoveWhenAttached)) = value;
      }
    }

    public unsafe bool RestrictDismantleWhenAttached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_RestrictDismantleWhenAttached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_RestrictDismantleWhenAttached)) = value;
      }
    }

    public unsafe bool MoveWithParentAlsoMovesOtherParents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_MoveWithParentAlsoMovesOtherParents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachSettingsComponent.NativeFieldInfoPtr_MoveWithParentAlsoMovesOtherParents)) = value;
      }
    }
  }
}
