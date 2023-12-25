// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodTrackingEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodTrackingEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_Act;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitState;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsTracking;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsNewUnlockNotSeen;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
    [FieldOffset(0)]
    public PrefabGUID EntryId;
    [FieldOffset(4)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(8)]
    public int Level;
    [FieldOffset(12)]
    public int Act;
    [FieldOffset(16)]
    public LocalizationKey LocalizedName;
    [FieldOffset(32)]
    public LocalizationKey LocalizedDescription;
    [FieldOffset(48)]
    public VBloodUnitTrackingState UnitState;
    [FieldOffset(52)]
    public bool IsTracking;
    [FieldOffset(53)]
    public bool IsNewUnlockNotSeen;
    [FieldOffset(56)]
    public CardinalDirection Direction;
    [FieldOffset(60)]
    public int Distance;

    static VBloodTrackingEntry()
    {
      Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodTrackingEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr);
      VBloodTrackingEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (EntryId));
      VBloodTrackingEntry.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (PrefabGuid));
      VBloodTrackingEntry.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (Level));
      VBloodTrackingEntry.NativeFieldInfoPtr_Act = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (Act));
      VBloodTrackingEntry.NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (LocalizedName));
      VBloodTrackingEntry.NativeFieldInfoPtr_LocalizedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (LocalizedDescription));
      VBloodTrackingEntry.NativeFieldInfoPtr_UnitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (UnitState));
      VBloodTrackingEntry.NativeFieldInfoPtr_IsTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (IsTracking));
      VBloodTrackingEntry.NativeFieldInfoPtr_IsNewUnlockNotSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (IsNewUnlockNotSeen));
      VBloodTrackingEntry.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (Direction));
      VBloodTrackingEntry.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, nameof (Distance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodTrackingEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
