// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Debugging.SequencerParameterMetadata
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequencerParameterMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardIndex;
    [FieldOffset(0)]
    public FixedString128 Name;
    [FieldOffset(128)]
    public BlackboardRegisterType Type;
    [FieldOffset(132)]
    public int BlackboardIndex;

    static SequencerParameterMetadata()
    {
      Il2CppClassPointerStore<SequencerParameterMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer.Debugging", nameof (SequencerParameterMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerParameterMetadata>.NativeClassPtr);
      SequencerParameterMetadata.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParameterMetadata>.NativeClassPtr, nameof (Name));
      SequencerParameterMetadata.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParameterMetadata>.NativeClassPtr, nameof (Type));
      SequencerParameterMetadata.NativeFieldInfoPtr_BlackboardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerParameterMetadata>.NativeClassPtr, nameof (BlackboardIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequencerParameterMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
