﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Pull_Entity
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Pull_Entity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardIndex;
    [FieldOffset(0)]
    public int BlackboardIndex;

    static Pull_Entity()
    {
      Il2CppClassPointerStore<Pull_Entity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Pull_Entity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pull_Entity>.NativeClassPtr);
      Pull_Entity.NativeFieldInfoPtr_BlackboardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pull_Entity>.NativeClassPtr, nameof (BlackboardIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pull_Entity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
