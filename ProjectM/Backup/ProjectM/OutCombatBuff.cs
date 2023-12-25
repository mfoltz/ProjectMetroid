// Decompiled with JetBrains decompiler
// Type: ProjectM.OutCombatBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OutCombatBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodDrainValue_WhileStandStill;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    [FieldOffset(0)]
    public float BloodDrainValue_WhileStandStill;
    [FieldOffset(4)]
    public ModificationId ModificationId;

    static OutCombatBuff()
    {
      Il2CppClassPointerStore<OutCombatBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (OutCombatBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutCombatBuff>.NativeClassPtr);
      OutCombatBuff.NativeFieldInfoPtr_BloodDrainValue_WhileStandStill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutCombatBuff>.NativeClassPtr, nameof (BloodDrainValue_WhileStandStill));
      OutCombatBuff.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutCombatBuff>.NativeClassPtr, nameof (ModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutCombatBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
