// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.RestrictPlacementAreaAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  public class RestrictPlacementAreaAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaximumRadius;
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictAllTypes;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictSpecificTypes;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictOnlyPlayerBuilding;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictOnlyAgainstEnemies;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085593, XrefRangeEnd = 1085597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085597, XrefRangeEnd = 1085609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085609, XrefRangeEnd = 1085610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RestrictPlacementAreaAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RestrictPlacementAreaAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RestrictPlacementAreaAuthoring()
    {
      Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (RestrictPlacementAreaAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr);
      RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_MaximumRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, nameof (MaximumRadius));
      RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, nameof (Radius));
      RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictAllTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, nameof (RestrictAllTypes));
      RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictSpecificTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, nameof (RestrictSpecificTypes));
      RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictOnlyPlayerBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, nameof (RestrictOnlyPlayerBuilding));
      RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictOnlyAgainstEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, nameof (RestrictOnlyAgainstEnemies));
      RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, 100685509);
      RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, 100685510);
      RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, 100685511);
      RestrictPlacementAreaAuthoring.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, 100685512);
      RestrictPlacementAreaAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictPlacementAreaAuthoring>.NativeClassPtr, 100685513);
    }

    public RestrictPlacementAreaAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float MaximumRadius
    {
      get
      {
        float maximumRadius;
        IL2CPP.il2cpp_field_static_get_value(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_MaximumRadius, (void*) &maximumRadius);
        return maximumRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_MaximumRadius, (void*) &value);
      }
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe bool RestrictAllTypes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictAllTypes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictAllTypes)) = value;
      }
    }

    public unsafe PlacementTypeDataAsLongs RestrictSpecificTypes
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictSpecificTypes));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictSpecificTypes)) = value;
      }
    }

    public unsafe bool RestrictOnlyPlayerBuilding
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictOnlyPlayerBuilding));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictOnlyPlayerBuilding)) = value;
      }
    }

    public unsafe bool RestrictOnlyAgainstEnemies
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictOnlyAgainstEnemies));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestrictPlacementAreaAuthoring.NativeFieldInfoPtr_RestrictOnlyAgainstEnemies)) = value;
      }
    }
  }
}
