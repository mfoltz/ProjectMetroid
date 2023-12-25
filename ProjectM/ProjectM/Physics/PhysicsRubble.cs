// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.PhysicsRubble
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Physics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PhysicsRubble
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Age;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_DissolveDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnedSequence;
    [FieldOffset(0)]
    public float Age;
    [FieldOffset(4)]
    public float Duration;
    [FieldOffset(8)]
    public float DissolveDuration;
    [FieldOffset(12)]
    public SequenceGUID Sequence;
    [FieldOffset(16)]
    public bool SpawnedSequence;

    static PhysicsRubble()
    {
      Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Physics", nameof (PhysicsRubble));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr);
      PhysicsRubble.NativeFieldInfoPtr_Age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr, nameof (Age));
      PhysicsRubble.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr, nameof (Duration));
      PhysicsRubble.NativeFieldInfoPtr_DissolveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr, nameof (DissolveDuration));
      PhysicsRubble.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr, nameof (Sequence));
      PhysicsRubble.NativeFieldInfoPtr_SpawnedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr, nameof (SpawnedSequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsRubble>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
