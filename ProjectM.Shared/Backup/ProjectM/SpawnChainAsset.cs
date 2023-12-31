// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SpawnChainAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Chain;
    private static readonly IntPtr NativeFieldInfoPtr_MainElement;
    private static readonly IntPtr NativeFieldInfoPtr_OnDestroyFallback;
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainAsset.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727992, XrefRangeEnd = 728087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_ContentTesting_IScriptableObjectContentTest_Test(
      TestContext<ScriptableObject> context,
      List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainAsset.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_ScriptableObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainAsset()
    {
      Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr);
      SpawnChainAsset.NativeFieldInfoPtr_Chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr, nameof (Chain));
      SpawnChainAsset.NativeFieldInfoPtr_MainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr, nameof (MainElement));
      SpawnChainAsset.NativeFieldInfoPtr_OnDestroyFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr, nameof (OnDestroyFallback));
      SpawnChainAsset.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr, 100664471);
      SpawnChainAsset.NativeMethodInfoPtr_ProjectM_ContentTesting_IScriptableObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_ScriptableObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr, 100664472);
      SpawnChainAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainAsset>.NativeClassPtr, 100664473);
    }

    public SpawnChainAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SpawnChainAssetElement> Chain
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAsset.NativeFieldInfoPtr_Chain));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SpawnChainAssetElement>) null : new Il2CppReferenceArray<SpawnChainAssetElement>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAsset.NativeFieldInfoPtr_Chain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnChainAssetElement MainElement
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAsset.NativeFieldInfoPtr_MainElement));
        return pointer == IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAsset.NativeFieldInfoPtr_MainElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnChainAssetElement OnDestroyFallback
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAsset.NativeFieldInfoPtr_OnDestroyFallback));
        return pointer == IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainAsset.NativeFieldInfoPtr_OnDestroyFallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
