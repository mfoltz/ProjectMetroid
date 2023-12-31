// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SpawnSequenceForEntity
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnSequenceForEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandledPotentialError;
    [FieldOffset(0)]
    public SequenceGUID SequenceGuid;
    [FieldOffset(4)]
    public NetworkedEntity Target;
    [FieldOffset(16)]
    public NetworkedEntity SecondaryTarget;
    [FieldOffset(28)]
    public bool PlayOnSelf;
    [FieldOffset(32)]
    public float Scale;
    [FieldOffset(36)]
    public SequenceState SequenceInstance;
    [FieldOffset(44)]
    public bool HandledPotentialError;

    static SpawnSequenceForEntity()
    {
      Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Sequencer", nameof (SpawnSequenceForEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr);
      SpawnSequenceForEntity.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (SequenceGuid));
      SpawnSequenceForEntity.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (Target));
      SpawnSequenceForEntity.NativeFieldInfoPtr_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (SecondaryTarget));
      SpawnSequenceForEntity.NativeFieldInfoPtr_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (PlayOnSelf));
      SpawnSequenceForEntity.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (Scale));
      SpawnSequenceForEntity.NativeFieldInfoPtr_SequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (SequenceInstance));
      SpawnSequenceForEntity.NativeFieldInfoPtr_HandledPotentialError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, nameof (HandledPotentialError));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnSequenceForEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
