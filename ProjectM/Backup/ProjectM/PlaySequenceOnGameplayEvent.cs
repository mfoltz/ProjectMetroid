// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaySequenceOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlaySequenceOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequencePositionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceRotationTarget;
    [FieldOffset(0)]
    public SequenceGUID SequenceGuid;
    [FieldOffset(4)]
    public PlaySequenceOnGameplayEventTarget SequencePositionTarget;
    [FieldOffset(8)]
    public PlaySequenceOnGameplayEventTarget SequenceRotationTarget;

    static PlaySequenceOnGameplayEvent()
    {
      Il2CppClassPointerStore<PlaySequenceOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaySequenceOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceOnGameplayEvent>.NativeClassPtr);
      PlaySequenceOnGameplayEvent.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEvent>.NativeClassPtr, nameof (SequenceGuid));
      PlaySequenceOnGameplayEvent.NativeFieldInfoPtr_SequencePositionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEvent>.NativeClassPtr, nameof (SequencePositionTarget));
      PlaySequenceOnGameplayEvent.NativeFieldInfoPtr_SequenceRotationTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEvent>.NativeClassPtr, nameof (SequenceRotationTarget));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaySequenceOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
