// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityPositionInaccuracy
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityPositionInaccuracy
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyOnMovingTargets;
    [FieldOffset(0)]
    public float2 CurrentOffset;
    [FieldOffset(8)]
    public float MinDistance;
    [FieldOffset(12)]
    public float MaxDistance;
    [FieldOffset(16)]
    public bool OnlyOnMovingTargets;

    static AbilityPositionInaccuracy()
    {
      Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityPositionInaccuracy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr);
      AbilityPositionInaccuracy.NativeFieldInfoPtr_CurrentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr, nameof (CurrentOffset));
      AbilityPositionInaccuracy.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr, nameof (MinDistance));
      AbilityPositionInaccuracy.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr, nameof (MaxDistance));
      AbilityPositionInaccuracy.NativeFieldInfoPtr_OnlyOnMovingTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr, nameof (OnlyOnMovingTargets));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityPositionInaccuracy>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
