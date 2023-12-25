// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.WallpaperVariationComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class WallpaperVariationComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TestGroupFlags ProjectM\u002EContentTesting\u002EIGameObjectContentTest\u002ETestGroups
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(WallpaperVariationComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_ContentTesting_IGameObjectContentTest_Test(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallpaperVariationComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WallpaperVariationComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperVariationComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallpaperVariationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WallpaperVariationComponent()
    {
      Il2CppClassPointerStore<WallpaperVariationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (WallpaperVariationComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperVariationComponent>.NativeClassPtr);
      WallpaperVariationComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperVariationComponent>.NativeClassPtr, 100688099);
      WallpaperVariationComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperVariationComponent>.NativeClassPtr, 100688100);
      WallpaperVariationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperVariationComponent>.NativeClassPtr, 100688101);
    }

    public WallpaperVariationComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
