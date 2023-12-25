// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyMovementDuringCastActive
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyMovementDuringCastActive
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    [FieldOffset(0)]
    public double CastStartTime;
    [FieldOffset(8)]
    public Entity Ability;
    [FieldOffset(16)]
    public Entity Character;

    static ModifyMovementDuringCastActive()
    {
      Il2CppClassPointerStore<ModifyMovementDuringCastActive>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyMovementDuringCastActive));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyMovementDuringCastActive>.NativeClassPtr);
      ModifyMovementDuringCastActive.NativeFieldInfoPtr_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastActive>.NativeClassPtr, nameof (CastStartTime));
      ModifyMovementDuringCastActive.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastActive>.NativeClassPtr, nameof (Ability));
      ModifyMovementDuringCastActive.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastActive>.NativeClassPtr, nameof (Character));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyMovementDuringCastActive>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
