// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.IGameObjectContentTest
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.ContentTesting
{
  public class IGameObjectContentTest : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_TestGroups_Public_Abstract_Virtual_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;

    public virtual unsafe TestGroupFlags TestGroups
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGameObjectContentTest.NativeMethodInfoPtr_get_TestGroups_Public_Abstract_Virtual_New_get_TestGroupFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGameObjectContentTest.NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IGameObjectContentTest()
    {
      Il2CppClassPointerStore<IGameObjectContentTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (IGameObjectContentTest));
      IGameObjectContentTest.NativeMethodInfoPtr_get_TestGroups_Public_Abstract_Virtual_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameObjectContentTest>.NativeClassPtr, 100667681);
      IGameObjectContentTest.NativeMethodInfoPtr_Test_Public_Abstract_Virtual_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameObjectContentTest>.NativeClassPtr, 100667682);
    }

    public IGameObjectContentTest(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
