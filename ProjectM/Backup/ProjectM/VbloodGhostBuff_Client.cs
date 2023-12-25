// Decompiled with JetBrains decompiler
// Type: ProjectM.VbloodGhostBuff_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VbloodGhostBuff_Client
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_NotTrackedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceState;
    [FieldOffset(0)]
    public SequenceGUID TrackedSequence;
    [FieldOffset(4)]
    public SequenceGUID NotTrackedSequence;
    [FieldOffset(8)]
    public SequenceState SequenceState;

    static VbloodGhostBuff_Client()
    {
      Il2CppClassPointerStore<VbloodGhostBuff_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VbloodGhostBuff_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VbloodGhostBuff_Client>.NativeClassPtr);
      VbloodGhostBuff_Client.NativeFieldInfoPtr_TrackedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VbloodGhostBuff_Client>.NativeClassPtr, nameof (TrackedSequence));
      VbloodGhostBuff_Client.NativeFieldInfoPtr_NotTrackedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VbloodGhostBuff_Client>.NativeClassPtr, nameof (NotTrackedSequence));
      VbloodGhostBuff_Client.NativeFieldInfoPtr_SequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VbloodGhostBuff_Client>.NativeClassPtr, nameof (SequenceState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VbloodGhostBuff_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
