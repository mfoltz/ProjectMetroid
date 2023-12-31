// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainTransitionId
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
  public class SpawnChainTransitionId : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Id;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_ScriptableObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TestGroupFlags ProjectM\u002EContentTesting\u002EIScriptableObjectContentTest\u002ETestGroups
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionId.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728539, XrefRangeEnd = 728546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_ContentTesting_IScriptableObjectContentTest_Test(
      TestContext<ScriptableObject> context,
      List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionId.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_ScriptableObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainTransitionId()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainTransitionId()
    {
      Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainTransitionId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr);
      SpawnChainTransitionId.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr, nameof (Id));
      SpawnChainTransitionId.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr, 100664510);
      SpawnChainTransitionId.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_ScriptableObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr, 100664511);
      SpawnChainTransitionId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionId>.NativeClassPtr, 100664512);
    }

    public SpawnChainTransitionId(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Id
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionId.NativeFieldInfoPtr_Id)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainTransitionId.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
