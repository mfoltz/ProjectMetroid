// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityDirectionInaccuracy
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityDirectionInaccuracy
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDegrees;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDegrees;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyOnMovingTargets;
    [FieldOffset(0)]
    public float MaxDegrees;
    [FieldOffset(4)]
    public float CurrentDegrees;
    [FieldOffset(8)]
    public bool OnlyOnMovingTargets;

    static AbilityDirectionInaccuracy()
    {
      Il2CppClassPointerStore<AbilityDirectionInaccuracy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityDirectionInaccuracy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDirectionInaccuracy>.NativeClassPtr);
      AbilityDirectionInaccuracy.NativeFieldInfoPtr_MaxDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDirectionInaccuracy>.NativeClassPtr, nameof (MaxDegrees));
      AbilityDirectionInaccuracy.NativeFieldInfoPtr_CurrentDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDirectionInaccuracy>.NativeClassPtr, nameof (CurrentDegrees));
      AbilityDirectionInaccuracy.NativeFieldInfoPtr_OnlyOnMovingTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDirectionInaccuracy>.NativeClassPtr, nameof (OnlyOnMovingTargets));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDirectionInaccuracy>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
