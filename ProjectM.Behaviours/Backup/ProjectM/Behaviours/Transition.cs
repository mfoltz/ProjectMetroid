﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Transition
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Transition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewState;
    [FieldOffset(0)]
    public GenericEnemyState NewState;

    static Transition()
    {
      Il2CppClassPointerStore<Transition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Transition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transition>.NativeClassPtr);
      Transition.NativeFieldInfoPtr_NewState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transition>.NativeClassPtr, nameof (NewState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Transition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
