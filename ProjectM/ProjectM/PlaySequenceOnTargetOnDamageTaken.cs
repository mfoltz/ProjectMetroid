// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaySequenceOnTargetOnDamageTaken
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlaySequenceOnTargetOnDamageTaken
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequencePrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageThreshold;
    [FieldOffset(0)]
    public SequenceGUID SequencePrefabGuid;
    [FieldOffset(4)]
    public float DamageThreshold;

    static PlaySequenceOnTargetOnDamageTaken()
    {
      Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTaken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaySequenceOnTargetOnDamageTaken));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTaken>.NativeClassPtr);
      PlaySequenceOnTargetOnDamageTaken.NativeFieldInfoPtr_SequencePrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTaken>.NativeClassPtr, nameof (SequencePrefabGuid));
      PlaySequenceOnTargetOnDamageTaken.NativeFieldInfoPtr_DamageThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTaken>.NativeClassPtr, nameof (DamageThreshold));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTaken>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
