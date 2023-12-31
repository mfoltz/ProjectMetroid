// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_Scholar_MovementSpeedOnCast
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_Scholar_MovementSpeedOnCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChanceToGainMovementOnCast_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChanceToGainMovementOnCast_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public AssetGuid SCT;
    [FieldOffset(16)]
    public float ChanceToGainMovementOnCast_Min;
    [FieldOffset(20)]
    public float ChanceToGainMovementOnCast_Max;
    [FieldOffset(24)]
    public PrefabGUID MovementBuff;
    [FieldOffset(28)]
    public float RequiredBloodPercentage;

    static BloodBuffScript_Scholar_MovementSpeedOnCast()
    {
      Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_Scholar_MovementSpeedOnCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr);
      BloodBuffScript_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_SCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (SCT));
      BloodBuffScript_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (ChanceToGainMovementOnCast_Min));
      BloodBuffScript_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (ChanceToGainMovementOnCast_Max));
      BloodBuffScript_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_MovementBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (MovementBuff));
      BloodBuffScript_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_Scholar_MovementSpeedOnCast>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
