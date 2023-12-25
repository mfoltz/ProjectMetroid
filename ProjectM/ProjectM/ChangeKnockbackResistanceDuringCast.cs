// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeKnockbackResistanceDuringCast
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChangeKnockbackResistanceDuringCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackResistanceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    [FieldOffset(0)]
    public int KnockbackResistanceIndex;
    [FieldOffset(4)]
    public ModificationId ModificationId;

    static ChangeKnockbackResistanceDuringCast()
    {
      Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChangeKnockbackResistanceDuringCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast>.NativeClassPtr);
      ChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_KnockbackResistanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (KnockbackResistanceIndex));
      ChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (ModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
