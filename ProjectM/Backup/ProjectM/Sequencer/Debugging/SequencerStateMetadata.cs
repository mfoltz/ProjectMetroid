﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Debugging.SequencerStateMetadata
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequencerStateMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indentation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    [FieldOffset(0)]
    public FixedString128 Name;
    [FieldOffset(128)]
    public int Indentation;
    [FieldOffset(132)]
    public int NodeIndex;

    static SequencerStateMetadata()
    {
      Il2CppClassPointerStore<SequencerStateMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer.Debugging", nameof (SequencerStateMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerStateMetadata>.NativeClassPtr);
      SequencerStateMetadata.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateMetadata>.NativeClassPtr, nameof (Name));
      SequencerStateMetadata.NativeFieldInfoPtr_Indentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateMetadata>.NativeClassPtr, nameof (Indentation));
      SequencerStateMetadata.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerStateMetadata>.NativeClassPtr, nameof (NodeIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequencerStateMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
