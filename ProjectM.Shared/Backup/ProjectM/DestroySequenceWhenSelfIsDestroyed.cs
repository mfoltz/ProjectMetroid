﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroySequenceWhenSelfIsDestroyed
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroySequenceWhenSelfIsDestroyed
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
    [FieldOffset(0)]
    public Entity SequenceEntity;

    static DestroySequenceWhenSelfIsDestroyed()
    {
      Il2CppClassPointerStore<DestroySequenceWhenSelfIsDestroyed>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroySequenceWhenSelfIsDestroyed));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroySequenceWhenSelfIsDestroyed>.NativeClassPtr);
      DestroySequenceWhenSelfIsDestroyed.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySequenceWhenSelfIsDestroyed>.NativeClassPtr, nameof (SequenceEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroySequenceWhenSelfIsDestroyed>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
