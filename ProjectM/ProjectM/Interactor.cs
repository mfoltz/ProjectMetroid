// Decompiled with JetBrains decompiler
// Type: ProjectM.Interactor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Interactor
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MouseAimRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractAbilityGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceReleaseBeforeNextInteract;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public float MouseAimRadius;
    [FieldOffset(8)]
    public NetworkId TargetNetworkId;
    [FieldOffset(16)]
    public Entity Target;
    [FieldOffset(24)]
    public Entity PreviousTarget;
    [FieldOffset(32)]
    public PrefabGUID InteractAbilityGuid;
    [FieldOffset(36)]
    public SequenceGUID TargetSequenceGuid;
    [FieldOffset(40)]
    public SequenceState TargetSequence;
    [FieldOffset(48)]
    public bool ForceReleaseBeforeNextInteract;

    static Interactor()
    {
      Il2CppClassPointerStore<Interactor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Interactor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interactor>.NativeClassPtr);
      Interactor.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (Radius));
      Interactor.NativeFieldInfoPtr_MouseAimRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (MouseAimRadius));
      Interactor.NativeFieldInfoPtr_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (TargetNetworkId));
      Interactor.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (Target));
      Interactor.NativeFieldInfoPtr_PreviousTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (PreviousTarget));
      Interactor.NativeFieldInfoPtr_InteractAbilityGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (InteractAbilityGuid));
      Interactor.NativeFieldInfoPtr_TargetSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (TargetSequenceGuid));
      Interactor.NativeFieldInfoPtr_TargetSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (TargetSequence));
      Interactor.NativeFieldInfoPtr_ForceReleaseBeforeNextInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interactor>.NativeClassPtr, nameof (ForceReleaseBeforeNextInteract));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interactor>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
