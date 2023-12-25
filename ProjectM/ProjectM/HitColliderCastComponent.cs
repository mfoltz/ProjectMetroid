// Decompiled with JetBrains decompiler
// Type: ProjectM.HitColliderCastComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Physics;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HitColliderCastComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_AfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Shape;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiTargets;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryTargets_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryTargets_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrioritySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryFilterFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cone_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cone_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_Box_Width;
    private static readonly System.IntPtr NativeFieldInfoPtr_Box_Length;
    private static readonly System.IntPtr NativeFieldInfoPtr_Box_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShapeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Circle_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_OuterCircle_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerCircle_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cylinder_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cylinder_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContiniousCollisionCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanHitThroughBlockSpellCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreImmaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeTerrain;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainColliderModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods_Circle;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCylinder_Private_Void_Vector3_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011064, XrefRangeEnd = 1011073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitColliderCastComponent.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011073, XrefRangeEnd = 1011121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011121, XrefRangeEnd = 1011129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HitColliderCastComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011129, XrefRangeEnd = 1011145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastComponent.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011145, XrefRangeEnd = 1011152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCylinder(Vector3 position, float radius, float height)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastComponent.NativeMethodInfoPtr_DrawCylinder_Private_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011152, XrefRangeEnd = 1011153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HitColliderCastComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HitColliderCastComponent()
    {
      Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HitColliderCastComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr);
      HitColliderCastComponent.NativeFieldInfoPtr_CollisionTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (CollisionTrigger));
      HitColliderCastComponent.NativeFieldInfoPtr_AfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (AfterDuration));
      HitColliderCastComponent.NativeFieldInfoPtr_Shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Shape));
      HitColliderCastComponent.NativeFieldInfoPtr_MultiTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (MultiTargets));
      HitColliderCastComponent.NativeFieldInfoPtr_PrimaryTargets_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (PrimaryTargets_Count));
      HitColliderCastComponent.NativeFieldInfoPtr_SecondaryTargets_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (SecondaryTargets_Count));
      HitColliderCastComponent.NativeFieldInfoPtr_PrioritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (PrioritySettings));
      HitColliderCastComponent.NativeFieldInfoPtr_PrimaryFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (PrimaryFilterFlags));
      HitColliderCastComponent.NativeFieldInfoPtr_Cone_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Cone_Radius));
      HitColliderCastComponent.NativeFieldInfoPtr_Cone_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Cone_Angle));
      HitColliderCastComponent.NativeFieldInfoPtr_Box_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Box_Width));
      HitColliderCastComponent.NativeFieldInfoPtr_Box_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Box_Length));
      HitColliderCastComponent.NativeFieldInfoPtr_Box_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Box_Height));
      HitColliderCastComponent.NativeFieldInfoPtr_ShapeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (ShapeOffset));
      HitColliderCastComponent.NativeFieldInfoPtr_Circle_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Circle_Radius));
      HitColliderCastComponent.NativeFieldInfoPtr_OuterCircle_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (OuterCircle_Radius));
      HitColliderCastComponent.NativeFieldInfoPtr_InnerCircle_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (InnerCircle_Radius));
      HitColliderCastComponent.NativeFieldInfoPtr_Cylinder_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Cylinder_Radius));
      HitColliderCastComponent.NativeFieldInfoPtr_Cylinder_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (Cylinder_Height));
      HitColliderCastComponent.NativeFieldInfoPtr_ContiniousCollisionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (ContiniousCollisionCheck));
      HitColliderCastComponent.NativeFieldInfoPtr_CanHitThroughBlockSpellCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (CanHitThroughBlockSpellCollision));
      HitColliderCastComponent.NativeFieldInfoPtr_IgnoreImmaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (IgnoreImmaterial));
      HitColliderCastComponent.NativeFieldInfoPtr_IncludeTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (IncludeTerrain));
      HitColliderCastComponent.NativeFieldInfoPtr_TerrainColliderModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (TerrainColliderModifier));
      HitColliderCastComponent.NativeFieldInfoPtr_SpellMods_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (SpellMods_Circle));
      HitColliderCastComponent.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, 100678662);
      HitColliderCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, 100678663);
      HitColliderCastComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, 100678664);
      HitColliderCastComponent.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, 100678665);
      HitColliderCastComponent.NativeMethodInfoPtr_DrawCylinder_Private_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, 100678666);
      HitColliderCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, 100678667);
    }

    public HitColliderCastComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CollisionTrigger CollisionTrigger
    {
      get
      {
        return *(CollisionTrigger*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_CollisionTrigger));
      }
      [param: In] set
      {
        *(CollisionTrigger*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_CollisionTrigger)) = value;
      }
    }

    public unsafe float AfterDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_AfterDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_AfterDuration)) = value;
      }
    }

    public unsafe TriggerShapeType Shape
    {
      get
      {
        return *(TriggerShapeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Shape));
      }
      [param: In] set
      {
        *(TriggerShapeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Shape)) = value;
      }
    }

    public unsafe bool MultiTargets
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_MultiTargets));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_MultiTargets)) = value;
      }
    }

    public unsafe int PrimaryTargets_Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_PrimaryTargets_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_PrimaryTargets_Count)) = value;
      }
    }

    public unsafe int SecondaryTargets_Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_SecondaryTargets_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_SecondaryTargets_Count)) = value;
      }
    }

    public unsafe AoEFilterSettingsAsset PrioritySettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_PrioritySettings));
        return pointer == System.IntPtr.Zero ? (AoEFilterSettingsAsset) null : new AoEFilterSettingsAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_PrioritySettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionFilterFlags PrimaryFilterFlags
    {
      get
      {
        return *(CollisionFilterFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_PrimaryFilterFlags));
      }
      [param: In] set
      {
        *(CollisionFilterFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_PrimaryFilterFlags)) = value;
      }
    }

    public unsafe float Cone_Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cone_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cone_Radius)) = value;
      }
    }

    public unsafe float Cone_Angle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cone_Angle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cone_Angle)) = value;
      }
    }

    public unsafe float Box_Width
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Box_Width));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Box_Width)) = value;
      }
    }

    public unsafe float Box_Length
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Box_Length));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Box_Length)) = value;
      }
    }

    public unsafe float Box_Height
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Box_Height));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Box_Height)) = value;
      }
    }

    public unsafe Vector3 ShapeOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_ShapeOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_ShapeOffset)) = value;
      }
    }

    public unsafe float Circle_Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Circle_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Circle_Radius)) = value;
      }
    }

    public unsafe float OuterCircle_Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_OuterCircle_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_OuterCircle_Radius)) = value;
      }
    }

    public unsafe float InnerCircle_Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_InnerCircle_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_InnerCircle_Radius)) = value;
      }
    }

    public unsafe float Cylinder_Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cylinder_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cylinder_Radius)) = value;
      }
    }

    public unsafe float Cylinder_Height
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cylinder_Height));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_Cylinder_Height)) = value;
      }
    }

    public unsafe bool ContiniousCollisionCheck
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_ContiniousCollisionCheck));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_ContiniousCollisionCheck)) = value;
      }
    }

    public unsafe bool CanHitThroughBlockSpellCollision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_CanHitThroughBlockSpellCollision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_CanHitThroughBlockSpellCollision)) = value;
      }
    }

    public unsafe bool IgnoreImmaterial
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_IgnoreImmaterial));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_IgnoreImmaterial)) = value;
      }
    }

    public unsafe bool IncludeTerrain
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_IncludeTerrain));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_IncludeTerrain)) = value;
      }
    }

    public unsafe float TerrainColliderModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_TerrainColliderModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_TerrainColliderModifier)) = value;
      }
    }

    public HitColliderCastComponent.SpellModsAuthoring_Circle SpellMods_Circle
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_SpellMods_Circle);
        return new HitColliderCastComponent.SpellModsAuthoring_Circle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.NativeFieldInfoPtr_SpellMods_Circle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring_Circle : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Circle_Radius;

      static SpellModsAuthoring_Circle()
      {
        Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitColliderCastComponent>.NativeClassPtr, nameof (SpellModsAuthoring_Circle));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr);
        HitColliderCastComponent.SpellModsAuthoring_Circle.NativeFieldInfoPtr_Circle_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr, nameof (Circle_Radius));
      }

      public SpellModsAuthoring_Circle(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring_Circle()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitColliderCastComponent.SpellModsAuthoring_Circle>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Circle_Radius
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.SpellModsAuthoring_Circle.NativeFieldInfoPtr_Circle_Radius));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitColliderCastComponent.SpellModsAuthoring_Circle.NativeFieldInfoPtr_Circle_Radius), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
