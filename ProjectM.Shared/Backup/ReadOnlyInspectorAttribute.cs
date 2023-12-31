// Decompiled with JetBrains decompiler
// Type: ReadOnlyInspectorAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class ReadOnlyInspectorAttribute : PropertyAttribute
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(105)]
  [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ReadOnlyInspectorAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyInspectorAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ReadOnlyInspectorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ReadOnlyInspectorAttribute()
  {
    Il2CppClassPointerStore<ReadOnlyInspectorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ReadOnlyInspectorAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyInspectorAttribute>.NativeClassPtr);
    ReadOnlyInspectorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyInspectorAttribute>.NativeClassPtr, 100663518);
  }

  public ReadOnlyInspectorAttribute(IntPtr pointer)
    : base(pointer)
  {
  }
}
