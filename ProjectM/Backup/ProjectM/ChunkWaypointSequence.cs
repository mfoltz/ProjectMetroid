// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkWaypointSequence
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkWaypointSequence
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LockedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_LockedSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedSequenceState;
    [FieldOffset(0)]
    public SequenceGUID LockedSequence;
    [FieldOffset(4)]
    public SequenceState LockedSequenceState;
    [FieldOffset(12)]
    public SequenceGUID UnlockedSequence;
    [FieldOffset(16)]
    public SequenceState UnlockedSequenceState;

    static ChunkWaypointSequence()
    {
      Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChunkWaypointSequence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr);
      ChunkWaypointSequence.NativeFieldInfoPtr_LockedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr, nameof (LockedSequence));
      ChunkWaypointSequence.NativeFieldInfoPtr_LockedSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr, nameof (LockedSequenceState));
      ChunkWaypointSequence.NativeFieldInfoPtr_UnlockedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr, nameof (UnlockedSequence));
      ChunkWaypointSequence.NativeFieldInfoPtr_UnlockedSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr, nameof (UnlockedSequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkWaypointSequence>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
