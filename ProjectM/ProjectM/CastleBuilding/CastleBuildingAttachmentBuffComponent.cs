// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachmentBuffComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingAttachmentBuffComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ApplyOn;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_WhenMatchesTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125877, XrefRangeEnd = 1125903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingAttachmentBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingAttachmentBuffComponent()
    {
      Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachmentBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr);
      CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_ApplyOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr, nameof (ApplyOn));
      CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_BuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr, nameof (BuffPrefab));
      CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_WhenMatchesTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr, nameof (WhenMatchesTypes));
      CastleBuildingAttachmentBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr, 100689311);
      CastleBuildingAttachmentBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr, 100689312);
    }

    public CastleBuildingAttachmentBuffComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleBuildingAttachmentBuffApplyOn ApplyOn
    {
      get
      {
        return *(CastleBuildingAttachmentBuffApplyOn*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_ApplyOn));
      }
      [param: In] set
      {
        *(CastleBuildingAttachmentBuffApplyOn*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_ApplyOn)) = value;
      }
    }

    public unsafe PrefabGuidComponent BuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_BuffPrefab));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_BuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas WhenMatchesTypes
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_WhenMatchesTypes);
        return new CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.NativeFieldInfoPtr_WhenMatchesTypes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class WhenMatchesTypesDatas : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Manually;
      private static readonly System.IntPtr NativeFieldInfoPtr_FromAttachToInBrush;

      static WhenMatchesTypesDatas()
      {
        Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent>.NativeClassPtr, nameof (WhenMatchesTypesDatas));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr);
        CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas.NativeFieldInfoPtr_Manually = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr, nameof (Manually));
        CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas.NativeFieldInfoPtr_FromAttachToInBrush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr, nameof (FromAttachToInBrush));
      }

      public WhenMatchesTypesDatas(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public WhenMatchesTypesDatas()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas>.NativeClassPtr, data));
      }

      public unsafe PlacementTypeDataAsLongs Manually
      {
        get
        {
          return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas.NativeFieldInfoPtr_Manually));
        }
        [param: In] set
        {
          *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas.NativeFieldInfoPtr_Manually)) = value;
        }
      }

      public unsafe TileBrushPlacementComponent FromAttachToInBrush
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas.NativeFieldInfoPtr_FromAttachToInBrush));
          return pointer == System.IntPtr.Zero ? (TileBrushPlacementComponent) null : new TileBrushPlacementComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentBuffComponent.WhenMatchesTypesDatas.NativeFieldInfoPtr_FromAttachToInBrush), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
