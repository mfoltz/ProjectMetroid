// Decompiled with JetBrains decompiler
// Type: SequencerProjectM.ContentTest_GlobalParticleSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using UnityEngine;

#nullable disable
namespace SequencerProjectM
{
  public static class ContentTest_GlobalParticleSystem : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_RunPrefabTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925817, XrefRangeEnd = 925837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunPrefabTest(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContentTest_GlobalParticleSystem.NativeMethodInfoPtr_RunPrefabTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ContentTest_GlobalParticleSystem()
    {
      Il2CppClassPointerStore<ContentTest_GlobalParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "SequencerProjectM", nameof (ContentTest_GlobalParticleSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentTest_GlobalParticleSystem>.NativeClassPtr);
      ContentTest_GlobalParticleSystem.NativeMethodInfoPtr_RunPrefabTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentTest_GlobalParticleSystem>.NativeClassPtr, 100663972);
    }

    public ContentTest_GlobalParticleSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
