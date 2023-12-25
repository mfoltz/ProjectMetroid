// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Brute_100_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Brute_100_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHealthRegainPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthRegainPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_AffectRecovery;
    [FieldOffset(0)]
    public float MinHealthRegainPercentage;
    [FieldOffset(4)]
    public float MaxHealthRegainPercentage;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;
    [FieldOffset(12)]
    public bool AffectRecovery;

    static BloodBuff_Brute_100_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Brute_100_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr);
      BloodBuff_Brute_100_DataShared.NativeFieldInfoPtr_MinHealthRegainPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr, nameof (MinHealthRegainPercentage));
      BloodBuff_Brute_100_DataShared.NativeFieldInfoPtr_MaxHealthRegainPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr, nameof (MaxHealthRegainPercentage));
      BloodBuff_Brute_100_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_Brute_100_DataShared.NativeFieldInfoPtr_AffectRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr, nameof (AffectRecovery));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Brute_100_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
