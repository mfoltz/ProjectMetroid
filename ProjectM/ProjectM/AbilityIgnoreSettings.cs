// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityIgnoreSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityIgnoreSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnorePostCast;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreGlobalCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreAbilityImpair;
    [FieldOffset(0)]
    public bool IgnorePostCast;
    [FieldOffset(1)]
    public bool IgnoreGlobalCooldown;
    [FieldOffset(2)]
    public bool IgnoreAbilityImpair;

    static AbilityIgnoreSettings()
    {
      Il2CppClassPointerStore<AbilityIgnoreSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityIgnoreSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityIgnoreSettings>.NativeClassPtr);
      AbilityIgnoreSettings.NativeFieldInfoPtr_IgnorePostCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreSettings>.NativeClassPtr, nameof (IgnorePostCast));
      AbilityIgnoreSettings.NativeFieldInfoPtr_IgnoreGlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreSettings>.NativeClassPtr, nameof (IgnoreGlobalCooldown));
      AbilityIgnoreSettings.NativeFieldInfoPtr_IgnoreAbilityImpair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreSettings>.NativeClassPtr, nameof (IgnoreAbilityImpair));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityIgnoreSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
