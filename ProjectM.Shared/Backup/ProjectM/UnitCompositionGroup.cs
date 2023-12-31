// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionGroup
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
namespace ProjectM
{
  public class UnitCompositionGroup : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Weight;
    private static readonly IntPtr NativeFieldInfoPtr_UnitPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_TimeRequirement;
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 35341, RefRangeEnd = 35367, XrefRangeStart = 35341, XrefRangeEnd = 35367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionGroup.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763060, XrefRangeEnd = 763081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionGroup.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763081, XrefRangeEnd = 763082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitCompositionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitCompositionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitCompositionGroup()
    {
      Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr);
      UnitCompositionGroup.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr, nameof (Weight));
      UnitCompositionGroup.NativeFieldInfoPtr_UnitPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr, nameof (UnitPrefabs));
      UnitCompositionGroup.NativeFieldInfoPtr_TimeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr, nameof (TimeRequirement));
      UnitCompositionGroup.NativeMethodInfoPtr_get_TestGroups_Public_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr, 100667411);
      UnitCompositionGroup.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr, 100667412);
      UnitCompositionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionGroup>.NativeClassPtr, 100667413);
    }

    public UnitCompositionGroup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Weight
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionGroup.NativeFieldInfoPtr_Weight));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionGroup.NativeFieldInfoPtr_Weight)) = value;
      }
    }

    public unsafe List<WeakAssetReference<PrefabGuidComponent>> UnitPrefabs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionGroup.NativeFieldInfoPtr_UnitPrefabs));
        return pointer == IntPtr.Zero ? (List<WeakAssetReference<PrefabGuidComponent>>) null : new List<WeakAssetReference<PrefabGuidComponent>>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionGroup.NativeFieldInfoPtr_UnitPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DayTimeSpanSettings TimeRequirement
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionGroup.NativeFieldInfoPtr_TimeRequirement));
        return pointer == IntPtr.Zero ? (DayTimeSpanSettings) null : new DayTimeSpanSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitCompositionGroup.NativeFieldInfoPtr_TimeRequirement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
