﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.StripEntityFromWorldExcept
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StripEntityFromWorldExcept
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldType;
    [FieldOffset(0)]
    public WorldType WorldType;

    static StripEntityFromWorldExcept()
    {
      Il2CppClassPointerStore<StripEntityFromWorldExcept>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (StripEntityFromWorldExcept));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StripEntityFromWorldExcept>.NativeClassPtr);
      StripEntityFromWorldExcept.NativeFieldInfoPtr_WorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripEntityFromWorldExcept>.NativeClassPtr, nameof (WorldType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StripEntityFromWorldExcept>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
