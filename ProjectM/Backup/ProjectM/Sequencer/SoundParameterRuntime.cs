// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SoundParameterRuntime
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SoundParameterRuntime
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueParameter;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public BlackboardParameterRuntime ValueParameter;

    static SoundParameterRuntime()
    {
      Il2CppClassPointerStore<SoundParameterRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SoundParameterRuntime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundParameterRuntime>.NativeClassPtr);
      SoundParameterRuntime.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundParameterRuntime>.NativeClassPtr, nameof (Name));
      SoundParameterRuntime.NativeFieldInfoPtr_ValueParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundParameterRuntime>.NativeClassPtr, nameof (ValueParameter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SoundParameterRuntime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
