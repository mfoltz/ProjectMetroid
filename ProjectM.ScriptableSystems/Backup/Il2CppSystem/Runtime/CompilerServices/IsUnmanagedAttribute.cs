﻿// Decompiled with JetBrains decompiler
// Type: Il2CppSystem.Runtime.CompilerServices.IsUnmanagedAttribute
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Il2CppSystem.Runtime.CompilerServices
{
  public sealed class IsUnmanagedAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IsUnmanagedAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IsUnmanagedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IsUnmanagedAttribute()
    {
      Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "System.Runtime.CompilerServices", nameof (IsUnmanagedAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr);
      IsUnmanagedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr, 100663299);
    }

    public IsUnmanagedAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
