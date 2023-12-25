// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.BranchThroughGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BranchThroughGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTrue;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnFalse;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public GameplayEventId OnTrue;
    [FieldOffset(8)]
    public GameplayEventId OnFalse;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;

    static BranchThroughGameplayEvent()
    {
      Il2CppClassPointerStore<BranchThroughGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared", nameof (BranchThroughGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchThroughGameplayEvent>.NativeClassPtr);
      BranchThroughGameplayEvent.NativeFieldInfoPtr_OnTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchThroughGameplayEvent>.NativeClassPtr, nameof (OnTrue));
      BranchThroughGameplayEvent.NativeFieldInfoPtr_OnFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchThroughGameplayEvent>.NativeClassPtr, nameof (OnFalse));
      BranchThroughGameplayEvent.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchThroughGameplayEvent>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BranchThroughGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
