﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.MaterialTests
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ProjectM.ContentTesting
{
  public static class MaterialTests : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TestFadeOutSupport_Public_Static_Void_GameObject_List_1_ContentIssue_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TestFadeOutSupport(
      GameObject gameObject,
      List<ContentIssue> outIssues)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialTests.NativeMethodInfoPtr_TestFadeOutSupport_Public_Static_Void_GameObject_List_1_ContentIssue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialTests()
    {
      Il2CppClassPointerStore<MaterialTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (MaterialTests));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialTests>.NativeClassPtr);
      MaterialTests.NativeMethodInfoPtr_TestFadeOutSupport_Public_Static_Void_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialTests>.NativeClassPtr, 100667704);
    }

    public MaterialTests(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
