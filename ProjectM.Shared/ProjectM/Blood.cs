// Decompiled with JetBrains decompiler
// Type: ProjectM.Blood
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Blood
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_LossPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Quality;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowBloodSequenceStartFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultBloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowBloodSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowBloodSequenceInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoBloodSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoBloodSequenceInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShareVBloodAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowBloodHUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreIdleDrain;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopDrainOnDisconnect;
    [FieldOffset(0)]
    public ModifiableFloat MaxBlood;
    [FieldOffset(8)]
    public ModifiableFloat LossPerSecond;
    [FieldOffset(16)]
    public float Value;
    [FieldOffset(20)]
    public float Quality;
    [FieldOffset(24)]
    public float LowBloodSequenceStartFactor;
    [FieldOffset(28)]
    public PrefabGUID BloodType;
    [FieldOffset(32)]
    public PrefabGUID DefaultBloodType;
    [FieldOffset(36)]
    public PrefabGUID DebuffPrefab;
    [FieldOffset(40)]
    public Entity DebuffEntity;
    [FieldOffset(48)]
    public PrefabGUID SCTType;
    [FieldOffset(52)]
    public SequenceGUID LowBloodSequenceGuid;
    [FieldOffset(56)]
    public SequenceState LowBloodSequenceInstance;
    [FieldOffset(64)]
    public SequenceGUID NoBloodSequenceGuid;
    [FieldOffset(68)]
    public SequenceState NoBloodSequenceInstance;
    [FieldOffset(76)]
    public PrefabGUID ShareVBloodAbility;
    [FieldOffset(80)]
    public ModifiableBool ShowBloodHUD;
    [FieldOffset(84)]
    public ModifiableBool IgnoreIdleDrain;
    [FieldOffset(88)]
    public bool StopDrainOnDisconnect;

    static Blood()
    {
      Il2CppClassPointerStore<Blood>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Blood));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blood>.NativeClassPtr);
      Blood.NativeFieldInfoPtr_MaxBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (MaxBlood));
      Blood.NativeFieldInfoPtr_LossPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (LossPerSecond));
      Blood.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (Value));
      Blood.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (Quality));
      Blood.NativeFieldInfoPtr_LowBloodSequenceStartFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (LowBloodSequenceStartFactor));
      Blood.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (BloodType));
      Blood.NativeFieldInfoPtr_DefaultBloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (DefaultBloodType));
      Blood.NativeFieldInfoPtr_DebuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (DebuffPrefab));
      Blood.NativeFieldInfoPtr_DebuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (DebuffEntity));
      Blood.NativeFieldInfoPtr_SCTType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (SCTType));
      Blood.NativeFieldInfoPtr_LowBloodSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (LowBloodSequenceGuid));
      Blood.NativeFieldInfoPtr_LowBloodSequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (LowBloodSequenceInstance));
      Blood.NativeFieldInfoPtr_NoBloodSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (NoBloodSequenceGuid));
      Blood.NativeFieldInfoPtr_NoBloodSequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (NoBloodSequenceInstance));
      Blood.NativeFieldInfoPtr_ShareVBloodAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (ShareVBloodAbility));
      Blood.NativeFieldInfoPtr_ShowBloodHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (ShowBloodHUD));
      Blood.NativeFieldInfoPtr_IgnoreIdleDrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (IgnoreIdleDrain));
      Blood.NativeFieldInfoPtr_StopDrainOnDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blood>.NativeClassPtr, nameof (StopDrainOnDisconnect));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Blood>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
