﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.IgnoreLocalizedStringBuilderField
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.UI
{
  public class IgnoreLocalizedStringBuilderField : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IgnoreLocalizedStringBuilderField()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreLocalizedStringBuilderField>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IgnoreLocalizedStringBuilderField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IgnoreLocalizedStringBuilderField()
    {
      Il2CppClassPointerStore<IgnoreLocalizedStringBuilderField>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (IgnoreLocalizedStringBuilderField));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreLocalizedStringBuilderField>.NativeClassPtr);
      IgnoreLocalizedStringBuilderField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreLocalizedStringBuilderField>.NativeClassPtr, 100670078);
    }

    public IgnoreLocalizedStringBuilderField(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
