// Decompiled with JetBrains decompiler
// Type: ProjectM.DeadSequence
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DeadSequence
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalDeathSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalDeathSequenceState;
    [FieldOffset(0)]
    public SequenceGUID DeathSequenceGuid;
    [FieldOffset(4)]
    public SequenceState DeathSequenceState;
    [FieldOffset(12)]
    public SequenceGUID AdditionalDeathSequenceGuid;
    [FieldOffset(16)]
    public SequenceState AdditionalDeathSequenceState;

    static DeadSequence()
    {
      Il2CppClassPointerStore<DeadSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DeadSequence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadSequence>.NativeClassPtr);
      DeadSequence.NativeFieldInfoPtr_DeathSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadSequence>.NativeClassPtr, nameof (DeathSequenceGuid));
      DeadSequence.NativeFieldInfoPtr_DeathSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadSequence>.NativeClassPtr, nameof (DeathSequenceState));
      DeadSequence.NativeFieldInfoPtr_AdditionalDeathSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadSequence>.NativeClassPtr, nameof (AdditionalDeathSequenceGuid));
      DeadSequence.NativeFieldInfoPtr_AdditionalDeathSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadSequence>.NativeClassPtr, nameof (AdditionalDeathSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeadSequence>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
