// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityChargeBuff_DataClient
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityChargeBuff_DataClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousIsActive;
    [FieldOffset(0)]
    public SequenceGUID ChargedSequence;
    [FieldOffset(4)]
    public SequenceGUID ActiveSequence;
    [FieldOffset(8)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(16)]
    public bool PreviousIsActive;

    static AbilityChargeBuff_DataClient()
    {
      Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityChargeBuff_DataClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr);
      AbilityChargeBuff_DataClient.NativeFieldInfoPtr_ChargedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr, nameof (ChargedSequence));
      AbilityChargeBuff_DataClient.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr, nameof (ActiveSequence));
      AbilityChargeBuff_DataClient.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr, nameof (ActiveSequenceState));
      AbilityChargeBuff_DataClient.NativeFieldInfoPtr_PreviousIsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr, nameof (PreviousIsActive));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityChargeBuff_DataClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
