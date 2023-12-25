// Decompiled with JetBrains decompiler
// Type: ProjectM.PreviewPlacementSequence
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PreviewPlacementSequence
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValidPlacement;
    [FieldOffset(0)]
    public SequenceState Sequence;
    [FieldOffset(8)]
    public bool ValidPlacement;

    static PreviewPlacementSequence()
    {
      Il2CppClassPointerStore<PreviewPlacementSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PreviewPlacementSequence));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewPlacementSequence>.NativeClassPtr);
      PreviewPlacementSequence.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementSequence>.NativeClassPtr, nameof (Sequence));
      PreviewPlacementSequence.NativeFieldInfoPtr_ValidPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementSequence>.NativeClassPtr, nameof (ValidPlacement));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreviewPlacementSequence>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
