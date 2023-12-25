// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractableSequence
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InteractableSequence
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveInteractionSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveInteractionSequence;
    [FieldOffset(0)]
    public SequenceGUID ActiveInteractionSequenceGuid;
    [FieldOffset(4)]
    public SequenceState ActiveInteractionSequence;

    static InteractableSequence()
    {
      Il2CppClassPointerStore<InteractableSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InteractableSequence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableSequence>.NativeClassPtr);
      InteractableSequence.NativeFieldInfoPtr_ActiveInteractionSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableSequence>.NativeClassPtr, nameof (ActiveInteractionSequenceGuid));
      InteractableSequence.NativeFieldInfoPtr_ActiveInteractionSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableSequence>.NativeClassPtr, nameof (ActiveInteractionSequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractableSequence>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
