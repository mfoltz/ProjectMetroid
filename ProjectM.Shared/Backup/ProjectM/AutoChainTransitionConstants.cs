// Decompiled with JetBrains decompiler
// Type: ProjectM.AutoChainTransitionConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AutoChainTransitionConstants
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChainElementTransitionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionAttemptCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionAfterDuration;
    [FieldOffset(0)]
    public SpawnChainData.TransitionId TransitionId;
    [FieldOffset(32)]
    public int ChainElementTransitionIndex;
    [FieldOffset(36)]
    public float TransitionAttemptCooldown;
    [FieldOffset(40)]
    public float TransitionAfterDuration;

    static AutoChainTransitionConstants()
    {
      Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AutoChainTransitionConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr);
      AutoChainTransitionConstants.NativeFieldInfoPtr_TransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr, nameof (TransitionId));
      AutoChainTransitionConstants.NativeFieldInfoPtr_ChainElementTransitionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr, nameof (ChainElementTransitionIndex));
      AutoChainTransitionConstants.NativeFieldInfoPtr_TransitionAttemptCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr, nameof (TransitionAttemptCooldown));
      AutoChainTransitionConstants.NativeFieldInfoPtr_TransitionAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr, nameof (TransitionAfterDuration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AutoChainTransitionConstants>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
