﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleLimited
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleLimited
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    [FieldOffset(0)]
    public CastleLimitedType Type;

    static CastleLimited()
    {
      Il2CppClassPointerStore<CastleLimited>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastleLimited));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleLimited>.NativeClassPtr);
      CastleLimited.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleLimited>.NativeClassPtr, nameof (Type));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleLimited>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
