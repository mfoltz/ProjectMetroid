// Decompiled with JetBrains decompiler
// Type: IncompatibleWithTerritoriesAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class IncompatibleWithTerritoriesAuthoring : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IncompatibleWithTerritoriesAuthoring()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncompatibleWithTerritoriesAuthoring>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IncompatibleWithTerritoriesAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static IncompatibleWithTerritoriesAuthoring()
  {
    Il2CppClassPointerStore<IncompatibleWithTerritoriesAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (IncompatibleWithTerritoriesAuthoring));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncompatibleWithTerritoriesAuthoring>.NativeClassPtr);
    IncompatibleWithTerritoriesAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncompatibleWithTerritoriesAuthoring>.NativeClassPtr, 100663337);
  }

  public IncompatibleWithTerritoriesAuthoring(IntPtr pointer)
    : base(pointer)
  {
  }
}
