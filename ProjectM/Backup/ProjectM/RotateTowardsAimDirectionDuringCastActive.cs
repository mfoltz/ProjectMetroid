// Decompiled with JetBrains decompiler
// Type: ProjectM.RotateTowardsAimDirectionDuringCastActive
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RotateTowardsAimDirectionDuringCastActive
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialRotation;
    [FieldOffset(0)]
    public double CastStartTime;
    [FieldOffset(8)]
    public Entity Ability;
    [FieldOffset(16)]
    public Entity Character;
    [FieldOffset(24)]
    public quaternion InitialRotation;

    static RotateTowardsAimDirectionDuringCastActive()
    {
      Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RotateTowardsAimDirectionDuringCastActive));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr);
      RotateTowardsAimDirectionDuringCastActive.NativeFieldInfoPtr_CastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr, nameof (CastStartTime));
      RotateTowardsAimDirectionDuringCastActive.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr, nameof (Ability));
      RotateTowardsAimDirectionDuringCastActive.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr, nameof (Character));
      RotateTowardsAimDirectionDuringCastActive.NativeFieldInfoPtr_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr, nameof (InitialRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastActive>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
