// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningRodStation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningRodStation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProcessingRecipe;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeToReset;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeProgressPerStrike;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumerRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadySequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadySequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorkingSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorkingSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompleteSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompleteSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverloadedSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverloadedSequenceState;
    [FieldOffset(0)]
    public LightningRodStationState State;
    [FieldOffset(4)]
    public PrefabGUID ProcessingRecipe;
    [FieldOffset(8)]
    public float Progress;
    [FieldOffset(12)]
    public float ResetTime;
    [FieldOffset(16)]
    public float TimeToReset;
    [FieldOffset(20)]
    public float TimeProgressPerStrike;
    [FieldOffset(24)]
    public float ConsumerRadius;
    [FieldOffset(28)]
    public SequenceGUID ReadySequenceGuid;
    [FieldOffset(32)]
    public SequenceState ReadySequenceState;
    [FieldOffset(40)]
    public SequenceGUID WorkingSequenceGuid;
    [FieldOffset(44)]
    public SequenceState WorkingSequenceState;
    [FieldOffset(52)]
    public SequenceGUID CompleteSequenceGuid;
    [FieldOffset(56)]
    public SequenceState CompleteSequenceState;
    [FieldOffset(64)]
    public SequenceGUID OverloadedSequenceGuid;
    [FieldOffset(68)]
    public SequenceState OverloadedSequenceState;

    static LightningRodStation()
    {
      Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LightningRodStation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr);
      LightningRodStation.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (State));
      LightningRodStation.NativeFieldInfoPtr_ProcessingRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (ProcessingRecipe));
      LightningRodStation.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (Progress));
      LightningRodStation.NativeFieldInfoPtr_ResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (ResetTime));
      LightningRodStation.NativeFieldInfoPtr_TimeToReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (TimeToReset));
      LightningRodStation.NativeFieldInfoPtr_TimeProgressPerStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (TimeProgressPerStrike));
      LightningRodStation.NativeFieldInfoPtr_ConsumerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (ConsumerRadius));
      LightningRodStation.NativeFieldInfoPtr_ReadySequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (ReadySequenceGuid));
      LightningRodStation.NativeFieldInfoPtr_ReadySequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (ReadySequenceState));
      LightningRodStation.NativeFieldInfoPtr_WorkingSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (WorkingSequenceGuid));
      LightningRodStation.NativeFieldInfoPtr_WorkingSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (WorkingSequenceState));
      LightningRodStation.NativeFieldInfoPtr_CompleteSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (CompleteSequenceGuid));
      LightningRodStation.NativeFieldInfoPtr_CompleteSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (CompleteSequenceState));
      LightningRodStation.NativeFieldInfoPtr_OverloadedSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (OverloadedSequenceGuid));
      LightningRodStation.NativeFieldInfoPtr_OverloadedSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, nameof (OverloadedSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningRodStation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
