// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyBloodDrainBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyBloodDrainBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodIdleValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreIdleDrainModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationIdleId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationIdleType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationIdlePriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_AffectBloodValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_AffectIdleBloodValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreIdleDrainWhileActive;
    [FieldOffset(0)]
    public float BloodValue;
    [FieldOffset(4)]
    public float BloodIdleValue;
    [FieldOffset(8)]
    public ModificationId ModificationId;
    [FieldOffset(12)]
    public ModificationId IgnoreIdleDrainModId;
    [FieldOffset(16)]
    public ModificationId ModificationIdleId;
    [FieldOffset(20)]
    public ModificationType ModificationType;
    [FieldOffset(21)]
    public ModificationType ModificationIdleType;
    [FieldOffset(24)]
    public int ModificationPriority;
    [FieldOffset(28)]
    public int ModificationIdlePriority;
    [FieldOffset(32)]
    public bool AffectBloodValue;
    [FieldOffset(33)]
    public bool AffectIdleBloodValue;
    [FieldOffset(34)]
    public bool IgnoreIdleDrainWhileActive;

    static ModifyBloodDrainBuff()
    {
      Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyBloodDrainBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr);
      ModifyBloodDrainBuff.NativeFieldInfoPtr_BloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (BloodValue));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_BloodIdleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (BloodIdleValue));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (ModificationId));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_IgnoreIdleDrainModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (IgnoreIdleDrainModId));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_ModificationIdleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (ModificationIdleId));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_ModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (ModificationType));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_ModificationIdleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (ModificationIdleType));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_ModificationPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (ModificationPriority));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_ModificationIdlePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (ModificationIdlePriority));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_AffectBloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (AffectBloodValue));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_AffectIdleBloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (AffectIdleBloodValue));
      ModifyBloodDrainBuff.NativeFieldInfoPtr_IgnoreIdleDrainWhileActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, nameof (IgnoreIdleDrainWhileActive));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyBloodDrainBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
