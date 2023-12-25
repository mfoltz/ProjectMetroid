// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_Shapeshift_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_Shapeshift_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShapeshiftModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateTowardsMovementModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodDrainValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodDrainModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnStatChangedListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveOnDamageTaken;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnAbilityEnd;
    [FieldOffset(0)]
    public ModificationId ShapeshiftModificationId;
    [FieldOffset(4)]
    public ModificationId RotateTowardsMovementModificationId;
    [FieldOffset(8)]
    public float BloodDrainValue;
    [FieldOffset(12)]
    public ModificationId BloodDrainModificationId;
    [FieldOffset(16)]
    public ListenerId OnStatChangedListener;
    [FieldOffset(24)]
    public bool RemoveOnDamageTaken;
    [FieldOffset(25)]
    public bool DestroyOnAbilityEnd;

    static Script_Buff_Shapeshift_DataShared()
    {
      Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_Shapeshift_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr);
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_ShapeshiftModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (ShapeshiftModificationId));
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_RotateTowardsMovementModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (RotateTowardsMovementModificationId));
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_BloodDrainValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (BloodDrainValue));
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_BloodDrainModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (BloodDrainModificationId));
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_OnStatChangedListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (OnStatChangedListener));
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_RemoveOnDamageTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (RemoveOnDamageTaken));
      Script_Buff_Shapeshift_DataShared.NativeFieldInfoPtr_DestroyOnAbilityEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, nameof (DestroyOnAbilityEnd));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_Shapeshift_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
