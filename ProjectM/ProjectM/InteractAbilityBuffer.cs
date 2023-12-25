// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractAbilityBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InteractAbilityBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideInteractHUDWhileCasting;
    [FieldOffset(0)]
    public PrefabGUID Ability;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(16)]
    public int Importance;
    [FieldOffset(20)]
    public bool HideInteractHUDWhileCasting;

    static InteractAbilityBuffer()
    {
      Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InteractAbilityBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr);
      InteractAbilityBuffer.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr, nameof (Ability));
      InteractAbilityBuffer.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr, nameof (Condition));
      InteractAbilityBuffer.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr, nameof (Importance));
      InteractAbilityBuffer.NativeFieldInfoPtr_HideInteractHUDWhileCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr, nameof (HideInteractHUDWhileCasting));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractAbilityBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
