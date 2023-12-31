// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushPlacementComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileBrushPlacementComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Types;
    private static readonly IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly IntPtr NativeFieldInfoPtr_Restrictions;
    private static readonly IntPtr NativeFieldInfoPtr_Replaces;
    private static readonly IntPtr NativeFieldInfoPtr_AttachesTo;
    private static readonly IntPtr NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPlacementData_Public_PlacementData_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TileBrushType BrushType
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushPlacementComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileBrushType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793438, XrefRangeEnd = 793446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ITileData GetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushPlacementComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ITileData) null : new ITileData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793446, XrefRangeEnd = 793452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlacementData GetPlacementData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushPlacementComponent.NativeMethodInfoPtr_GetPlacementData_Public_PlacementData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementData*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushPlacementComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793452, XrefRangeEnd = 793459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushPlacementComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushPlacementComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushPlacementComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushPlacementComponent()
    {
      Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushPlacementComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr);
      TileBrushPlacementComponent.NativeFieldInfoPtr_Types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, nameof (Types));
      TileBrushPlacementComponent.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, nameof (Requirements));
      TileBrushPlacementComponent.NativeFieldInfoPtr_Restrictions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, nameof (Restrictions));
      TileBrushPlacementComponent.NativeFieldInfoPtr_Replaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, nameof (Replaces));
      TileBrushPlacementComponent.NativeFieldInfoPtr_AttachesTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, nameof (AttachesTo));
      TileBrushPlacementComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, 100669888);
      TileBrushPlacementComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, 100669889);
      TileBrushPlacementComponent.NativeMethodInfoPtr_GetPlacementData_Public_PlacementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, 100669890);
      TileBrushPlacementComponent.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, 100669891);
      TileBrushPlacementComponent.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, 100669892);
      TileBrushPlacementComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushPlacementComponent>.NativeClassPtr, 100669893);
    }

    public TileBrushPlacementComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PlacementTypeDataAsLongs Types
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Types));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Types)) = value;
      }
    }

    public unsafe PlacementTypeDataAsLongs Requirements
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Requirements));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Requirements)) = value;
      }
    }

    public unsafe PlacementTypeDataAsLongs Restrictions
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Restrictions));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Restrictions)) = value;
      }
    }

    public unsafe PlacementTypeDataAsLongs Replaces
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Replaces));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_Replaces)) = value;
      }
    }

    public unsafe PlacementTypeDataAsLongs AttachesTo
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_AttachesTo));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushPlacementComponent.NativeFieldInfoPtr_AttachesTo)) = value;
      }
    }
  }
}
