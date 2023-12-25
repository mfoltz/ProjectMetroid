// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityTarget
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityTarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTargetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategory;
    [FieldOffset(0)]
    public NetworkedEntity Target;
    [FieldOffset(12)]
    public AbilityTarget.Type GetTargetType;
    [FieldOffset(16)]
    public PrefabGUID Buff;
    [FieldOffset(24)]
    public BuffCategoryFlag BuffCategory;

    static AbilityTarget()
    {
      Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr);
      AbilityTarget.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr, nameof (Target));
      AbilityTarget.NativeFieldInfoPtr_GetTargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr, nameof (GetTargetType));
      AbilityTarget.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr, nameof (Buff));
      AbilityTarget.NativeFieldInfoPtr_BuffCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr, nameof (BuffCategory));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityTarget>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum Type
    {
      None = -1, // 0xFFFFFFFF
      InteractTarget = 0,
      GetFromBuffType = 1,
      GetFromBuffCategory = 2,
    }
  }
}
