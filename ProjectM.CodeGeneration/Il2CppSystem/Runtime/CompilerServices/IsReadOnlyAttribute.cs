﻿// Decompiled with JetBrains decompiler
// Type: Il2CppSystem.Runtime.CompilerServices.IsReadOnlyAttribute
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Il2CppSystem.Runtime.CompilerServices
{
  public sealed class IsReadOnlyAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IsReadOnlyAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IsReadOnlyAttribute()
    {
      Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "System.Runtime.CompilerServices", nameof (IsReadOnlyAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr);
      IsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr, 100663298);
    }

    public IsReadOnlyAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
