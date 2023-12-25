// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellModAbilityGroupCharges
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModAbilityGroupCharges
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    [FieldOffset(0)]
    public PrefabGUID SpellMod;
    [FieldOffset(4)]
    public int Count;

    static SpellModAbilityGroupCharges()
    {
      Il2CppClassPointerStore<SpellModAbilityGroupCharges>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpellModAbilityGroupCharges));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModAbilityGroupCharges>.NativeClassPtr);
      SpellModAbilityGroupCharges.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModAbilityGroupCharges>.NativeClassPtr, nameof (SpellMod));
      SpellModAbilityGroupCharges.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModAbilityGroupCharges>.NativeClassPtr, nameof (Count));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModAbilityGroupCharges>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
