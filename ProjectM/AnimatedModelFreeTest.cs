// Decompiled with JetBrains decompiler
// Type: AnimatedModelFreeTest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class AnimatedModelFreeTest : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AnimatedModelFreeTest()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedModelFreeTest>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AnimatedModelFreeTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AnimatedModelFreeTest()
  {
    Il2CppClassPointerStore<AnimatedModelFreeTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (AnimatedModelFreeTest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedModelFreeTest>.NativeClassPtr);
    AnimatedModelFreeTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedModelFreeTest>.NativeClassPtr, 100663482);
  }

  public AnimatedModelFreeTest(IntPtr pointer)
    : base(pointer)
  {
  }
}
