// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class MapIconAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IsSiegeWeapon;
    private static readonly IntPtr NativeFieldInfoPtr_RequiresReveal;
    private static readonly IntPtr NativeFieldInfoPtr_CustomImplementation;
    private static readonly IntPtr NativeFieldInfoPtr_AllySetting;
    private static readonly IntPtr NativeFieldInfoPtr_EnemySetting;
    private static readonly IntPtr NativeFieldInfoPtr_HeaderLocalizedKey;
    private static readonly IntPtr NativeFieldInfoPtr_SubHeaderLocalizedKey;
    private static readonly IntPtr NativeFieldInfoPtr_ShowOutsideVision;
    private static readonly IntPtr NativeFieldInfoPtr_ShowOnMinimap;
    private static readonly IntPtr NativeFieldInfoPtr_ClampOnMinimap;
    private static readonly IntPtr NativeFieldInfoPtr_ShowObjectRotation;
    private static readonly IntPtr NativeFieldInfoPtr_RenderOrder;
    private static readonly IntPtr NativeFieldInfoPtr_NormalState;
    private static readonly IntPtr NativeFieldInfoPtr_HoverState;
    private static readonly IntPtr NativeFieldInfoPtr_VisualOverrides;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateIssue_Private_Void_byref_ContentIssue_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727256, XrefRangeEnd = 727279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MapIconAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727279, XrefRangeEnd = 727291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapIconAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727291, XrefRangeEnd = 727297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValidate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapIconAuthoring.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapIconAuthoring.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727297, XrefRangeEnd = 727304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateIssue(ref ContentIssue issue, string subIssue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      IntPtr* numPtr2 = numPtr1;
      IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) issue);
      IntPtr* numPtr3 = &ptr;
      *numPtr2 = (IntPtr) numPtr3;
      *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subIssue);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapIconAuthoring.NativeMethodInfoPtr_CreateIssue_Private_Void_byref_ContentIssue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ContentIssue local = ref issue;
      IntPtr pointer = ptr;
      ContentIssue contentIssue = pointer == IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
      local = contentIssue;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727304, XrefRangeEnd = 727383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapIconAuthoring.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727383, XrefRangeEnd = 727384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapIconAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapIconAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapIconAuthoring()
    {
      Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr);
      MapIconAuthoring.NativeFieldInfoPtr_IsSiegeWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (IsSiegeWeapon));
      MapIconAuthoring.NativeFieldInfoPtr_RequiresReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (RequiresReveal));
      MapIconAuthoring.NativeFieldInfoPtr_CustomImplementation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (CustomImplementation));
      MapIconAuthoring.NativeFieldInfoPtr_AllySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (AllySetting));
      MapIconAuthoring.NativeFieldInfoPtr_EnemySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (EnemySetting));
      MapIconAuthoring.NativeFieldInfoPtr_HeaderLocalizedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (HeaderLocalizedKey));
      MapIconAuthoring.NativeFieldInfoPtr_SubHeaderLocalizedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (SubHeaderLocalizedKey));
      MapIconAuthoring.NativeFieldInfoPtr_ShowOutsideVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (ShowOutsideVision));
      MapIconAuthoring.NativeFieldInfoPtr_ShowOnMinimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (ShowOnMinimap));
      MapIconAuthoring.NativeFieldInfoPtr_ClampOnMinimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (ClampOnMinimap));
      MapIconAuthoring.NativeFieldInfoPtr_ShowObjectRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (ShowObjectRotation));
      MapIconAuthoring.NativeFieldInfoPtr_RenderOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (RenderOrder));
      MapIconAuthoring.NativeFieldInfoPtr_NormalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (NormalState));
      MapIconAuthoring.NativeFieldInfoPtr_HoverState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (HoverState));
      MapIconAuthoring.NativeFieldInfoPtr_VisualOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, nameof (VisualOverrides));
      MapIconAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664347);
      MapIconAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664348);
      MapIconAuthoring.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664349);
      MapIconAuthoring.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664350);
      MapIconAuthoring.NativeMethodInfoPtr_CreateIssue_Private_Void_byref_ContentIssue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664351);
      MapIconAuthoring.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664352);
      MapIconAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIconAuthoring>.NativeClassPtr, 100664353);
    }

    public MapIconAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IsSiegeWeapon
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_IsSiegeWeapon));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_IsSiegeWeapon)) = value;
      }
    }

    public unsafe bool RequiresReveal
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_RequiresReveal));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_RequiresReveal)) = value;
      }
    }

    public unsafe bool CustomImplementation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_CustomImplementation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_CustomImplementation)) = value;
      }
    }

    public unsafe MapIconShowSettings AllySetting
    {
      get
      {
        return *(MapIconShowSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_AllySetting));
      }
      [param: In] set
      {
        *(MapIconShowSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_AllySetting)) = value;
      }
    }

    public unsafe MapIconShowSettings EnemySetting
    {
      get
      {
        return *(MapIconShowSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_EnemySetting));
      }
      [param: In] set
      {
        *(MapIconShowSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_EnemySetting)) = value;
      }
    }

    public unsafe LocalizationKey HeaderLocalizedKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_HeaderLocalizedKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_HeaderLocalizedKey)) = value;
      }
    }

    public unsafe LocalizationKey SubHeaderLocalizedKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_SubHeaderLocalizedKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_SubHeaderLocalizedKey)) = value;
      }
    }

    public unsafe bool ShowOutsideVision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ShowOutsideVision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ShowOutsideVision)) = value;
      }
    }

    public unsafe bool ShowOnMinimap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ShowOnMinimap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ShowOnMinimap)) = value;
      }
    }

    public unsafe bool ClampOnMinimap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ClampOnMinimap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ClampOnMinimap)) = value;
      }
    }

    public unsafe bool ShowObjectRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ShowObjectRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_ShowObjectRotation)) = value;
      }
    }

    public unsafe int RenderOrder
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_RenderOrder));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_RenderOrder)) = value;
      }
    }

    public MapIconState NormalState
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_NormalState);
        return new MapIconState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_NormalState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MapIconState HoverState
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_HoverState);
        return new MapIconState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_HoverState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe Il2CppReferenceArray<MapIconStates> VisualOverrides
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_VisualOverrides));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<MapIconStates>) null : new Il2CppReferenceArray<MapIconStates>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapIconAuthoring.NativeFieldInfoPtr_VisualOverrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
